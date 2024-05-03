namespace Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
	string GenerateJwtToken(int userId, string fullName);
}