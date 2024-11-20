using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Infrastructure.Data.Models;

namespace StudentManagementSystem.Infrastructure.Data.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        private Student[] initialStudents = new Student[]
        {
            new Student(){
                  Id = 1,
                  PersonalId = "9564039305",
                  FirstName = "Ivan",
                  MiddleName = "Grigorov",
                  LastName = "Petrov",
                  DateOfBirth = DateTime.Now.AddYears(-18),
                  ContactDetails = "GSM:882163890",
                  Email = "ivan414@gmail.com",
                  UserId = "1",
                  ClassId = 3
    },    new         Student() {
                  Id = 2,
                  PersonalId = "6934567210",
                  FirstName = "Maria",
                  MiddleName = "Georgiev",
                  LastName = "Grigorov",
                  DateOfBirth = DateTime.Now.AddYears(-17),
                  ContactDetails = "GSM:889556992",
                  Email = "maria270@gmail.com",
                  UserId = "2",
                  ClassId = 5
    },    new         Student() {
                  Id = 3,
                  PersonalId = "3699302616",
                  FirstName = "Elena",
                  MiddleName = "Grigorov",
                  LastName = "Todorov",
                  DateOfBirth = DateTime.Now.AddYears(-17),
                  ContactDetails = "GSM:883854732",
                  Email = "elena309@gmail.com",
                  UserId = "3",
                  ClassId = 5
    },    new         Student() {
                  Id = 4,
                  PersonalId = "2940063663",
                  FirstName = "Viktor",
                  MiddleName = "Todorov",
                  LastName = "Todorov",
                  DateOfBirth = DateTime.Now.AddYears(-18),
                  ContactDetails = "GSM:886992374",
                  Email = "viktor725@gmail.com",
                  UserId = "4",
                  ClassId = 4
    },    new         Student() {
                  Id = 5,
                  PersonalId = "4204190914",
                  FirstName = "Pesho",
                  MiddleName = "Nikolov",
                  LastName = "Nikolov",
                  DateOfBirth = DateTime.Now.AddYears(-16),
                  ContactDetails = "GSM:884738222",
                  Email = "pesho278@gmail.com",
                  UserId = "5",
                  ClassId = 2
    },    new         Student() {
                  Id = 6,
                  PersonalId = "5392831842",
                  FirstName = "Nina",
                  MiddleName = "Borisova",
                  LastName = "Todorova",
                  DateOfBirth = DateTime.Now.AddYears(-19),
                  ContactDetails = "GSM:888183734",
                  Email = "nina.borisova@gmail.com",
                  UserId = "6",
                  ClassId = 1
    },    new         Student() {
                  Id = 7,
                  PersonalId = "6758374932",
                  FirstName = "Ivo",
                  MiddleName = "Petrov",
                  LastName = "Pavlov",
                  DateOfBirth = DateTime.Now.AddYears(-20),
                  ContactDetails = "GSM:883764543",
                  Email = "ivo.pavlov@gmail.com",
                  UserId = "7",
                  ClassId = 1
    },    new         Student() {
                  Id = 8,
                  PersonalId = "8293840598",
                  FirstName = "Katerina",
                  MiddleName = "Alexandrova",
                  LastName = "Gancheva",
                  DateOfBirth = DateTime.Now.AddYears(-21),
                  ContactDetails = "GSM:882847361",
                  Email = "katerina.gancheva@gmail.com",
                  UserId = "8",
                  ClassId = 3
    },    new         Student() {
                  Id = 9,
                  PersonalId = "9382843621",
                  FirstName = "Dimitar",
                  MiddleName = "Georgiev",
                  LastName = "Mihailov",
                  DateOfBirth = DateTime.Now.AddYears(-22),
                  ContactDetails = "GSM:887654321",
                  Email = "dimitar.mihailov@gmail.com",
                  UserId = "9",
                  ClassId = 4
    },    new         Student() {
                  Id = 10,
                  PersonalId = "4902385726",
                  FirstName = "Stefan",
                  MiddleName = "Ivanov",
                  LastName = "Yordanov",
                  DateOfBirth = DateTime.Now.AddYears(-23),
                  ContactDetails = "GSM:885676543",
                  Email = "stefan.yordanov@gmail.com",
                  UserId = "10",
                  ClassId = 5
    },    new         Student() {
                  Id = 11,
                  PersonalId = "2945641207",
                  FirstName = "Diana",
                  MiddleName = "Stoyanova",
                  LastName = "Ruseva",
                  DateOfBirth = DateTime.Now.AddYears(-20),
                  ContactDetails = "GSM:882364788",
                  Email = "diana.ruseva@gmail.com",
                  UserId = "11",
                  ClassId = 2
    },    new         Student() {
                  Id = 12,
                  PersonalId = "1298345761",
                  FirstName = "Petar",
                  MiddleName = "Zahariev",
                  LastName = "Georgiev",
                  DateOfBirth = DateTime.Now.AddYears(-21),
                  ContactDetails = "GSM:889276400",
                  Email = "petar.georgiev@gmail.com",
                  UserId = "12",
                  ClassId = 3
    },    new         Student() {
                  Id = 13,
                  PersonalId = "8471629304",
                  FirstName = "Tanya",
                  MiddleName = "Vasileva",
                  LastName = "Ivanova",
                  DateOfBirth = DateTime.Now.AddYears(-19),
                  ContactDetails = "GSM:883712508",
                  Email = "tanya.ivanova@gmail.com",
                  UserId = "13",
                  ClassId = 4
    },    new         Student() {
                  Id = 14,
                  PersonalId = "6503849201",
                  FirstName = "Aleksandar",
                  MiddleName = "Dimitrov",
                  LastName = "Pavlov",
                  DateOfBirth = DateTime.Now.AddYears(-18),
                  ContactDetails = "GSM:887327015",
                  Email = "aleksandar.pavlov@gmail.com",
                  UserId = "14",
                  ClassId = 2
    },    new         Student() {
                  Id = 15,
                  PersonalId = "8473926140",
                  FirstName = "Julia",
                  MiddleName = "Borisova",
                  LastName = "Dimitrova",
                  DateOfBirth = DateTime.Now.AddYears(-20),
                  ContactDetails = "GSM:888014697",
                  Email = "julia.dimitrova@gmail.com",
                  UserId = "15",
                  ClassId = 5
    },    new         Student() {
                  Id = 16,
                  PersonalId = "5392837362",
                  FirstName = "Kiril",
                  MiddleName = "Vasilev",
                  LastName = "Kolarov",
                  DateOfBirth = DateTime.Now.AddYears(-18),
                  ContactDetails = "GSM:884728672",
                  Email = "kiril.kolarov@gmail.com",
                  UserId = "16",
                  ClassId = 1
    },    new         Student() {
                  Id = 17,
                  PersonalId = "8282020193",
                  FirstName = "Daniela",
                  MiddleName = "Dimitrova",
                  LastName = "Todorova",
                  DateOfBirth = DateTime.Now.AddYears(-22),
                  ContactDetails = "GSM:889253738",
                  Email = "daniela.todorova@gmail.com",
                  UserId = "17",
                  ClassId = 3
    },    new         Student() {
                  Id = 18,
                  PersonalId = "9273628105",
                  FirstName = "Lazar",
                  MiddleName = "Nikolov",
                  LastName = "Grigorov",
                  DateOfBirth = DateTime.Now.AddYears(-21),
                  ContactDetails = "GSM:888107316",
                  Email = "lazar.grigorov@gmail.com",
                  UserId = "18",
                  ClassId = 4
    },    new         Student() {
                  Id = 19,
                  PersonalId = "3846204951",
                  FirstName = "Ivanka",
                  MiddleName = "Georgieva",
                  LastName = "Nikolova",
                  DateOfBirth = DateTime.Now.AddYears(-16),
                  ContactDetails = "GSM:887726051",
                  Email = "ivanka.nikolova@gmail.com",
                  UserId = "19",
                  ClassId = 2
    },    new         Student() {
                  Id = 20,
                  PersonalId = "1294956172",
                  FirstName = "Gergana",
                  MiddleName = "Todorova",
                  LastName = "Georgieva",
                  DateOfBirth = DateTime.Now.AddYears(-19),
                  ContactDetails = "GSM:883467150",
                  Email = "gergana.georgieva@gmail.com",
                  UserId = "20",
                  ClassId = 5
                  }
    };



        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(initialStudents);
        }
    }
}
