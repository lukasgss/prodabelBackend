using Application.Common.Interfaces.Authorization;
using Application.Common.Interfaces.Entities.Companies;
using Application.Common.Interfaces.Entities.Companies.DTOs;
using Application.Common.Validations.CompanyValidations;
using Application.Common.Validations.Errors;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/api/companies")]
public class CompanyController : ControllerBase
{
	private readonly ICompanyService _companyService;
	private readonly IUserAuthorizationService _userAuthorizationService;

	public CompanyController(ICompanyService companyService, IUserAuthorizationService userAuthorizationService)
	{
		_companyService = companyService ?? throw new ArgumentNullException(nameof(companyService));
		_userAuthorizationService = userAuthorizationService ??
		                            throw new ArgumentNullException(nameof(userAuthorizationService));
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<CompanyResponse>>> GetAllCompanies()
	{
		var companies = await _companyService.GetAllCompanies();
		return Ok(companies);
	}

	[HttpGet("{companyId:int}", Name = "GetCompanyById")]
	public async Task<ActionResult<CompanyResponse>> GetCompanyById(int companyId)
	{
		return await _companyService.GetCompanyByIdAsync(companyId);
	}

	[Authorize, HttpPost]
	public async Task<ActionResult<CompanyResponse>> CreateCompanyAsync(CreateCompanyRequest createCompanyRequest)
	{
		CreateCompanyRequestValidator requestValidator = new();
		ValidationResult validationResult = await requestValidator.ValidateAsync(createCompanyRequest);
		if (!validationResult.IsValid)
		{
			var errors =
				validationResult.Errors.Select(e => new ValidationError(e.PropertyName, e.ErrorMessage));
			return BadRequest(errors);
		}

		int userId = _userAuthorizationService.GetUserIdFromJwtToken(User);

		return await _companyService.CreateCompanyAsync(createCompanyRequest, userId);
	}

	[Authorize, HttpPut("{companyId:int}")]
	public async Task<ActionResult<CompanyResponse>> EditCompanyAsync(EditCompanyRequest editCompanyRequest,
		int companyId)
	{
		EditCompanyRequestValidator requestValidator = new();
		ValidationResult validationResult = await requestValidator.ValidateAsync(editCompanyRequest);
		if (!validationResult.IsValid)
		{
			var errors =
				validationResult.Errors.Select(e => new ValidationError(e.PropertyName, e.ErrorMessage));
			return BadRequest(errors);
		}

		int userId = _userAuthorizationService.GetUserIdFromJwtToken(User);

		return await _companyService.EditCompanyAsync(editCompanyRequest, companyId, userId);
	}

	[Authorize, HttpDelete("{companyId:int}")]
	public async Task<ActionResult> DeleteCompanyAsync(int companyId)
	{
		int userId = _userAuthorizationService.GetUserIdFromJwtToken(User);

		await _companyService.DeleteCompanyAsync(companyId, userId);
		return NoContent();
	}
}