using Application.Common.Interfaces.Entities.Companies.DTOs;

namespace Application.Common.Interfaces.Entities.CollectionPoints.DTOs;

public record CollectionPointWithCompanyResponse(
    int Id,
    CompanySimplifiedResponse Company,
    string Cep,
    string Address,
    int Number);
