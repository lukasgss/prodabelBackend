using Application.Common.Interfaces.Entities.CollectionPoints.DTOs;
using Domain.Entities;

namespace Application.Common.Extensions.Mapping;

public static class CollectionPointMappings
{
    public static CollectionPointResponse ToCollectionPointResponse(this CollectionPoint collectionPoint)
    {
        return new CollectionPointResponse(collectionPoint.Id,
            collectionPoint.CompanyId,
            collectionPoint.Cep,
            collectionPoint.Address,
            collectionPoint.Number);
    }

    public static CollectionPointWithCompanyResponse ToCollectionPointWithCompanyResponse(
        this CollectionPoint collectionPoint)
    {
        return new CollectionPointWithCompanyResponse(collectionPoint.Id,
            collectionPoint.Company.ToCompanySimplifiedResponse(),
            collectionPoint.Cep,
            collectionPoint.Address,
            collectionPoint.Number);
    }

    public static List<CollectionPointWithCompanyResponse> ToCollectionPointWithCompanyResponses(
        this IEnumerable<CollectionPoint> collectionPoints)
    {
        return collectionPoints.Select(collectionPoint => collectionPoint.ToCollectionPointWithCompanyResponse())
            .ToList();
    }

    public static List<CollectionPointResponse> ToCollectionPointResponses(
        this IEnumerable<CollectionPoint> collectionPoints)
    {
        return collectionPoints.Select(collectionPoint => collectionPoint.ToCollectionPointResponse())
            .ToList();
    }
}