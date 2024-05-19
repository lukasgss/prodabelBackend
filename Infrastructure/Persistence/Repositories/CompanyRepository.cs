using Application.Common.Interfaces.Entities.Companies;
using Domain.Entities;
using Infrastructure.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
{
	private readonly AppDbContext _dbContext;

	public CompanyRepository(AppDbContext dbContext) : base(dbContext)
	{
		_dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
	}

	public async Task<IEnumerable<Company>> GetAllCompaniesAsync()
	{
		return await _dbContext.Companies
			.Include(company => company.Owner)
			.AsNoTracking()
			.ToListAsync();
	}

	public async Task<Company?> GetCompanyByIdAsync(int companyId)
	{
		return await _dbContext.Companies
			.Include(company => company.Owner)
			.SingleOrDefaultAsync(company => company.Id == companyId);
	}

	public async Task<Company?> GetCompanyByCnpjAsync(string cnpj)
	{
		return await _dbContext.Companies
			.AsNoTracking()
			.SingleOrDefaultAsync(company => company.Cnpj == cnpj);
	}
}