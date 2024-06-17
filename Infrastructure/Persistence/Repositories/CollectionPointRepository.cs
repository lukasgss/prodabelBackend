using Application.Common.Interfaces.Entities.CollectionPoints;
using Domain.Entities;
using Infrastructure.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class CollectionPointRepository : GenericRepository<CollectionPoint>, ICollectionPointRepository
{
    private readonly AppDbContext _dbContext;
    public CollectionPointRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<CollectionPoint>> GetCollectionPointsBasedOnCep(int initialCep, int lastCep)
    {
        return await _dbContext.CollectionPoints.AsNoTracking()
            .Include(cp => cp.Company)
            .AsNoTracking()
            .Where(point => string.Compare(point.Cep.Replace("-", ""), initialCep.ToString()) >= 0 &&
                            string.Compare(point.Cep.Replace("-", ""), lastCep.ToString()) <= 0)
            .ToListAsync();
    }
}