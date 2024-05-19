using Application.Common.Interfaces.Entities.Companies.DTOs;
using FluentValidation;

namespace Application.Common.Validations.CompanyValidations;

public class CreateCompanyRequestValidator : AbstractValidator<CreateCompanyRequest>
{
	public CreateCompanyRequestValidator()
	{
		RuleFor(company => company.Name)
			.NotEmpty()
			.WithMessage("O nome da empresa é obrigatório.");

		RuleFor(company => company.Cnpj)
			.NotEmpty()
			.WithMessage("O CNPJ da empresa é obrigatório.")
			.IsValidCNPJ()
			.WithMessage("CNPJ inválido.");

		RuleFor(company => company.CepDeliveryInitialRange)
			.NotEmpty()
			.WithMessage("Faixa de CEP de início é obrigatório.");

		RuleFor(company => company.CepDeliveryEndRange)
			.NotEmpty()
			.WithMessage("Faixa de CEP de fim é obrigatório.");
	}
}