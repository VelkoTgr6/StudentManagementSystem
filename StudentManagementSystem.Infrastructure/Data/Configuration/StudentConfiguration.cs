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
                  SchoolId = 1,
                  PersonalId = "9564039305",
                  FirstName = "Ivan",
                  MiddleName = "Grigorov",
                  LastName = "Petrov",
                  DateOfBirth = DateTime.Now.AddYears(-18),
                  ContactDetails = "GSM:882163890",
                  Email = "ivan414@gmail.com",
                  UserId = "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c",
                  ClassId = 3
    },    new         Student() {
                  Id = 2,
                  SchoolId = 1,
                  PersonalId = "6934567210",
                  FirstName = "Maria",
                  MiddleName = "Georgiev",
                  LastName = "Grigorov",
                  DateOfBirth = DateTime.Now.AddYears(-17),
                  ContactDetails = "GSM:889556992",
                  Email = "maria270@gmail.com",
                  UserId = "f2875100-0cf1-4b1d-ba91-1dfa38690f84",
                  ClassId = 5
    },    new         Student() {
                  Id = 3,
                  SchoolId = 1,
                  PersonalId = "3699302616",
                  FirstName = "Elena",
                  MiddleName = "Grigorov",
                  LastName = "Todorov",
                  DateOfBirth = DateTime.Now.AddYears(-17),
                  ContactDetails = "GSM:883854732",
                  Email = "elena309@gmail.com",
                  UserId = "b65e6163-1454-4164-9869-2ff822f9da98",
                  ClassId = 5
    },    new         Student() {
                  Id = 4,
                  SchoolId = 1,
                  PersonalId = "2940063663",
                  FirstName = "Viktor",
                  MiddleName = "Todorov",
                  LastName = "Todorov",
                  DateOfBirth = DateTime.Now.AddYears(-18),
                  ContactDetails = "GSM:886992374",
                  Email = "viktor725@gmail.com",
                  UserId = "c5d7d80f-08d5-41ec-892c-30833098c047",
                  ClassId = 4
    },    new         Student() {
                  Id = 5,
                  SchoolId = 1,
                  PersonalId = "4204190914",
                  FirstName = "Pesho",
                  MiddleName = "Nikolov",
                  LastName = "Nikolov",
                  DateOfBirth = DateTime.Now.AddYears(-16),
                  ContactDetails = "GSM:884738222",
                  Email = "pesho278@gmail.com",
                  UserId = "217e3e65-026d-4a8e-97af-a4fb30dfab30",
                  ClassId = 2
    },    new         Student() {
                  Id = 6,
                  SchoolId = 1,
                  PersonalId = "5392831842",
                  FirstName = "Nina",
                  MiddleName = "Borisova",
                  LastName = "Todorova",
                  DateOfBirth = DateTime.Now.AddYears(-19),
                  ContactDetails = "GSM:888183734",
                  Email = "nina.borisova@gmail.com",
                  UserId = "8f7bca8f-059f-4750-8bfe-7def13ef37e8",
                  ClassId = 1
    },    new         Student() {
                  Id = 7,
                  SchoolId = 1,
                  PersonalId = "6758374932",
                  FirstName = "Ivo",
                  MiddleName = "Petrov",
                  LastName = "Pavlov",
                  DateOfBirth = DateTime.Now.AddYears(-20),
                  ContactDetails = "GSM:883764543",
                  Email = "ivo.pavlov@gmail.com",
                  UserId = "1a688e82-f609-47af-a359-d8bcdd62b5e9",
                  ClassId = 1
    },    new         Student() {
                  Id = 8,
                  SchoolId = 1,
                  PersonalId = "8293840598",
                  FirstName = "Katerina",
                  MiddleName = "Alexandrova",
                  LastName = "Gancheva",
                  DateOfBirth = DateTime.Now.AddYears(-21),
                  ContactDetails = "GSM:882847361",
                  Email = "katerina.gancheva@gmail.com",
                  UserId = "01185cf1-525d-478a-ad05-b9629573333a",
                  ClassId = 3
    },    new         Student() {
                  Id = 9,
                  SchoolId = 1,
                  PersonalId = "9382843621",
                  FirstName = "Dimitar",
                  MiddleName = "Georgiev",
                  LastName = "Mihailov",
                  DateOfBirth = DateTime.Now.AddYears(-22),
                  ContactDetails = "GSM:887654321",
                  Email = "dimitar.mihailov@gmail.com",
                  UserId = "cab3584a-da3f-4858-a65a-3f7bde9e553f",
                  ClassId = 4
    },    new         Student() {
                  Id = 10,
                  SchoolId = 1,
                  PersonalId = "4902385726",
                  FirstName = "Stefan",
                  MiddleName = "Ivanov",
                  LastName = "Yordanov",
                  DateOfBirth = DateTime.Now.AddYears(-23),
                  ContactDetails = "GSM:885676543",
                  Email = "stefan.yordanov@gmail.com",
                  UserId = "325092c7-9882-40d9-854b-32326c2bd43b",
                  ClassId = 5
    },    new         Student() {
                  Id = 11,
                  SchoolId = 1,
                  PersonalId = "2945641207",
                  FirstName = "Diana",
                  MiddleName = "Stoyanova",
                  LastName = "Ruseva",
                  DateOfBirth = DateTime.Now.AddYears(-20),
                  ContactDetails = "GSM:882364788",
                  Email = "diana.ruseva@gmail.com",
                  UserId = "2e830c43-2ce2-462d-9880-be8aa1e71696",
                  ClassId = 2
    },    new         Student() {
                  Id = 12,
                  SchoolId = 1,
                  PersonalId = "1298345761",
                  FirstName = "Petar",
                  MiddleName = "Zahariev",
                  LastName = "Georgiev",
                  DateOfBirth = DateTime.Now.AddYears(-21),
                  ContactDetails = "GSM:889276400",
                  Email = "petar.georgiev@gmail.com",
                  UserId = "c64af0f1-3716-4e30-b5f7-b0c5153e2b01",
                  ClassId = 3
    },    new         Student() {
                  Id = 13,
                  SchoolId = 1,
                  PersonalId = "8471629304",
                  FirstName = "Tanya",
                  MiddleName = "Vasileva",
                  LastName = "Ivanova",
                  DateOfBirth = DateTime.Now.AddYears(-19),
                  ContactDetails = "GSM:883712508",
                  Email = "tanya.ivanova@gmail.com",
                  UserId = "ab696b9f-f5d2-45a0-8495-96e2d2a01acc",
                  ClassId = 4
    },    new         Student() {
                  Id = 14,
                  SchoolId = 1,
                  PersonalId = "6503849201",
                  FirstName = "Aleksandar",
                  MiddleName = "Dimitrov",
                  LastName = "Pavlov",
                  DateOfBirth = DateTime.Now.AddYears(-18),
                  ContactDetails = "GSM:887327015",
                  Email = "aleksandar.pavlov@gmail.com",
                  UserId = "8eb86d7d-02f7-477d-8e6f-539d7c155930",
                  ClassId = 2
    },    new         Student() {
                  Id = 15,
                  SchoolId = 1,
                  PersonalId = "8473926140",
                  FirstName = "Julia",
                  MiddleName = "Borisova",
                  LastName = "Dimitrova",
                  DateOfBirth = DateTime.Now.AddYears(-20),
                  ContactDetails = "GSM:888014697",
                  Email = "julia.dimitrova@gmail.com",
                  UserId = "3034c6c5-e1f5-4655-9baf-079f41605550",
                  ClassId = 5
    },    new         Student() {
                  Id = 16,
                  SchoolId = 1,
                  PersonalId = "5392837362",
                  FirstName = "Kiril",
                  MiddleName = "Vasilev",
                  LastName = "Kolarov",
                  DateOfBirth = DateTime.Now.AddYears(-18),
                  ContactDetails = "GSM:884728672",
                  Email = "kiril.kolarov@gmail.com",
                  UserId = "e8264a26-ea76-44c4-a013-12759599a081",
                  ClassId = 1
    },    new         Student() {
                  Id = 17,
                  SchoolId = 1,
                  PersonalId = "8282020193",
                  FirstName = "Daniela",
                  MiddleName = "Dimitrova",
                  LastName = "Todorova",
                  DateOfBirth = DateTime.Now.AddYears(-22),
                  ContactDetails = "GSM:889253738",
                  Email = "daniela.todorova@gmail.com",
                  UserId = "e0e396e6-53f2-40e9-8013-664b8a8dbd46",
                  ClassId = 3
    },    new         Student() {
                  Id = 18,
                  SchoolId = 1,
                  PersonalId = "9273628105",
                  FirstName = "Lazar",
                  MiddleName = "Nikolov",
                  LastName = "Grigorov",
                  DateOfBirth = DateTime.Now.AddYears(-21),
                  ContactDetails = "GSM:888107316",
                  Email = "lazar.grigorov@gmail.com",
                  UserId = "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf",
                  ClassId = 4
    },    new         Student() {
                  Id = 19,
                  SchoolId = 1,
                  PersonalId = "3846204951",
                  FirstName = "Ivanka",
                  MiddleName = "Georgieva",
                  LastName = "Nikolova",
                  DateOfBirth = DateTime.Now.AddYears(-16),
                  ContactDetails = "GSM:887726051",
                  Email = "ivanka.nikolova@gmail.com",
                  UserId = "0c4b8988-22f2-4ed5-8486-85e757a97e41",
                  ClassId = 2
    },    new         Student() {
                  Id = 20,
                  SchoolId = 1,
                  PersonalId = "1294956172",
                  FirstName = "Gergana",
                  MiddleName = "Todorova",
                  LastName = "Georgieva",
                  DateOfBirth = DateTime.Now.AddYears(-19),
                  ContactDetails = "GSM:883467150",
                  Email = "gergana.georgieva@gmail.com",
                  UserId = "3a76fd9d-a1bb-48f2-9626-1122ecf2d797",
                  ClassId = 5
                  }
    };



        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(initialStudents);
        }
    }
}
