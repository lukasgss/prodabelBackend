using Domain.Entities;

namespace Application.Common.Interfaces.Entities.Companies.DTOs;

public record EditCompanyRequest(
    string Name,
    string CepDeliveryInitialRange,
    string CepDeliveryEndRange,
    CollectionLine CollectionLine);
