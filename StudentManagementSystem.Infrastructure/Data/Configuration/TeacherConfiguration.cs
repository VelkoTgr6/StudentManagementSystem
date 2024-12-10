using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        private Teacher[] initialTeachers = new Teacher[]
        {
            new Teacher(){ Id = 21, Titles = "prof. dr. ",SchoolId = 1, FirstName = "Stanimir", LastName = "Grigorov", ContactDetails = "for more info visit ...", Email = "stan12@gmail.com", UserId = "51065229-23b9-402f-a54d-00bb813d6b1c" },
            new Teacher(){ Id = 22, Titles = "doc. ",SchoolId = 1, FirstName = "Ivan", LastName = "Draganov", ContactDetails = "gsm:12345678655", Email = "ivdra23@gmail.com", UserId = "6b6433a7-3564-4cba-ace2-4a44afca4177" },
            new Teacher(){ Id = 23, Titles = "assoc. prof. ",SchoolId = 1, FirstName = "Mariya", LastName = "Petrova", ContactDetails = "gsm:0987654321", Email = "mariya.petrova@gmail.com", UserId = "331d08d0-d407-4d61-af6e-1bb134ae7998" },
            new Teacher(){ Id = 24, Titles = "prof. dr. ",SchoolId = 1, FirstName = "Nikolai", LastName = "Vasilev", ContactDetails = "email: nikolai@university.com", Email = "nikolai.vasilev@gmail.com", UserId = "030ddabd-7dcb-46ca-bab6-3feeae3492a8" },
            new Teacher(){ Id = 25, Titles = "lect. ",SchoolId = 1, FirstName = "Radoslav", LastName = "Ivanov", ContactDetails = "for inquiries, email me", Email = "radoslav.ivanov@gmail.com", UserId = "291cc1a8-8f2c-4f48-a919-ff4d9692a859" },
            new Teacher(){ Id = 26, Titles = "assoc. prof. ",SchoolId = 1, FirstName = "Katerina", LastName = "Dimitrova", ContactDetails = "gsm:0551237894", Email = "katerina.dimitrova@gmail.com", UserId = "32739a60-8250-4178-a19c-96d90444ebd3" },
            new Teacher(){ Id = 27, Titles = "lect. ",SchoolId = 1, FirstName = "Petar", LastName = "Georgiev", ContactDetails = "gsm:0876543210", Email = "petar.georgiev@gmail.com", UserId = "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729" },
            new Teacher(){ Id = 28, Titles = "prof. ",SchoolId = 1, FirstName = "Lidia", LastName = "Todorova", ContactDetails = "email: lidia@faculty.com", Email = "lidia.todorova@gmail.com", UserId = "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45" },
            new Teacher(){ Id = 29, Titles = "doc. ",SchoolId = 1, FirstName = "Stefan", LastName = "Kovachev", ContactDetails = "gsm:022112233", Email = "stefan.kovachev@gmail.com", UserId = "04b6c6b1-5f9b-4c7a-9f42-86193c03d327" },
            new Teacher(){ Id = 30, Titles = "prof. dr. ",SchoolId = 1, FirstName = "Valentina", LastName = "Nikolova", ContactDetails = "email: valentina.nikolova@edu.com", Email = "valentina.nikolova@gmail.com", UserId = "9ab8c775-88c0-4dc3-b11d-178c3ca2129" }
        };

        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(initialTeachers);
        }
    }
}
