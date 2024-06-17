using Application.Common.Interfaces.Entities.ContactMessages.DTOs;

namespace Application.Common.Interfaces.Entities.ContactMessages;

public interface IContactMessageService
{
    Task<List<ContactMessageResponse>> GetContactMessages();
    Task<ContactMessageResponse> GetContactMessageById(int id);
    Task<ContactMessageResponse> CreateContactMessage(CreateContactMessage contactMessageRequest);
}