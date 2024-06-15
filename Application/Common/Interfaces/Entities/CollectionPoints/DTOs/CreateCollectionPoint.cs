namespace Application.Common.Interfaces.Entities.CollectionPoints.DTOs;

public record CreateCollectionPoint(int CompanyId, string Cep, string Address, int Number);