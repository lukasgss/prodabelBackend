using Application.Common.Interfaces.Entities.Companies.DTOs;

namespace Application.Common.Interfaces.Entities.Companies;

public interface ICompanyService
{
	Task<IEnumerable<CompanyResponse>> GetAllCompanies();
	Task<CompanyResponse> GetCompanyByIdAsync(int id);
	Task<CompanyResponse> CreateCompanyAsync(CreateCompanyRequest createCompanyRequest, int userId);
	Task<CompanyResponse> EditCompanyAsync(EditCompanyRequest editCompanyRequest, int companyId, int userId);
	Task DeleteCompanyAsync(int id, int userId);
}