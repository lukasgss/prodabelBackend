using Application.Common.Interfaces.Entities.Users.DTOs;
using FluentValidation;

namespace Application.Common.Validations.UserValidations;

public class EditUserRequestValidator : AbstractValidator<EditUserRequest>
{
	public EditUserRequestValidator()
	{
		RuleFor(user => user.FullName)
			.NotEmpty()
			.WithMessage("Campo de nome completo é obrigatório.")
			.MaximumLength(255)
			.WithMessage("Máximo de 255 caracteres permitidos.");

		RuleFor(user => user.PhoneNumber)
			.NotEmpty()
			.WithMessage("Campo de telefone é obrigatório.")
			.MaximumLength(255)
			.WithMessage("Máximo de 255 caracteres permitidos.");
	}
}