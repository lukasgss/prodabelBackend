namespace Application.Common.Interfaces.Entities.CollectionPoints.DTOs;

public record CollectionPointResponse(int Id, int CompanyId, string Cep, string Address, int Number);