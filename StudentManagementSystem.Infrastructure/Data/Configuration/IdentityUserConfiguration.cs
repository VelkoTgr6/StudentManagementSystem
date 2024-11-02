using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Runtime.Intrinsics.X86;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        private IdentityUser[] initialUsers = new IdentityUser[]
        {
            new IdentityUser()
            {
            Id = "1", // Unique identifier for user
            UserName = "gosho123@gmail.com",
            NormalizedUserName = "GOSHO123@GMAIL.COM",
            Email = "gosho123@gmail.com",
            NormalizedEmail = "GOSHO123@GMAIL.COM",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!") // Password hash
            },

            new IdentityUser()
            {
            Id = "2", // Unique identifier for user
            UserName = "pesho321@gmail.com",
            NormalizedUserName = "PESHO321@GMAIL.COM",
            Email = "pesho321@gmail.com",
            NormalizedEmail = "PESHO321@GMAIL.COM",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Password1!") // Password hash
            }
        };

        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(initialUsers);
        }
    }
}
