using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        private Class[] initialClasses = new Class[]
           {
            new Class() { Id = 1, Name = "10b", TeacherId = 21 },
            new Class() { Id = 2, Name = "9a", TeacherId = 22 },
            new Class() { Id = 3, Name = "11c", TeacherId = 23 },
            new Class() { Id = 4, Name = "12a", TeacherId = 24 },
            new Class() { Id = 5, Name = "8b", TeacherId = 25 },
            new Class() { Id = 6, Name = "7a", TeacherId = 26 },
            new Class() { Id = 7, Name = "6c", TeacherId = 27 },
            new Class() { Id = 8, Name = "10a", TeacherId = 28 },
            new Class() { Id = 9, Name = "9b", TeacherId = 29 },
            new Class() { Id = 10, Name = "11a", TeacherId = 30 }
           };

        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.HasData(initialClasses);
        }
    }
}

