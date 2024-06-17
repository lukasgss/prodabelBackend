namespace Application.Common.Interfaces.Entities.Companies.DTOs;

public record CompanySimplifiedResponse(
	string Name,
	string Cnpj,
	string Cep,
	string Address,
	int AddressNumber,
	string? CollectionLine,
	string PhoneNumber,
	string CepDeliveryInitialRange,
	string CepDeliveryEndRange);
