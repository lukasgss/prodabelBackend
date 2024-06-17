using Application.Common.Interfaces.GenericRepository;
using Domain.Entities;

namespace Application.Common.Interfaces.Entities.ContactMessages;

public interface IContactMessageRepository : IGenericRepository<ContactMessage>
{
    Task<ContactMessage?> GetContactMessageById(int? id);
    Task<List<ContactMessage>> GetContactMessages();
}