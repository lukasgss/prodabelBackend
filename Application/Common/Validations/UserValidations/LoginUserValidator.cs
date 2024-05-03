using Application.Common.Interfaces.Entities.Users.DTOs;
using FluentValidation;

namespace Application.Common.Validations.UserValidations;

public class LoginUserValidator : AbstractValidator<UserLoginRequest>
{
	public LoginUserValidator()
	{
		RuleFor(user => user.Email)
			.NotEmpty()
			.WithMessage("Campo de e-mail é obrigatório.")
			.EmailAddress()
			.WithMessage("Endereço de e-mail inválido.");

		RuleFor(user => user.Password)
			.NotEmpty()
			.WithMessage("Campo de senha é obrigatório.");
	}
}