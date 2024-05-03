using System.Diagnostics.CodeAnalysis;

namespace Application.Common.Validations.Errors;

public class ValidationError
{
	public required string Field { get; init; }
	public required string Message { get; init; }


	[SetsRequiredMembers]
	public ValidationError(string field, string message)
	{
		Field = field ?? throw new ArgumentNullException(nameof(field));
		Message = message ?? throw new ArgumentNullException(nameof(message));
	}
}