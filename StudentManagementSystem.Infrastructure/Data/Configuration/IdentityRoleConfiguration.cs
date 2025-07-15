using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole<string>>
    {
        private IdentityRole<string>[] initialRoles = new IdentityRole<string>[]
        {
            new IdentityRole<string> { Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
            new IdentityRole<string> { Id = "2", Name = "Teacher", NormalizedName = "TEACHER" },
            new IdentityRole<string> { Id = "3", Name = "Student", NormalizedName = "STUDENT" }
        };

        public void Configure(EntityTypeBuilder<IdentityRole<string>> builder)
        {
            builder.HasData(initialRoles);
        }
    }
}
