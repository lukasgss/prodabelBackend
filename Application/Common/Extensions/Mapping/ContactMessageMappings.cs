using Application.Common.Interfaces.Entities.ContactMessages.DTOs;
using Domain.Entities;

namespace Application.Common.Extensions.Mapping;

public static class ContactMessageMappings
{
    public static ContactMessageResponse ToContactMessageResponse(this ContactMessage contactMessage)
    {
        return new ContactMessageResponse(
            Id: contactMessage.Id,
            Email: contactMessage.Email,
            Subject: contactMessage.Subject,
            Text: contactMessage.Text);
    }

    public static List<ContactMessageResponse> ToListContactMessageResponses(
        this IEnumerable<ContactMessage> contactMessages)
    {
        return contactMessages.Select(msg => msg.ToContactMessageResponse()).ToList();
    }
}