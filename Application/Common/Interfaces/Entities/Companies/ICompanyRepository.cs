using Application.Common.Interfaces.GenericRepository;
using Domain.Entities;

namespace Application.Common.Interfaces.Entities.Companies;

public interface ICompanyRepository : IGenericRepository<Company>
{
	Task<IEnumerable<Company>> GetAllCompaniesAsync();
	Task<Company?> GetCompanyByIdAsync(int companyId);
	Task<Company?> GetCompanyByCnpjAsync(string cpnj);
}