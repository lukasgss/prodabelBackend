using Application.Common.Interfaces.Entities.CollectionPoints;
using Application.Common.Interfaces.Entities.Companies;
using Application.Common.Interfaces.Entities.ContactMessages;
using Application.Common.Interfaces.Entities.Users;
using Infrastructure.Persistence.DataContext;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddScoped<IUserRepository, UserRepository>();
		services.AddScoped<ICompanyRepository, CompanyRepository>();
		services.AddScoped<ICollectionPointRepository, CollectionPointRepository>();
		services.AddScoped<IContactMessageRepository, ContactMessageRepository>();

		services.AddDbContext<AppDbContext>(options =>
			options.UseNpgsql(configuration.GetConnectionString("DefaultConnection") ?? string.Empty));

		return services;
	}
}