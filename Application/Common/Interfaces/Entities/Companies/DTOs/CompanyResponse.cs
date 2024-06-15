using Application.Common.Interfaces.Entities.CollectionPoints.DTOs;
using Domain.Entities;

namespace Application.Common.Interfaces.Entities.Companies.DTOs;

public record CompanyResponse(
	int Id,
	string Name,
	string Cnpj,
	string Cep,
	string Address,
	int AddressNumber,
	string? CollectionLine,
	string PhoneNumber,
	List<CollectionPointResponse> CollectionPoints,
	string CepDeliveryInitialRange,
	string CepDeliveryEndRange);