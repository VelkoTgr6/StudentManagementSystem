using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        private Teacher[] initialTeachers = new Teacher[]
        {
            new Teacher(){Id = 1,
                Titles="prof. dr. ",
                FirstName="Stanimir",
                LastName="Grigorov",
                ContactDetails="for more info visit ...",
                Email = "stan12@gmail.com",
                UserId = "1"
            },
            new Teacher(){Id = 2,
                Titles="doc. ",
                FirstName="Ivan",
                LastName="Draganov",
                ContactDetails="gsm:12345678655",
                Email = "ivdra23@gmailcom",
                UserId = "2"
            }
        };

        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(initialTeachers);
        }
    }
}
