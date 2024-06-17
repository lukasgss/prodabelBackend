using Application.Common.Interfaces.Entities.CollectionPoints.DTOs;

namespace Application.Common.Interfaces.Entities.CollectionPoints;

public interface ICollectionPointService
{
    Task<List<CollectionPointWithCompanyResponse>> GetCollectionPointsBasedOnCep(string cep);
}