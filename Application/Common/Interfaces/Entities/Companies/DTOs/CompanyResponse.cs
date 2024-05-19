namespace Application.Common.Interfaces.Entities.Companies.DTOs;

public record CompanyResponse(
	int Id,
	string Name,
	string Cnpj,
	string CepDeliveryInitialRange,
	string CepDeliveryEndRange);