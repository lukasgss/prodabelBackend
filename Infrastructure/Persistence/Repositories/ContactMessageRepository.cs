using Application.Common.Interfaces.Entities.ContactMessages;
using Domain.Entities;
using Infrastructure.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class ContactMessageRepository : GenericRepository<ContactMessage>, IContactMessageRepository
{
    private readonly AppDbContext _dbContext;
    public ContactMessageRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ContactMessage?> GetContactMessageById(int? id)
    {
        return await _dbContext.ContactMessages.SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<ContactMessage>> GetContactMessages()
    {
        return await _dbContext.ContactMessages.ToListAsync();
    }
}