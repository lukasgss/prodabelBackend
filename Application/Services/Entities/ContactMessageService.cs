using Application.Common.Exceptions;
using Application.Common.Extensions.Mapping;
using Application.Common.Interfaces.Entities.ContactMessages;
using Application.Common.Interfaces.Entities.ContactMessages.DTOs;
using Domain.Entities;

namespace Application.Services.Entities;

public class ContactMessageService : IContactMessageService
{
    private readonly IContactMessageRepository _contactMessageRepository;

    public ContactMessageService(IContactMessageRepository contactMessageRepository)
    {
        _contactMessageRepository = contactMessageRepository;
    }

    public async Task<List<ContactMessageResponse>> GetContactMessages()
    {
        var results = await _contactMessageRepository.GetContactMessages();
        return results.ToListContactMessageResponses();
    }

    public async Task<ContactMessageResponse> GetContactMessageById(int id)
    {
        var contactMessage = await _contactMessageRepository.GetContactMessageById(id);
        if (contactMessage is null)
        {
            throw new NotFoundException("Mensagem com o id especificado não existe.");
        }

        return contactMessage.ToContactMessageResponse();
    }

    public async Task<ContactMessageResponse> CreateContactMessage(CreateContactMessage contactMessageRequest)
    {
        ContactMessage contactMessage = new()
        {
            Email = contactMessageRequest.Email,
            Subject = contactMessageRequest.Subject,
            Text = contactMessageRequest.Text
        };
        
        _contactMessageRepository.Add(contactMessage);
        await _contactMessageRepository.CommitAsync();

        return contactMessage.ToContactMessageResponse();
    }
}