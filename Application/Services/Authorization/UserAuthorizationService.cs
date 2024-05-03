using System.Security.Claims;
using Application.Common.Exceptions;
using Application.Common.Interfaces.Authorization;

namespace Application.Services.Authorization;

public class UserAuthorizationService : IUserAuthorizationService
{
	public int GetUserIdFromJwtToken(ClaimsPrincipal user)
	{
		string? userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
		if (userId is null)
		{
			throw new UnauthorizedException("Faça login para utilizar desse recurso.");
		}

		return int.Parse(userId);
	}
}