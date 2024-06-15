using Domain.Entities;

namespace Infrastructure.Persistence.DataSeed;

public static class SeedUser
{
    public static User Seed()
    {
        return new User()
        {
            Id = 1,
            Email = "prodabel@admin.com.br",
            UserName = "prodabel@admin.com.br",
            EmailConfirmed = true,
            FullName = "Admin Prodabel",
            PasswordHash = "AQAAAAIAAYagAAAAEH+PeNU4e7TL3lgqrF533vighX86xqwBdJaMiTbDneNLvMerHdFmxc2YocfVrRjfng=="
        };
    }
}