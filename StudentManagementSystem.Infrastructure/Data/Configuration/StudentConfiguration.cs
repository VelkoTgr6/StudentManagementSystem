using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;
using System.Runtime.Intrinsics.X86;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        private Student[] initialStudents = new Student[]
        {
            new Student(){
                Id = 1,
                PersonalId = "0230456078",
                FirstName = "Gosho",
                MiddleName = "Petrov",
                LastName = "Grigorov",
                DateOfBirth = DateTime.Now.AddYears(-20), // Example date of birth
                ContactDetails = "GSM:0881237865",
                Email = "gosho123@gmail.com",
                UserId = "1" // This must match the Id of the user seeded above
            },
            new Student() {
                Id = 2,
                PersonalId = "0140656070",
                FirstName = "Pesho",
                MiddleName = "Petrov",
                LastName = "Ivanov",
                DateOfBirth = DateTime.Now.AddYears(-22), // Example date of birth
                ContactDetails = "GSM:0881237865",
                Email = "pesho321@gmail.com",
                UserId = "2" // This must match the Id of the user seeded above
            }
        };
       

        
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(initialStudents);
        }
    }
}
