using Domain.Entities;

namespace Application.Common.Interfaces.Entities.Companies.DTOs;

public record CreateCompanyRequest(
	string Name,
	string Cnpj,
	string Cep,
	string Address,
	string PhoneNumber,
	int AddressNumber,
	CollectionLine CollectionLine,
	string CepDeliveryInitialRange,
	string CepDeliveryEndRange);