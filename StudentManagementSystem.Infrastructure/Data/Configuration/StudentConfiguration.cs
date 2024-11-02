using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        private Student[] initialStudents = new Student[]
        {
            new Student(){Id=1,FirstName="Gosho",MiddleName="Petrov",LastName="Grigorov",
            DateOfBirth=DateTime.Now,ContactDetails="GSM:0881237865"},
            new Student(){Id=2,FirstName="Pesho",MiddleName="Petrov",LastName="Ivanov",
            DateOfBirth=DateTime.Now,ContactDetails="GSM:0881237865"}
        };

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(initialStudents);
        }
    }
}
