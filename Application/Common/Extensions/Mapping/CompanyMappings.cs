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
			CepDeliveryEndRange: company.CepDeliveryEndRange);
	}

	public static IEnumerable<CompanyResponse> ToCompanyResponse(this IEnumerable<Company> companies)
	{
		return companies.Select(company => company.ToCompanyResponse());
	}
}