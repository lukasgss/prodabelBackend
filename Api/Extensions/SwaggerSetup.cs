using Microsoft.OpenApi.Models;

namespace Api.Extensions;

public static class SwaggerSetup
{
	public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
	{
		services.AddEndpointsApiExplorer();

		services.AddSwaggerGen(c =>
		{
			c.SwaggerDoc("v1", new OpenApiInfo()
			{
				Title = "Recicla Tech BH",
				Version = "v1"
			});
			c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
			c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
			{
				Name = "Authorization",
				Type = SecuritySchemeType.Http,
				Scheme = "Bearer",
				BearerFormat = "JWT",
				In = ParameterLocation.Header,
				Description = "JWT Authorization header using the Bearer scheme."
			});

			c.AddSecurityRequirement(new OpenApiSecurityRequirement()
			{
				{
					new OpenApiSecurityScheme()
					{
						Reference = new OpenApiReference()
						{
							Type = ReferenceType.SecurityScheme,
							Id = "Bearer"
						}
					},
					Array.Empty<string>()
				}
			});
		});

		return services;
	}
}