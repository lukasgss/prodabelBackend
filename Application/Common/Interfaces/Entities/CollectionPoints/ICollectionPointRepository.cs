using Application.Common.Interfaces.GenericRepository;
using Domain.Entities;

namespace Application.Common.Interfaces.Entities.CollectionPoints;

public interface ICollectionPointRepository : IGenericRepository<CollectionPoint>
{
    Task<List<CollectionPoint>> GetCollectionPointsBasedOnCep(int initialCep, int lastCep);
}