using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        private Teacher[] initialTeachers = new Teacher[]
        {
            new Teacher(){ Id = 21, Titles = "prof. dr. ",SchoolId = 1, FirstName = "Stanimir", LastName = "Grigorov", ContactDetails = "for more info visit ...", Email = "stan12@gmail.com", UserId = "21" },
            new Teacher(){ Id = 22, Titles = "doc. ",SchoolId = 1, FirstName = "Ivan", LastName = "Draganov", ContactDetails = "gsm:12345678655", Email = "ivdra23@gmail.com", UserId = "22" },
            new Teacher(){ Id = 23, Titles = "assoc. prof. ",SchoolId = 1, FirstName = "Mariya", LastName = "Petrova", ContactDetails = "gsm:0987654321", Email = "mariya.petrova@gmail.com", UserId = "23" },
            new Teacher(){ Id = 24, Titles = "prof. dr. ",SchoolId = 1, FirstName = "Nikolai", LastName = "Vasilev", ContactDetails = "email: nikolai@university.com", Email = "nikolai.vasilev@gmail.com", UserId = "24" },
            new Teacher(){ Id = 25, Titles = "lect. ",SchoolId = 1, FirstName = "Radoslav", LastName = "Ivanov", ContactDetails = "for inquiries, email me", Email = "radoslav.ivanov@gmail.com", UserId = "25" },
            new Teacher(){ Id = 26, Titles = "assoc. prof. ",SchoolId = 1, FirstName = "Katerina", LastName = "Dimitrova", ContactDetails = "gsm:0551237894", Email = "katerina.dimitrova@gmail.com", UserId = "26" },
            new Teacher(){ Id = 27, Titles = "lect. ",SchoolId = 1, FirstName = "Petar", LastName = "Georgiev", ContactDetails = "gsm:0876543210", Email = "petar.georgiev@gmail.com", UserId = "27" },
            new Teacher(){ Id = 28, Titles = "prof. ",SchoolId = 1, FirstName = "Lidia", LastName = "Todorova", ContactDetails = "email: lidia@faculty.com", Email = "lidia.todorova@gmail.com", UserId = "28" },
            new Teacher(){ Id = 29, Titles = "doc. ",SchoolId = 1, FirstName = "Stefan", LastName = "Kovachev", ContactDetails = "gsm:022112233", Email = "stefan.kovachev@gmail.com", UserId = "29" },
            new Teacher(){ Id = 30, Titles = "prof. dr. ",SchoolId = 1, FirstName = "Valentina", LastName = "Nikolova", ContactDetails = "email: valentina.nikolova@edu.com", Email = "valentina.nikolova@gmail.com", UserId = "30" }
        };

        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(initialTeachers);
        }
    }
}
