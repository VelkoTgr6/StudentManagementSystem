using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        private Course[] initialClasses = new Course[]
           {
            new Course(){Id = 1,Name="Biology",Description="Best bilogy learning system in the world",TeacherId = 1,PublisherId = "1" },
            new Course(){Id = 2,Name="History",Description="Best History learning system in the world",TeacherId = 2,PublisherId = "1"}
           };

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(initialClasses);
        }
    }
}
