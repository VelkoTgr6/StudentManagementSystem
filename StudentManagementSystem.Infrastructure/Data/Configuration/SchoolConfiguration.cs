using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        private School[] initialSchools = new School[]
        {
            new School(){ Id = 1, Name = "School of Mathematics" },
            new School(){ Id = 2, Name = "School of Physics" },
            new School(){ Id = 3, Name = "School of Chemistry" },
            new School(){ Id = 4, Name = "School of Biology" },
            new School(){ Id = 5, Name = "School of Computer Science" },
            new School(){ Id = 6, Name = "School of Economics" },
            new School(){ Id = 7, Name = "School of Law" },
            new School(){ Id = 8, Name = "School of Medicine" },
            new School(){ Id = 9, Name = "School of Philosophy" },
            new School(){ Id = 10, Name = "School of History" }
        };

        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasData(initialSchools);
        }
    }
}
