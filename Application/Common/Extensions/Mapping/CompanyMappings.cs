using Application.Common.Interfaces.Entities.Companies.DTOs;
using Domain.Entities;

namespace Application.Common.Extensions.Mapping;

public static class CompanyMappings
{
	public static CompanyResponse ToCompanyResponse(this Company company)
	{
		return new CompanyResponse(
			Id: company.Id,
			Name: company.Name,
			Cnpj: company.Cnpj,
			CepDeliveryInitialRange: company.CepDeliveryInitialRange,
			CepDeliveryEndRange: company.CepDeliveryEndRange,
			Address: company.Address,
			PhoneNumber: company.PhoneNumber,
			Cep:company.Cep,
			AddressNumber:company.AddressNumber,
			CollectionLine:company.CollectionLine.ToString(),
			CollectionPoints: company.CollectionPoints.ToCollectionPointResponses());
	}

	public static CompanySimplifiedResponse ToCompanySimplifiedResponse(this Company company)
	{
		return new CompanySimplifiedResponse(
			Name: company.Name,
			Cnpj: company.Cnpj,
			CepDeliveryInitialRange: company.CepDeliveryInitialRange,
			CepDeliveryEndRange: company.CepDeliveryEndRange,
			Address: company.Address,
			PhoneNumber: company.PhoneNumber,
			Cep: company.Cep,
			AddressNumber: company.AddressNumber,
			CollectionLine: company.CollectionLine.ToString());

	}

	public static IEnumerable<CompanyResponse> ToCompanyResponse(this IEnumerable<Company> companies)
	{
		return companies.Select(company => company.ToCompanyResponse());
	}
}