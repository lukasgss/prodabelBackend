using Application.Common.Exceptions;
using Application.Common.Extensions.Mapping;
using Application.Common.Interfaces.Entities.CollectionPoints;
using Application.Common.Interfaces.Entities.CollectionPoints.DTOs;
using Application.Common.Interfaces.Entities.Companies;
using Application.Common.Interfaces.Entities.Companies.DTOs;
using Application.Common.Interfaces.Entities.Users;
using Domain.Entities;

namespace Application.Services.Entities;

public class CompanyService : ICompanyService
{
	private readonly ICompanyRepository _companyRepository;
	private readonly IUserRepository _userRepository;
	private readonly ICollectionPointRepository _collectionPointRepository;

	public CompanyService(ICompanyRepository companyRepository,
		IUserRepository userRepository,
		ICollectionPointRepository collectionPointRepository)
	{
		_companyRepository = companyRepository ?? throw new ArgumentNullException(nameof(companyRepository));
		_userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
		_collectionPointRepository = collectionPointRepository;
	}

	public async Task<IEnumerable<CompanyResponse>> GetAllCompanies()
	{
		var allCompanies = await _companyRepository.GetAllCompaniesAsync();

		return allCompanies.ToCompanyResponse();
	}

	public async Task<CompanyResponse> GetCompanyByIdAsync(int id)
	{
		Company? company = await _companyRepository.GetCompanyByIdAsync(id);
		if (company is null)
		{
			throw new NotFoundException("Empresa com o id especificado não foi encontrada.");
		}

		return company.ToCompanyResponse();
	}

	public async Task AssignCollectionPoint(CreateCollectionPoint createCollectionPoint)
	{
		Company? company = await _companyRepository.GetCompanyByIdAsync(createCollectionPoint.CompanyId);
		if (company is null)
		{
			throw new NotFoundException("Empresa com o id especificado não foi encontrada.");
		}

		CollectionPoint collectionPoint = new()
		{
			Address = createCollectionPoint.Address,
			Cep = createCollectionPoint.Cep,
			Number = createCollectionPoint.Number,
		};
		company.CollectionPoints.Add(collectionPoint);

		_collectionPointRepository.Add(collectionPoint);
		await _collectionPointRepository.CommitAsync();
	}

	public async Task<CompanyResponse> CreateCompanyAsync(CreateCompanyRequest createCompanyRequest, int userId)
	{
		User? owner = await _userRepository.GetUserByIdAsync(userId);
		if (owner is null)
		{
			throw new NotFoundException("Usuário com o id especificado não foi encontrado");
		}

		Company? existingCompany = await _companyRepository.GetCompanyByCnpjAsync(createCompanyRequest.Cnpj);
		if (existingCompany is not null)
		{
			throw new ConflictException("Empresa com CNPJ especificado já existe.");
		}

		Company company = new()
		{
			Name = createCompanyRequest.Name,
			Cnpj = createCompanyRequest.Cnpj,
			CepDeliveryInitialRange = createCompanyRequest.CepDeliveryInitialRange,
			CepDeliveryEndRange = createCompanyRequest.CepDeliveryEndRange,
			PhoneNumber = createCompanyRequest.PhoneNumber,
			Cep = createCompanyRequest.Cep,
			Address = createCompanyRequest.Address,
			CollectionLine = createCompanyRequest.CollectionLine,
			AddressNumber = createCompanyRequest.AddressNumber,
			Owner = owner,
			OwnerId = owner.Id
		};

		_companyRepository.Add(company);
		await _companyRepository.CommitAsync();

		return company.ToCompanyResponse();
	}

	public async Task<CompanyResponse> EditCompanyAsync(EditCompanyRequest editCompanyRequest, int companyId,
		int userId)
	{
		User? user = await _userRepository.GetUserByIdAsync(userId);
		if (user is null)
		{
			throw new UnauthorizedException("Não foi possível realizar a edição da empresa.");
		}

		Company? company = await _companyRepository.GetCompanyByIdAsync(companyId);
		if (company is null)
		{
			throw new NotFoundException("Empresa com o id especificado não foi encontrada.");
		}

		if (user.Id != company.Owner.Id)
		{
			throw new ForbiddenException("Não é possível editar empresas no qual não é dono.");
		}

		company.Name = editCompanyRequest.Name;
		company.CepDeliveryInitialRange = editCompanyRequest.CepDeliveryInitialRange;
		company.CepDeliveryEndRange = editCompanyRequest.CepDeliveryEndRange;
		company.CollectionLine = editCompanyRequest.CollectionLine;

		await _companyRepository.CommitAsync();

		return company.ToCompanyResponse();
	}

	public async Task DeleteCompanyAsync(int id, int userId)
	{
		User? user = await _userRepository.GetUserByIdAsync(userId);
		if (user is null)
		{
			throw new UnauthorizedException("Não foi possível realizar a exclusão da empresa.");
		}

		Company? company = await _companyRepository.GetCompanyByIdAsync(id);
		if (company is null)
		{
			throw new NotFoundException("Empresa com o id especificado não foi encontrada.");
		}

		if (user.Id != company.Owner.Id)
		{
			throw new ForbiddenException("Não é possível excluir empresas no qual não é dono.");
		}

		_companyRepository.Delete(company);
		await _companyRepository.CommitAsync();
	}
}