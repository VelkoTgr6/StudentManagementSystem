using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private IdentityRole [] initialRoles = new IdentityRole[]
        {
            new IdentityRole () {Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
            new IdentityRole {Id = "2", Name = "Teacher", NormalizedName = "TEACHER" },
            new IdentityRole {Id = "3", Name = "Student", NormalizedName = "STUDENT" }
        };
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[0].Id,
                UserId = "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[1].Id,
                UserId = "51065229-23b9-402f-a54d-00bb813d6b1c"
            });
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = initialRoles[2].Id,
                UserId = "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c"
            });
        }
    }
}
