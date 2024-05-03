using Application.Common.Interfaces.Entities.Users;
using Domain.Entities;
using Infrastructure.Persistence.DataContext;
using Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddScoped<IUserRepository, UserRepository>();

		services.AddDbContext<AppDbContext>(options =>
			options.UseNpgsql(configuration.GetConnectionString("DefaultConnection") ?? string.Empty));

		return services;
	}
}