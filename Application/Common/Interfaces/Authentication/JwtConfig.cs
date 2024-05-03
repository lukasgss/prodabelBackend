namespace Application.Common.Interfaces.Authentication;

public class JwtConfig
{
	public const string SectionName = "JwtSettings";

	public required string SecretKey { get; init; }
	public required string Audience { get; init; } = null!;
	public required string Issuer { get; init; } = null!;
	public int AccessTokenExpiryTimeInMin { get; init; }
	public int RefreshTokenExpiryTimeInMin { get; init; }
}