namespace Application.Common.Interfaces.Entities.Companies.DTOs;

public record CreateCompanyRequest(
	string Name,
	string Cnpj,
	string CepDeliveryInitialRange,
	string CepDeliveryEndRange);