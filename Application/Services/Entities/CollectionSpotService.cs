using Application.Common.Extensions.Mapping;
using Application.Common.Interfaces.Entities.CollectionPoints;
using Application.Common.Interfaces.Entities.CollectionPoints.DTOs;

namespace Application.Services.Entities;

public class CollectionSpotService : ICollectionPointService
{
    private readonly ICollectionPointRepository _collectionPointRepository;

    public CollectionSpotService(ICollectionPointRepository collectionPointRepository)
    {
        _collectionPointRepository = collectionPointRepository;
    }

    public async Task<List<CollectionPointWithCompanyResponse>> GetCollectionPointsBasedOnCep(string cep)
    {
        int normalizedCep = int.Parse(cep.Replace("-", ""));
        int initialCep = normalizedCep - 4000;
        int lastCep = normalizedCep + 4000;
        var collectionPoints = await _collectionPointRepository.GetCollectionPointsBasedOnCep(initialCep, lastCep);

        return collectionPoints.ToCollectionPointWithCompanyResponses();
    }
}