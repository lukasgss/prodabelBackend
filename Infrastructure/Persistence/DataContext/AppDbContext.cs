using Domain.Entities;
using Infrastructure.Persistence.DataSeed;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.DataContext;

public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
	public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
	{
	}

	public DbSet<Company> Companies { get; set; } = null!;
	public DbSet<CollectionPoint> CollectionPoints { get; set; } = null!;
    
	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);

		builder.Entity<User>().HasData(SeedUser.Seed());
	}
}