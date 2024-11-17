using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        private Class[] initialClasses = new Class[]
           {
            new Class(){Id = 1,Name="10b",TeacherId = 1},
            new Class(){Id = 2,Name="9a",TeacherId = 2}
           };

        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.HasData(initialClasses);
        }
    }
}

