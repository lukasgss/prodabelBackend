using Application.Common.Interfaces.Entities.CollectionPoints;
using Domain.Entities;
using Infrastructure.Persistence.DataContext;

namespace Infrastructure.Persistence.Repositories;

public class CollectionPointRepository : GenericRepository<CollectionPoint>, ICollectionPointRepository
{
    public CollectionPointRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}