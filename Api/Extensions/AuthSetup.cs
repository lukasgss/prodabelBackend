using System.Text;
using Application.Common.Interfaces.Authentication;
using Domain.Entities;
using Infrastructure.Persistence.DataContext;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Api.Extensions;

public static class AuthSetup
{
	public static IServiceCollection ConfigureAuth(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddIdentity<User, IdentityRole<int>>(options =>
			{
				options.Password.RequireDigit = false;
				options.Password.RequireLowercase = false;
				options.Password.RequireUppercase = false;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequiredLength = 6;
				options.User.RequireUniqueEmail = true;
				options.SignIn.RequireConfirmedEmail = false;
			}).AddEntityFrameworkStores<AppDbContext>()
			.AddDefaultTokenProviders();

		IConfigurationSection configJwt = configuration.GetSection(JwtConfig.SectionName);

		services.AddAuthentication(opt =>
			{
				opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				string secret = configJwt["SecretKey"]!;

				options.TokenValidationParameters = new TokenValidationParameters()
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = configJwt["Issuer"],
					ValidAudience = configJwt["Audience"],
					IssuerSigningKey = new SymmetricSecurityKey(
						Encoding.UTF8.GetBytes(secret)
					)
				};
			});

		services.Configure<JwtConfig>(configJwt);

		return services;
	}
}