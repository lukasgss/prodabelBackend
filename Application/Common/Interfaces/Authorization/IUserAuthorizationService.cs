using System.Security.Claims;

namespace Application.Common.Interfaces.Authorization;

public interface IUserAuthorizationService
{
	int GetUserIdFromJwtToken(ClaimsPrincipal user);
}