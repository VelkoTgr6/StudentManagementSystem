using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    PersonalId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "Personal ID is a unique identifier for each person."),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Teacher Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titles = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Teacher Titles"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Teacher First Name"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Teacher Last Name"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if teacher is Deleted"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Student Email Address"),
                    ProfilePicturePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Path to the profile picture of the student"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User Identifier"),
                    ContactDetails = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Teacher Contact Details")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "The name of the class"),
                    TeacherId = table.Column<int>(type: "int", nullable: false, comment: "The ID of the teacher for this class"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if class is Deleted")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Course Name"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Course Description"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if course is Deleted"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Course Start Date"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Course End Date"),
                    EnrollmentCap = table.Column<int>(type: "int", nullable: false, comment: "Maximum number of students allowed"),
                    TeacherId = table.Column<int>(type: "int", nullable: false, comment: "Teacher of the Course"),
                    PublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Publisher Identification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Student Personal Identification Number"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Student First Name"),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Student Middle Name"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Student Last Name"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Student Email Address"),
                    Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "Remarks about the student"),
                    Аbsence = table.Column<double>(type: "float", nullable: false, comment: "Shows if student is Active"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of birth of Student"),
                    ContactDetails = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Student Contact Details"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if student is Deleted"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User Identifier"),
                    ClassId = table.Column<int>(type: "int", nullable: false, comment: "Class Identifier"),
                    ProfilePicturePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Path to the profile picture of the student"),
                    Performance = table.Column<double>(type: "float", nullable: false, comment: "Student Performance")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassCourses",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false, comment: "Class Identifier"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier"),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of enrollment")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCourses", x => new { x.ClassId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_ClassCourses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique Identifier for the Grade entry")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the Course"),
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the Student"),
                    GradeScore = table.Column<double>(type: "float", nullable: false, comment: "Grade received by the student for a specific course assessment"),
                    GradeAssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date when the grade was assigned"),
                    GradeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Description or type of the grade (e.g., Midterm, Final, Homework)"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if grade is Deleted")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "465d045d-e248-4ea4-aa28-dbbcc505721a", "IdentityUser", "ivan414@gmail.com", true, false, null, "IVAN414@GMAIL.COM", "IVAN414@GMAIL.COM", "AQAAAAIAAYagAAAAELHrSX0sxbLPJg3ET2UUyzG2CSYwnL3v9Y8BS80ZECZ5D6btYd2H3DaZiNKmPn5Deg==", null, false, "673fb029-0c84-451f-a6d2-f3eb9b7c763a", false, "ivan414@gmail.com" },
                    { "10", 0, "22420630-799f-4346-814c-315e23fa5baa", "IdentityUser", "stefan.yordanov@gmail.com", true, false, null, "STEFAN.YORDANOV@GMAIL.COM", "STEFAN.YORDANOV@GMAIL.COM", "AQAAAAIAAYagAAAAEB37JrzMRrfZO+WWpujpHEx0TmvLKNrssdYMRJYik0kTkzqVubpUlnWDPQ86qF/ogw==", null, false, "f80b343c-bed2-4bb4-8396-866da19e9926", false, "stefan.yordanov@gmail.com" },
                    { "11", 0, "30ba4375-e977-451e-80fb-a885b258a26d", "IdentityUser", "diana.ruseva@gmail.com", true, false, null, "DIANA.RUSEVA@GMAIL.COM", "DIANA.RUSEVA@GMAIL.COM", "AQAAAAIAAYagAAAAEPTXRX+5VNOoa27Zhi48q7nyVcelxRoec0vvUgWxVD9zj4xJjxLH0LN0fHzqhm0olQ==", null, false, "17bc388a-d85c-4604-ba81-7088a09f6fa5", false, "diana.ruseva@gmail.com" },
                    { "12", 0, "b2cc22b5-6319-4f5f-829e-7e978b80f0fe", "IdentityUser", "petar.georgiev@gmail.com", true, false, null, "PETAR.GEORGIEV@GMAIL.COM", "PETAR.GEORGIEV@GMAIL.COM", "AQAAAAIAAYagAAAAEOdX7j+eQ/+7rqG8OQMrg9mTCrShgwiNedxtL82vAGIy54McaBCoVC8JqSEj+d1amA==", null, false, "7915a03b-5cf1-4ff9-a4e2-42bdeb14a2b5", false, "petar.georgiev@gmail.com" },
                    { "13", 0, "71bbf25e-549c-4d19-b1bf-6a11394a62e8", "IdentityUser", "tanya.ivanova@gmail.com", true, false, null, "TANYA.IVANOVA@GMAIL.COM", "TANYA.IVANOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEBzijO3mkfli5Gp7tb8fVMiCxrd4zWglvRmF4vzhYTLpfqA98RJmD8a9RXPm5JtPKg==", null, false, "b98977af-140d-4406-9b7b-e462ac3999f2", false, "tanya.ivanova@gmail.com" },
                    { "14", 0, "e36e497d-d3f1-48dd-87e4-981672c833b6", "IdentityUser", "aleksandar.pavlov@gmail.com", true, false, null, "ALEKSANDAR.PAVLOV@GMAIL.COM", "ALEKSANDAR.PAVLOV@GMAIL.COM", "AQAAAAIAAYagAAAAEAlrf1/tZ5OCnxHEKTJ5Neo3yg1NaCH+9RwBuLiUMdran/nzhO4mV63IvOv7QU3qZQ==", null, false, "21ccadb4-39e8-454c-b967-1f1105987357", false, "aleksandar.pavlov@gmail.com" },
                    { "15", 0, "6017bb07-50df-40cb-a491-659d77763d06", "IdentityUser", "julia.dimitrova@gmail.com", true, false, null, "JULIA.DIMITROVA@GMAIL.COM", "JULIA.DIMITROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEBW47z5qjNuqXua3mxj46YiC0w3GoqhyjYnOG+dnEI2mWwrIMTdEjYtpoEO70XwsEg==", null, false, "f572cb2a-7c0e-49cc-a29f-432c4fc7d8ee", false, "julia.dimitrova@gmail.com" },
                    { "16", 0, "b25ec2d7-c0c6-4820-b296-8926071087e7", "IdentityUser", "kiril.kolarov@gmail.com", true, false, null, "KIRIL.KOLAROV@GMAIL.COM", "KIRIL.KOLAROV@GMAIL.COM", "AQAAAAIAAYagAAAAEKm4rMPCyBl9/xeVSPqyExAet6dBNnkGnAVp7ul1Le1NTOM8IgF9tFg9EVYyabXJvg==", null, false, "5cb3bf82-4436-4be6-afe3-c3638a3fa652", false, "kiril.kolarov@gmail.com" },
                    { "17", 0, "d64e3cbd-0faa-4d13-9f81-bcd5add4834a", "IdentityUser", "daniela.todorova@gmail.com", true, false, null, "DANIELA.TODOROVA@GMAIL.COM", "DANIELA.TODOROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEBvNWWYRO1JhI/CQASd7gGxz55njySH4iS4fHD9YHJhkl/eJBEDoI1QXQDrtkplbwQ==", null, false, "3d7d5b88-d022-4479-8902-edc9eb2175b7", false, "daniela.todorova@gmail.com" },
                    { "18", 0, "069d615b-e4e8-402f-98f7-7ebbac2a1592", "IdentityUser", "lazar.grigorov@gmail.com", true, false, null, "LAZAR.GRIGOROV@GMAIL.COM", "LAZAR.GRIGOROV@GMAIL.COM", "AQAAAAIAAYagAAAAEO0Qcm9OTjiX+yQrx1eGtsjBooAwZviYtu2+7p6/zGAX4ziIBmqyPRd1Ulou9fC38Q==", null, false, "b50f4043-6705-4101-b829-a24e76dfe73a", false, "lazar.grigorov@gmail.com" },
                    { "19", 0, "d0dfda5d-27ee-4609-a816-cccc47ecfab7", "IdentityUser", "ivanka.nikolova@gmail.com", true, false, null, "IVANKA.NIKOLOVA@GMAIL.COM", "IVANKA.NIKOLOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEO+Tk6Gc2nJJyP9ue6170o0Jekw3dDeYc8x5J3wdIvORuj1MOVJyXy5RPJ3sUWnp4w==", null, false, "9599a599-9b5a-4b39-b1fb-94f094ede191", false, "ivanka.nikolova@gmail.com" },
                    { "2", 0, "0815301a-6b72-49df-9379-0d08acbc549e", "IdentityUser", "maria270@gmail.com", true, false, null, "MARIA270@GMAIL.COM", "MARIA270@GMAIL.COM", "AQAAAAIAAYagAAAAEG8aTGmiSZU53u1h9XZ63UK9YLJiATaNT76UhInHTkgFWYqkFyGzysfjooTa/UfntA==", null, false, "c8ccc63c-8c85-464f-a15e-d47429a66058", false, "maria270@gmail.com" },
                    { "20", 0, "e2bef8f2-9033-4e0a-ba47-75a1d6645fc7", "IdentityUser", "gergana.georgieva@gmail.com", true, false, null, "GERGANA.GEORGIEVA@GMAIL.COM", "GERGANA.GEORGIEVA@GMAIL.COM", "AQAAAAIAAYagAAAAEO4Q27INihRqaphnIZO+ABUWclvWU0OhiVGqgZilorB3y6ZKvaH4joZfloFZIdlIfA==", null, false, "6265a54d-c3ac-4389-b469-8bf4770b6a7a", false, "gergana.georgieva@gmail.com" },
                    { "21", 0, "4a39e8fd-5650-4dd8-ac79-1cd0dfe0803f", "IdentityUser", "stan12@gmail.com", true, false, null, "STAN12@GMAIL.COM", "STAN12@GMAIL.COM", "AQAAAAIAAYagAAAAENuTUXe4SxEhur+AEADLskC8B/HWWza1/MxPhPyEQ8y2o57eDeXueczDTzXE2/tHmg==", null, false, "", false, "stan12@gmail.com" },
                    { "22", 0, "55ea6fec-c087-4beb-be3f-585120e88c12", "IdentityUser", "ivdra23@gmail.com", true, false, null, "IVDRA23@GMAIL.COM", "IVDRA23@GMAIL.COM", "AQAAAAIAAYagAAAAEI+wdLqE1lgUYkCMJ59lI8B9GJfhij1CxpFdmJHRiup9UoOObEBG/isQBC9O0/U9pw==", null, false, "", false, "ivdra23@gmail.com" },
                    { "23", 0, "8c93797a-5208-4395-899f-1cd0459fe897", "IdentityUser", "mariya.petrova@gmail.com", true, false, null, "MARIYA.PETROVA@GMAIL.COM", "MARIYA.PETROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEDQzMa8z2uTl02ce7aV5ZecHtN5WcacqCVJz8v0X0LhqFLKJGM4nPkOAFqpiQ26TBA==", null, false, "", false, "mariya.petrova@gmail.com" },
                    { "24", 0, "71164e91-c0af-4621-ba30-6d43919b2bb3", "IdentityUser", "nikolai.vasilev@gmail.com", true, false, null, "NIKOLAI.VASILEV@GMAIL.COM", "NIKOLAI.VASILEV@GMAIL.COM", "AQAAAAIAAYagAAAAEKsg6bdPKZvSTbat9S8kCbCEg4SWzkRY9IScvg81iptHmFrc4YG2IV5doyKveXG/Tg==", null, false, "", false, "nikolai.vasilev@gmail.com" },
                    { "25", 0, "413d704e-32fd-4c39-809b-f67bd477bb4a", "IdentityUser", "radoslav.ivanov@gmail.com", true, false, null, "RADOSLAV.IVANOV@GMAIL.COM", "RADOSLAV.IVANOV@GMAIL.COM", "AQAAAAIAAYagAAAAEPzlsNBnSKhgxdYKar5lfZUqxJBNDjeTLoxNin69Do1aFYzYhqyVHYWWU0QsdnwWKw==", null, false, "", false, "radoslav.ivanov@gmail.com" },
                    { "26", 0, "8b03beef-7747-4a9c-86ed-e355142f1925", "IdentityUser", "katerina.dimitrova@gmail.com", true, false, null, "KATERINA.DIMITROVA@GMAIL.COM", "KATERINA.DIMITROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEGMpUC3FdIYedxazctIq3Py81GtrapPOkEamp3iQak6EjvvNdn/rBTf81R01BxYE8w==", null, false, "", false, "katerina.dimitrova@gmail.com" },
                    { "27", 0, "e1d51a57-248f-4e2d-8992-0c62334d4e17", "IdentityUser", "gosho.georgiev@gmail.com", true, false, null, "GOSHO.GEORGIEV@GMAIL.COM", "GOSHO.GEORGIEV@GMAIL.COM", "AQAAAAIAAYagAAAAEPLb72xKAiJCnsj03EhEn/2VTkeHt7/0B/LCrnUirGnCYFQJruVhxYJ5WZL/4g01SA==", null, false, "", false, "gosho.georgiev@gmail.com" },
                    { "28", 0, "af6623d6-5fcf-492d-b252-ce3eae7af050", "IdentityUser", "lidia.todorova@gmail.com", true, false, null, "LIDIA.TODOROVA@GMAIL.COM", "LIDIA.TODOROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEKzYCbhHVCLcDIrzozwXGlI2ksYF8FxixEV8tWYBPi8MeMwG9rpr49Pp1vU8ZUHGMg==", null, false, "", false, "lidia.todorova@gmail.com" },
                    { "29", 0, "cfcac21d-013e-4c12-835f-6396c5abc9d0", "IdentityUser", "stefan.kovachev@gmail.com", true, false, null, "STEFAN.KOVACHEV@GMAIL.COM", "STEFAN.KOVACHEV@GMAIL.COM", "AQAAAAIAAYagAAAAEIujUMT8rdeMXUKk6Bjt2DIR76I/rXmqdjipPDFBS4K8t1JRA+zBWthRwX03Nx4ynA==", null, false, "", false, "stefan.kovachev@gmail.com" },
                    { "3", 0, "d52d0e24-c1a7-47d7-b422-9313003dcbd4", "IdentityUser", "elena309@gmail.com", true, false, null, "ELENA309@GMAIL.COM", "ELENA309@GMAIL.COM", "AQAAAAIAAYagAAAAENvy5eOymlsv3yFpu/ACWOYgxuB/qWMMT8SVkWLDmje4RaqI6Up7Z7Sbb09MQHt7Nw==", null, false, "71bb5d7f-6098-4f17-a052-78e3a8b04c28", false, "elena309@gmail.com" },
                    { "30", 0, "8d8e61cf-1459-4bfb-908e-ac31e7ac4ce7", "IdentityUser", "valentina.nikolova@gmail.com", true, false, null, "VALENTINA.NIKOLOVA@GMAIL.COM", "VALENTINA.NIKOLOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEEKhQ5Hyeq7aMT3+/S+1Q+2jxdliUxMackI2ykcNdRRZpv8fhfojjyYlELSmokWRvA==", null, false, "", false, "valentina.nikolova@gmail.com" },
                    { "4", 0, "e9c878c3-2e03-4efc-b74d-6699692c8dff", "IdentityUser", "viktor725@gmail.com", true, false, null, "VIKTOR725@GMAIL.COM", "VIKTOR725@GMAIL.COM", "AQAAAAIAAYagAAAAEK4JctkzDhgNaj3KWt/nucv/J6ADbC4q6pW8dbBpv+ubNHSWl9UtphjdrE+CFT90RQ==", null, false, "4fe92041-94ff-4357-ab01-767aed3fee90", false, "viktor725@gmail.com" },
                    { "5", 0, "32febbf0-d79c-449d-87e7-7eb314921463", "IdentityUser", "pesho278@gmail.com", true, false, null, "PESHO278@GMAIL.COM", "PESHO278@GMAIL.COM", "AQAAAAIAAYagAAAAEBTARElucHXvam7vRe7Jyrm8EimudugByciN8HdxpVrdu04mo9s3V0FjEf/QKJw6gQ==", null, false, "f8037f41-dde9-49e3-afd2-b9c8e03ca73a", false, "pesho278@gmail.com" },
                    { "6", 0, "fc0a6d8c-5d1e-4ec7-b166-526f52dee6c0", "IdentityUser", "nina.borisova@gmail.com", true, false, null, "NINA.BORISOVA@GMAIL.COM", "NINA.BORISOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEA9ynP4I3DDU50e8nGvWMeGyflPqA/OSf1oUcTgpGqFT03jTid7yiSUvP/7mzZBvCg==", null, false, "4206df03-6ba5-47b6-8c00-fa7ddf2bd5bf", false, "nina.borisova@gmail.com" },
                    { "7", 0, "6f1a048c-ded0-4a6e-8526-3b1002695e2d", "IdentityUser", "ivo.pavlov@gmail.com", true, false, null, "IVO.PAVLOV@GMAIL.COM", "IVO.PAVLOV@GMAIL.COM", "AQAAAAIAAYagAAAAEEtreY3DH5quxHoVbelifVj7VBtLZhcLDmvDc9FoiC1zD5miW3687lK/d/JTt03mJA==", null, false, "f45af3bb-fddf-4eea-87ee-5c03680e54b5", false, "ivo.pavlov@gmail.com" },
                    { "8", 0, "9904ad01-e303-4952-a815-5c73d2420a8f", "IdentityUser", "katerina.gancheva@gmail.com", true, false, null, "KATERINA.GANCHEVA@GMAIL.COM", "KATERINA.GANCHEVA@GMAIL.COM", "AQAAAAIAAYagAAAAEMMMPJtJIVk5QWI0mjy4OX/LQVtpwH+RSyz8bmk9ljuvjUsXGJB/JDvti+SEC+crew==", null, false, "7987a3b9-c605-4686-9211-6c2ea9b7e855", false, "katerina.gancheva@gmail.com" },
                    { "9", 0, "ca7308d1-fd7f-4fa2-8cba-0a0f2baa0438", "IdentityUser", "dimitar.mihailov@gmail.com", true, false, null, "DIMITAR.MIHAILOV@GMAIL.COM", "DIMITAR.MIHAILOV@GMAIL.COM", "AQAAAAIAAYagAAAAEAg8BEFeC/uArHDmKHe1/Kgbhx5BGKEQ5QW5yXVqaBw5WQnQVFjZScXfDI2TeaoSyA==", null, false, "739bd31a-1669-469f-908e-565fdee18cb7", false, "dimitar.mihailov@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ContactDetails", "Email", "FirstName", "IsDeleted", "LastName", "ProfilePicturePath", "Titles", "UserId" },
                values: new object[,]
                {
                    { 21, "for more info visit ...", "stan12@gmail.com", "Stanimir", false, "Grigorov", "images/profiles/default.png", "prof. dr. ", "21" },
                    { 22, "gsm:12345678655", "ivdra23@gmail.com", "Ivan", false, "Draganov", "images/profiles/default.png", "doc. ", "22" },
                    { 23, "gsm:0987654321", "mariya.petrova@gmail.com", "Mariya", false, "Petrova", "images/profiles/default.png", "assoc. prof. ", "23" },
                    { 24, "email: nikolai@university.com", "nikolai.vasilev@gmail.com", "Nikolai", false, "Vasilev", "images/profiles/default.png", "prof. dr. ", "24" },
                    { 25, "for inquiries, email me", "radoslav.ivanov@gmail.com", "Radoslav", false, "Ivanov", "images/profiles/default.png", "lect. ", "25" },
                    { 26, "gsm:0551237894", "katerina.dimitrova@gmail.com", "Katerina", false, "Dimitrova", "images/profiles/default.png", "assoc. prof. ", "26" },
                    { 27, "gsm:0876543210", "petar.georgiev@gmail.com", "Petar", false, "Georgiev", "images/profiles/default.png", "lect. ", "27" },
                    { 28, "email: lidia@faculty.com", "lidia.todorova@gmail.com", "Lidia", false, "Todorova", "images/profiles/default.png", "prof. ", "28" },
                    { 29, "gsm:022112233", "stefan.kovachev@gmail.com", "Stefan", false, "Kovachev", "images/profiles/default.png", "doc. ", "29" },
                    { 30, "email: valentina.nikolova@edu.com", "valentina.nikolova@gmail.com", "Valentina", false, "Nikolova", "images/profiles/default.png", "prof. dr. ", "30" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "IsDeleted", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, false, "10b", 21 },
                    { 2, false, "9a", 22 },
                    { 3, false, "11c", 23 },
                    { 4, false, "12a", 24 },
                    { 5, false, "8b", 25 },
                    { 6, false, "7a", 26 },
                    { 7, false, "6c", 27 },
                    { 8, false, "10a", 28 },
                    { 9, false, "9b", 29 },
                    { 10, false, "11a", 30 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "EndDate", "EnrollmentCap", "IsDeleted", "Name", "PublisherId", "StartDate", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Best biology learning system in the world", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Biology", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 2, "Best history learning system in the world", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "History", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 3, "Comprehensive mathematics curriculum for all levels", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mathematics", "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 4, "Advanced physics concepts and practical applications", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Physics", "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 5, "Exploring the fundamentals of chemistry", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Chemistry", "3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 6, "In-depth analysis of classic and modern literature", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "English Literature", "3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 7, "Programming, algorithms, and computing fundamentals", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Computer Science", "4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 8, "Understanding economic systems, theories, and policies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Economics", "4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 9, "Exploring the earth's physical features and human geography", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Geography", "5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 10, "The study of art movements, artists, and their works", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Art History", "5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "ContactDetails", "DateOfBirth", "Email", "FirstName", "IsDeleted", "LastName", "MiddleName", "Performance", "PersonalId", "ProfilePicturePath", "Remark", "UserId", "Аbsence" },
                values: new object[,]
                {
                    { 1, 3, "GSM:882163890", new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1669), "ivan414@gmail.com", "Ivan", false, "Petrov", "Grigorov", 0.0, "9564039305", "images/profiles/default.png", null, "1", 0.0 },
                    { 2, 5, "GSM:889556992", new DateTime(2007, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1775), "maria270@gmail.com", "Maria", false, "Grigorov", "Georgiev", 0.0, "6934567210", "images/profiles/default.png", null, "2", 0.0 },
                    { 3, 5, "GSM:883854732", new DateTime(2007, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1779), "elena309@gmail.com", "Elena", false, "Todorov", "Grigorov", 0.0, "3699302616", "images/profiles/default.png", null, "3", 0.0 },
                    { 4, 4, "GSM:886992374", new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1783), "viktor725@gmail.com", "Viktor", false, "Todorov", "Todorov", 0.0, "2940063663", "images/profiles/default.png", null, "4", 0.0 },
                    { 5, 2, "GSM:884738222", new DateTime(2008, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1786), "pesho278@gmail.com", "Pesho", false, "Nikolov", "Nikolov", 0.0, "4204190914", "images/profiles/default.png", null, "5", 0.0 },
                    { 6, 1, "GSM:888183734", new DateTime(2005, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1791), "nina.borisova@gmail.com", "Nina", false, "Todorova", "Borisova", 0.0, "5392831842", "images/profiles/default.png", null, "6", 0.0 },
                    { 7, 1, "GSM:883764543", new DateTime(2004, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1807), "ivo.pavlov@gmail.com", "Ivo", false, "Pavlov", "Petrov", 0.0, "6758374932", "images/profiles/default.png", null, "7", 0.0 },
                    { 8, 3, "GSM:882847361", new DateTime(2003, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1812), "katerina.gancheva@gmail.com", "Katerina", false, "Gancheva", "Alexandrova", 0.0, "8293840598", "images/profiles/default.png", null, "8", 0.0 },
                    { 9, 4, "GSM:887654321", new DateTime(2002, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1823), "dimitar.mihailov@gmail.com", "Dimitar", false, "Mihailov", "Georgiev", 0.0, "9382843621", "images/profiles/default.png", null, "9", 0.0 },
                    { 10, 5, "GSM:885676543", new DateTime(2001, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1827), "stefan.yordanov@gmail.com", "Stefan", false, "Yordanov", "Ivanov", 0.0, "4902385726", "images/profiles/default.png", null, "10", 0.0 },
                    { 11, 2, "GSM:882364788", new DateTime(2004, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1835), "diana.ruseva@gmail.com", "Diana", false, "Ruseva", "Stoyanova", 0.0, "2945641207", "images/profiles/default.png", null, "11", 0.0 },
                    { 12, 3, "GSM:889276400", new DateTime(2003, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1839), "petar.georgiev@gmail.com", "Petar", false, "Georgiev", "Zahariev", 0.0, "1298345761", "images/profiles/default.png", null, "12", 0.0 },
                    { 13, 4, "GSM:883712508", new DateTime(2005, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1842), "tanya.ivanova@gmail.com", "Tanya", false, "Ivanova", "Vasileva", 0.0, "8471629304", "images/profiles/default.png", null, "13", 0.0 },
                    { 14, 2, "GSM:887327015", new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1846), "aleksandar.pavlov@gmail.com", "Aleksandar", false, "Pavlov", "Dimitrov", 0.0, "6503849201", "images/profiles/default.png", null, "14", 0.0 },
                    { 15, 5, "GSM:888014697", new DateTime(2004, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1850), "julia.dimitrova@gmail.com", "Julia", false, "Dimitrova", "Borisova", 0.0, "8473926140", "images/profiles/default.png", null, "15", 0.0 },
                    { 16, 1, "GSM:884728672", new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1869), "kiril.kolarov@gmail.com", "Kiril", false, "Kolarov", "Vasilev", 0.0, "5392837362", "images/profiles/default.png", null, "16", 0.0 },
                    { 17, 3, "GSM:889253738", new DateTime(2002, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1873), "daniela.todorova@gmail.com", "Daniela", false, "Todorova", "Dimitrova", 0.0, "8282020193", "images/profiles/default.png", null, "17", 0.0 },
                    { 18, 4, "GSM:888107316", new DateTime(2003, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1876), "lazar.grigorov@gmail.com", "Lazar", false, "Grigorov", "Nikolov", 0.0, "9273628105", "images/profiles/default.png", null, "18", 0.0 },
                    { 19, 2, "GSM:887726051", new DateTime(2008, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1880), "ivanka.nikolova@gmail.com", "Ivanka", false, "Nikolova", "Georgieva", 0.0, "3846204951", "images/profiles/default.png", null, "19", 0.0 },
                    { 20, 5, "GSM:883467150", new DateTime(2005, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1884), "gergana.georgieva@gmail.com", "Gergana", false, "Georgieva", "Todorova", 0.0, "1294956172", "images/profiles/default.png", null, "20", 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourses_CourseId",
                table: "ClassCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherId",
                table: "Classes",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_PublisherId",
                table: "Courses",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_CourseId",
                table: "Grades",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClassCourses");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
