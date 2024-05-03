using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.Common.Interfaces.Authentication;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Application.Services.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
	private readonly JwtConfig _jwtConfig;

	public JwtTokenGenerator(IOptions<JwtConfig> jwtConfig)
	{
		_jwtConfig = jwtConfig.Value ?? throw new ArgumentNullException(nameof(jwtConfig));
	}

	public string GenerateJwtToken(int userId, string fullName)
	{
		IEnumerable<Claim> accessTokenClaims = GenerateTokenClaims(userId, fullName);
		DateTime accessTokenExpiration = DateTime.Now
			.AddMinutes(_jwtConfig.AccessTokenExpiryTimeInMin);

		return GenerateToken(accessTokenClaims, accessTokenExpiration);
	}

	private static IEnumerable<Claim> GenerateTokenClaims(int userId, string fullName)
	{
		return
		[
			new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
			new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
			new Claim(JwtRegisteredClaimNames.Name, fullName)
		];
	}

	private string GenerateToken(IEnumerable<Claim> claims, DateTime expirationDate)
	{
		SigningCredentials signingCredentials = new(
			new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.SecretKey)),
			SecurityAlgorithms.HmacSha256);

		JwtSecurityToken jwtSecurityToken = new(
			issuer: _jwtConfig.Issuer,
			audience: _jwtConfig.Audience,
			claims: claims,
			expires: expirationDate,
			signingCredentials: signingCredentials);

		return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
	}
}