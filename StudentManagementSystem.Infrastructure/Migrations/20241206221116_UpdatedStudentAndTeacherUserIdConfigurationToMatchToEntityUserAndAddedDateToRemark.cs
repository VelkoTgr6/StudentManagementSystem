using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedStudentAndTeacherUserIdConfigurationToMatchToEntityUserAndAddedDateToRemark : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "First name of the user."),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Last name of the user."),
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
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "School Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "School Name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
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
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "News Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "News Title"),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "News Content"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "News Date"),
                    PublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Publisher Identifier"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if news is Deleted")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_AspNetUsers_PublisherId",
                        column: x => x.PublisherId,
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
                    SchoolId = table.Column<int>(type: "int", nullable: false, comment: "School Identifier"),
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
                    table.ForeignKey(
                        name: "FK_Teachers_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
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
                    TeacherId = table.Column<int>(type: "int", nullable: true, comment: "Teacher of the Course"),
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
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolId = table.Column<int>(type: "int", nullable: false, comment: "School Identifier"),
                    PersonalId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Student Personal Identification Number"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Student First Name"),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Student Middle Name"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Student Last Name"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Student Email Address"),
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
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Absences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Absence Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if absence is Deleted"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of Absence")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Absences_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Absences_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Remarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Remark Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RemarkText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Remark Text"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if remark is Deleted"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the remark"),
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier"),
                    TeacherId = table.Column<int>(type: "int", nullable: false, comment: "Teacher Identifier"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remarks_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Remarks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Remarks_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01185cf1-525d-478a-ad05-b9629573333a", 0, "18e10bf4-2903-48fb-bf3b-b20b07a9f0ff", "IdentityUser", "katerina.gancheva@gmail.com", true, false, null, "KATERINA.GANCHEVA@GMAIL.COM", "KATERINA.GANCHEVA@GMAIL.COM", "AQAAAAIAAYagAAAAEIVEVLs9jtxodtCOetKpjpg2qf1bX3EvBjOdYpNySwXOxcmDJsPz0upAYnEdLdRjxw==", null, false, "ca40bcc6-c108-4e1c-95a9-aa9d4da1b8ad", false, "katerina.gancheva@gmail.com" },
                    { "030ddabd-7dcb-46ca-bab6-3feeae3492a8", 0, "c146ae7b-5854-409f-93dd-6d9f4312b78f", "IdentityUser", "nikolai.vasilev@gmail.com", true, false, null, "NIKOLAI.VASILEV@GMAIL.COM", "NIKOLAI.VASILEV@GMAIL.COM", "AQAAAAIAAYagAAAAEBVtuMBulRrNO8Q4mttGcbJoUxvACfRka1qwZ/jYq+yYSiEXlEFNBQqoB7Z2MyF7BQ==", null, false, "", false, "nikolai.vasilev@gmail.com" },
                    { "04b6c6b1-5f9b-4c7a-9f42-86193c03d327", 0, "21ce1668-e41e-4755-8e72-335246e14008", "IdentityUser", "stefan.kovachev@gmail.com", true, false, null, "STEFAN.KOVACHEV@GMAIL.COM", "STEFAN.KOVACHEV@GMAIL.COM", "AQAAAAIAAYagAAAAEPK5H7qGL9aGBJJGEbKLE7QKtgJJQERRJJqAJa1kmr6Vy9UzjrtzJ0crqL5QbEgQLA==", null, false, "", false, "stefan.kovachev@gmail.com" },
                    { "0c4b8988-22f2-4ed5-8486-85e757a97e41", 0, "8258b9d3-9fa5-45bc-a902-38561e253f90", "IdentityUser", "ivanka.nikolova@gmail.com", true, false, null, "IVANKA.NIKOLOVA@GMAIL.COM", "IVANKA.NIKOLOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEJMpSn3Ae3mDLss7BEKs2XAuA8uOn5KYV0GUtkZW6zf0F1f1bgmbYCNBos+kUimkDg==", null, false, "ca7a7574-c3f7-42a0-bdd9-e4dada7355aa", false, "ivanka.nikolova@gmail.com" },
                    { "1a688e82-f609-47af-a359-d8bcdd62b5e9", 0, "23dc6944-d135-4716-bba0-378c3b5a3986", "IdentityUser", "ivo.pavlov@gmail.com", true, false, null, "IVO.PAVLOV@GMAIL.COM", "IVO.PAVLOV@GMAIL.COM", "AQAAAAIAAYagAAAAEM5Y6TC3GRGyluzrQMqy9O44fso4Qyvt8xyXQOcsA1fIpHRvDmP10TZm9TMcuTMOCg==", null, false, "1ba63c74-363e-4bba-b637-25d0117bfdd9", false, "ivo.pavlov@gmail.com" },
                    { "217e3e65-026d-4a8e-97af-a4fb30dfab30", 0, "57538733-9d42-4a23-80a9-9f79738c66ff", "IdentityUser", "pesho278@gmail.com", true, false, null, "PESHO278@GMAIL.COM", "PESHO278@GMAIL.COM", "AQAAAAIAAYagAAAAEBjEvPYpeuvbSHy0vDkvl7XujHpPU1iyBo7pw8Xc+1Czci2L/zJNueLCwzp2RsnEOA==", null, false, "c777ddc7-0ee9-4bb4-b220-b846508edd1f", false, "pesho278@gmail.com" },
                    { "291cc1a8-8f2c-4f48-a919-ff4d9692a859", 0, "7b2d2bcb-c8c0-4357-a137-92ee18df498d", "IdentityUser", "radoslav.ivanov@gmail.com", true, false, null, "RADOSLAV.IVANOV@GMAIL.COM", "RADOSLAV.IVANOV@GMAIL.COM", "AQAAAAIAAYagAAAAEBpagpXCTcBjDlnzOSU3qroBef/6xEEydtb8l5UyDay5vsKWzxTBxIFzU5ZSg2ZkqQ==", null, false, "", false, "radoslav.ivanov@gmail.com" },
                    { "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45", 0, "03a1eb22-4739-4532-a2c3-e1b633785c6a", "IdentityUser", "lidia.todorova@gmail.com", true, false, null, "LIDIA.TODOROVA@GMAIL.COM", "LIDIA.TODOROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEOPqLjTyai5Ib1ykWldRr++0Ju1ZLrReLphUuBHZ/p0dBZGrTGHjihEwxudsmYzGzA==", null, false, "", false, "lidia.todorova@gmail.com" },
                    { "2e830c43-2ce2-462d-9880-be8aa1e71696", 0, "147055f0-ec4b-4bd2-af25-a4fa7f903a6d", "IdentityUser", "diana.ruseva@gmail.com", true, false, null, "DIANA.RUSEVA@GMAIL.COM", "DIANA.RUSEVA@GMAIL.COM", "AQAAAAIAAYagAAAAEH90cW3a74b6ozXZB0EBxTqMpTL+V5RhLz0uL2LhKp4nJZeuHjTt/YwYtdhoFZOBuA==", null, false, "8f1bc6d1-4ed6-49fa-9535-7d14aeed8fdd", false, "diana.ruseva@gmail.com" },
                    { "3034c6c5-e1f5-4655-9baf-079f41605550", 0, "975e8422-37da-4f40-9df3-008592754f8c", "IdentityUser", "julia.dimitrova@gmail.com", true, false, null, "JULIA.DIMITROVA@GMAIL.COM", "JULIA.DIMITROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEE+qK7nb6eYgWWHV31hJ8VfWbfSXigRKxKS5H5gyaKRdDdNXO1ldivRSBtCo8T9T0A==", null, false, "d2220536-d1f1-4b47-8a0b-0929d49cbe8b", false, "julia.dimitrova@gmail.com" },
                    { "325092c7-9882-40d9-854b-32326c2bd43b", 0, "ca4cea5b-c748-4fe5-bdc1-87774de9d5f4", "IdentityUser", "stefan.yordanov@gmail.com", true, false, null, "STEFAN.YORDANOV@GMAIL.COM", "STEFAN.YORDANOV@GMAIL.COM", "AQAAAAIAAYagAAAAEN5A4DhvMjqNkj7gN07rSozkYdHMAp8JGbO9nPg2bfFSjF/t8I84WAkUnW4ynNiVGg==", null, false, "ad27bd21-c809-44ee-a877-c4aa3ae7d45e", false, "stefan.yordanov@gmail.com" },
                    { "32739a60-8250-4178-a19c-96d90444ebd3", 0, "d2c04772-f6c2-4188-b699-6af66854cad4", "IdentityUser", "katerina.dimitrova@gmail.com", true, false, null, "KATERINA.DIMITROVA@GMAIL.COM", "KATERINA.DIMITROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEJXkiXy2b88+hrXXnBTOtiXW+nIdMKqxl7WsLgVg9YGYGyRBxoab6ckA0NeGccg5Bg==", null, false, "", false, "katerina.dimitrova@gmail.com" },
                    { "331d08d0-d407-4d61-af6e-1bb134ae7998", 0, "f066c8db-ff0a-487e-9c31-3c8ba200c0c0", "IdentityUser", "mariya.petrova@gmail.com", true, false, null, "MARIYA.PETROVA@GMAIL.COM", "MARIYA.PETROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEOi8O8XveFggqxKfJ6Yh4XxPWeFONSzGZEocDF9CwrDgTVIRK1GOtKKk+IRG5ixFhg==", null, false, "", false, "mariya.petrova@gmail.com" },
                    { "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729", 0, "a093b88d-b511-4d34-9217-1d7ab51883d9", "IdentityUser", "gosho.georgiev@gmail.com", true, false, null, "GOSHO.GEORGIEV@GMAIL.COM", "GOSHO.GEORGIEV@GMAIL.COM", "AQAAAAIAAYagAAAAEM5WG82OQyWdxPoLPS0UKCrQurBU0uuQriv+ab+Ug7BNTc8+8LQCuAjWkTT77rv6jA==", null, false, "", false, "gosho.georgiev@gmail.com" },
                    { "3a76fd9d-a1bb-48f2-9626-1122ecf2d797", 0, "ed855d3e-dd3d-4af2-bf3d-afa797b3c988", "IdentityUser", "gergana.georgieva@gmail.com", true, false, null, "GERGANA.GEORGIEVA@GMAIL.COM", "GERGANA.GEORGIEVA@GMAIL.COM", "AQAAAAIAAYagAAAAELtH677YqCYDs/FhhA5SHkrp4RbLQsLkuPwdpZAWBYp0P2V0EEmNTfiq9bO4VX8LFQ==", null, false, "db36e8a4-c906-4b53-8a99-931042879caa", false, "gergana.georgieva@gmail.com" },
                    { "51065229-23b9-402f-a54d-00bb813d6b1c", 0, "b099ae8a-1b4c-45e5-a20d-36f43a54abff", "IdentityUser", "stan12@gmail.com", true, false, null, "STAN12@GMAIL.COM", "STAN12@GMAIL.COM", "AQAAAAIAAYagAAAAEBMv5Wo/nluycNn90nEilbgWyPOFHcITm1TSQNgU13C89pp0zi/UcWOmSR+tvvT4Ww==", null, false, "", false, "stan12@gmail.com" },
                    { "6b6433a7-3564-4cba-ace2-4a44afca4177", 0, "5153322f-c92c-4e7e-baf0-ba11a71c0064", "IdentityUser", "ivdra23@gmail.com", true, false, null, "IVDRA23@GMAIL.COM", "IVDRA23@GMAIL.COM", "AQAAAAIAAYagAAAAEGojZpKdlYxqKy5pzLiNvHwTYJHBnH6EoAvRQg9Jy/TqhHsqiY2FOSxb0qlwNYGO9Q==", null, false, "", false, "ivdra23@gmail.com" },
                    { "8eb86d7d-02f7-477d-8e6f-539d7c155930", 0, "4d7a8725-5706-4496-90a7-bd5a9117460c", "IdentityUser", "aleksandar.pavlov@gmail.com", true, false, null, "ALEKSANDAR.PAVLOV@GMAIL.COM", "ALEKSANDAR.PAVLOV@GMAIL.COM", "AQAAAAIAAYagAAAAEPMXLzdhJDOAGd1m6TLEngCozcADv2FMTa687rF5Lxl541lt5e4b7uCTpp9sCrHadA==", null, false, "c6a028c0-4aa3-45f7-8fb8-8cc95eb315b1", false, "aleksandar.pavlov@gmail.com" },
                    { "8f7bca8f-059f-4750-8bfe-7def13ef37e8", 0, "3bc6332f-8b45-4f71-b917-215975cd3226", "IdentityUser", "nina.borisova@gmail.com", true, false, null, "NINA.BORISOVA@GMAIL.COM", "NINA.BORISOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEAcC9Laiq+L1M5ZW9MBquNPnTsevAq/YONDV9g6QDKzdybjuDd+idmOZ9rn6WHC48A==", null, false, "bac408c4-f6ff-46d9-90ef-673b58b6a48c", false, "nina.borisova@gmail.com" },
                    { "9ab8c775-88c0-4dc3-b11d-178c3ca2129", 0, "e6f349f9-9bac-4eb5-9936-28aeca2c8c57", "IdentityUser", "valentina.nikolova@gmail.com", true, false, null, "VALENTINA.NIKOLOVA@GMAIL.COM", "VALENTINA.NIKOLOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEOOJbrIDvZV12gigC/tnLvRT+kcq8NfDGJXcI6eyWIcpQ193DA2vJTOuQ35OBawZ9w==", null, false, "", false, "valentina.nikolova@gmail.com" },
                    { "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c", 0, "6c9c73ca-deea-4fd7-848f-389a2cded275", "IdentityUser", "ivan414@gmail.com", true, false, null, "IVAN414@GMAIL.COM", "IVAN414@GMAIL.COM", "AQAAAAIAAYagAAAAEDLSsQb5h95pGMIAKpLKEh+HJRrpuQuQarf0/gY8Ec7NWe2YVhmKwUOsKSqeRnrlRA==", null, false, "5fbfb1ff-8247-4948-8171-abac0cba2c65", false, "ivan414@gmail.com" },
                    { "ab696b9f-f5d2-45a0-8495-96e2d2a01acc", 0, "1eca0878-186b-44e0-9c1a-b71fee724994", "IdentityUser", "tanya.ivanova@gmail.com", true, false, null, "TANYA.IVANOVA@GMAIL.COM", "TANYA.IVANOVA@GMAIL.COM", "AQAAAAIAAYagAAAAECjC4YCKH82SbMoQuCGYIsvMg6/0xSYn//fVEDHUSBZ8lAuLsgoPCskJ5QKp6pezUw==", null, false, "ac141018-9f09-4e96-8739-3b710172859c", false, "tanya.ivanova@gmail.com" },
                    { "b65e6163-1454-4164-9869-2ff822f9da98", 0, "a0ca5c7e-58de-49fd-935e-fd550162b1b7", "IdentityUser", "elena309@gmail.com", true, false, null, "ELENA309@GMAIL.COM", "ELENA309@GMAIL.COM", "AQAAAAIAAYagAAAAEMdZOB0UrZ7/woEwg0q4DVNBqwmlKDX9hc2CyScKWI0OgqQZWpyUN106rXKElsq51w==", null, false, "249b7092-01ca-4c22-b7f0-513160250b56", false, "elena309@gmail.com" },
                    { "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf", 0, "023ce682-199d-46cf-a705-2f1cba132dbe", "IdentityUser", "lazar.grigorov@gmail.com", true, false, null, "LAZAR.GRIGOROV@GMAIL.COM", "LAZAR.GRIGOROV@GMAIL.COM", "AQAAAAIAAYagAAAAEFeMMGOKnmpI2y3SgyTvf76zSdBCpIdSy/4GhBZMftzV7mRQLezObBx3q+f34ub7Xg==", null, false, "83e1289b-5346-4e68-ae68-965825ab8bc5", false, "lazar.grigorov@gmail.com" },
                    { "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", 0, "635bf612-1a20-4c9e-a9a6-cf8cffe7f6ee", "IdentityUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEDibKH0bYBxdMxEl/aZFe4sDyL83LEDytqpQI9WR7b5zU3hqkGBYmSKplt6ss3/JOQ==", null, false, "", false, "admin@admin.com" },
                    { "c5d7d80f-08d5-41ec-892c-30833098c047", 0, "084dea89-73d5-40bc-9fd6-c01ec1228f1f", "IdentityUser", "viktor725@gmail.com", true, false, null, "VIKTOR725@GMAIL.COM", "VIKTOR725@GMAIL.COM", "AQAAAAIAAYagAAAAEJPORejjBwVz+sUFGl5sOAYrxjjhkA/+aCgfDmmZjm1+5NuOh7TC18TBCbR331bb4Q==", null, false, "e1f90d09-64a1-4ca3-9ce3-1b06ad1c392a", false, "viktor725@gmail.com" },
                    { "c64af0f1-3716-4e30-b5f7-b0c5153e2b01", 0, "1889e72a-a9ca-4c86-b024-209595bed942", "IdentityUser", "petar.georgiev@gmail.com", true, false, null, "PETAR.GEORGIEV@GMAIL.COM", "PETAR.GEORGIEV@GMAIL.COM", "AQAAAAIAAYagAAAAEO095OSTCiM02BQyDnYcB9gUiN7atGaOyP47PODCG2O3Or9diJEZjJPilSAR4QeqpA==", null, false, "5cc31f0b-3657-427a-aee5-17060e15f91a", false, "petar.georgiev@gmail.com" },
                    { "cab3584a-da3f-4858-a65a-3f7bde9e553f", 0, "fb95564e-44e8-41ea-aa8a-92f0789afeff", "IdentityUser", "dimitar.mihailov@gmail.com", true, false, null, "DIMITAR.MIHAILOV@GMAIL.COM", "DIMITAR.MIHAILOV@GMAIL.COM", "AQAAAAIAAYagAAAAEDJ+FdgGtRw8CyZ56yCp/2WlizssU07cavLzjDYnlFcwLsdNS+jhVJUCl+nR5d21lA==", null, false, "03eb8f0c-421a-48d9-b4f5-c1fba125b8c2", false, "dimitar.mihailov@gmail.com" },
                    { "e0e396e6-53f2-40e9-8013-664b8a8dbd46", 0, "2b0682da-a4fa-44c9-88ba-9526a03c6a89", "IdentityUser", "daniela.todorova@gmail.com", true, false, null, "DANIELA.TODOROVA@GMAIL.COM", "DANIELA.TODOROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEPMa/QAmmtr74+qm8BfTfc8v4o6jDQZc7EBCGooqSFlODwTXcwZb7URJU3dxPWN/Tw==", null, false, "36a7fa35-250c-4bae-8c21-4a5f97bda41e", false, "daniela.todorova@gmail.com" },
                    { "e8264a26-ea76-44c4-a013-12759599a081", 0, "e80a736b-dbd9-4efc-99e3-d56367923e37", "IdentityUser", "kiril.kolarov@gmail.com", true, false, null, "KIRIL.KOLAROV@GMAIL.COM", "KIRIL.KOLAROV@GMAIL.COM", "AQAAAAIAAYagAAAAEPf6nOYCP6Oi67Bj/g0h1FWIvZlsZhCyjK2NrVN1+mg+gPgAPjCmAgsDp/ZzccPFRA==", null, false, "3063e2ff-46cf-40ce-a6d6-3675cbe2ff5b", false, "kiril.kolarov@gmail.com" },
                    { "f2875100-0cf1-4b1d-ba91-1dfa38690f84", 0, "38c81ea7-803a-488a-be3f-32d0ee6a9309", "IdentityUser", "maria270@gmail.com", true, false, null, "MARIA270@GMAIL.COM", "MARIA270@GMAIL.COM", "AQAAAAIAAYagAAAAENSiyJxS9uHM2r6QfcvpCF0EM8gzMK4ak+3COc4VO1MiFeksIRLj7EauL4zKwMOdrg==", null, false, "bd044334-f1bb-43c1-9fd0-99c2d4cb61c7", false, "maria270@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "School of Mathematics" },
                    { 2, "School of Physics" },
                    { 3, "School of Chemistry" },
                    { 4, "School of Biology" },
                    { 5, "School of Computer Science" },
                    { 6, "School of Economics" },
                    { 7, "School of Law" },
                    { 8, "School of Medicine" },
                    { 9, "School of Philosophy" },
                    { 10, "School of History" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ContactDetails", "Email", "FirstName", "IsDeleted", "LastName", "ProfilePicturePath", "SchoolId", "Titles", "UserId" },
                values: new object[,]
                {
                    { 21, "for more info visit ...", "stan12@gmail.com", "Stanimir", false, "Grigorov", "images/profiles/default.jpg", 1, "prof. dr. ", "51065229-23b9-402f-a54d-00bb813d6b1c" },
                    { 22, "gsm:12345678655", "ivdra23@gmail.com", "Ivan", false, "Draganov", "images/profiles/default.jpg", 1, "doc. ", "6b6433a7-3564-4cba-ace2-4a44afca4177" },
                    { 23, "gsm:0987654321", "mariya.petrova@gmail.com", "Mariya", false, "Petrova", "images/profiles/default.jpg", 1, "assoc. prof. ", "331d08d0-d407-4d61-af6e-1bb134ae7998" },
                    { 24, "email: nikolai@university.com", "nikolai.vasilev@gmail.com", "Nikolai", false, "Vasilev", "images/profiles/default.jpg", 1, "prof. dr. ", "030ddabd-7dcb-46ca-bab6-3feeae3492a8" },
                    { 25, "for inquiries, email me", "radoslav.ivanov@gmail.com", "Radoslav", false, "Ivanov", "images/profiles/default.jpg", 1, "lect. ", "291cc1a8-8f2c-4f48-a919-ff4d9692a859" },
                    { 26, "gsm:0551237894", "katerina.dimitrova@gmail.com", "Katerina", false, "Dimitrova", "images/profiles/default.jpg", 1, "assoc. prof. ", "32739a60-8250-4178-a19c-96d90444ebd3" },
                    { 27, "gsm:0876543210", "petar.georgiev@gmail.com", "Petar", false, "Georgiev", "images/profiles/default.jpg", 1, "lect. ", "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729" },
                    { 28, "email: lidia@faculty.com", "lidia.todorova@gmail.com", "Lidia", false, "Todorova", "images/profiles/default.jpg", 1, "prof. ", "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45" },
                    { 29, "gsm:022112233", "stefan.kovachev@gmail.com", "Stefan", false, "Kovachev", "images/profiles/default.jpg", 1, "doc. ", "04b6c6b1-5f9b-4c7a-9f42-86193c03d327" },
                    { 30, "email: valentina.nikolova@edu.com", "valentina.nikolova@gmail.com", "Valentina", false, "Nikolova", "images/profiles/default.jpg", 1, "prof. dr. ", "9ab8c775-88c0-4dc3-b11d-178c3ca2129" }
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
                    { 1, "Best biology learning system in the world", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Biology", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 2, "Best history learning system in the world", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "History", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 3, "Comprehensive mathematics curriculum for all levels", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Mathematics", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 4, "Advanced physics concepts and practical applications", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Physics", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 5, "Exploring the fundamentals of chemistry", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Chemistry", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 6, "In-depth analysis of classic and modern literature", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "English Literature", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 7, "Programming, algorithms, and computing fundamentals", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Computer Science", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 8, "Understanding economic systems, theories, and policies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Economics", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 9, "Exploring the earth's physical features and human geography", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Geography", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 10, "The study of art movements, artists, and their works", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Art History", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "ContactDetails", "DateOfBirth", "Email", "FirstName", "IsDeleted", "LastName", "MiddleName", "Performance", "PersonalId", "ProfilePicturePath", "SchoolId", "UserId" },
                values: new object[,]
                {
                    { 1, 3, "GSM:882163890", new DateTime(2006, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5598), "ivan414@gmail.com", "Ivan", false, "Petrov", "Grigorov", 0.0, "9564039305", "images/profiles/default.jpg", 1, "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c" },
                    { 2, 5, "GSM:889556992", new DateTime(2007, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5663), "maria270@gmail.com", "Maria", false, "Grigorov", "Georgiev", 0.0, "6934567210", "images/profiles/default.jpg", 1, "f2875100-0cf1-4b1d-ba91-1dfa38690f84" },
                    { 3, 5, "GSM:883854732", new DateTime(2007, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5668), "elena309@gmail.com", "Elena", false, "Todorov", "Grigorov", 0.0, "3699302616", "images/profiles/default.jpg", 1, "b65e6163-1454-4164-9869-2ff822f9da98" },
                    { 4, 4, "GSM:886992374", new DateTime(2006, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5673), "viktor725@gmail.com", "Viktor", false, "Todorov", "Todorov", 0.0, "2940063663", "images/profiles/default.jpg", 1, "c5d7d80f-08d5-41ec-892c-30833098c047" },
                    { 5, 2, "GSM:884738222", new DateTime(2008, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5677), "pesho278@gmail.com", "Pesho", false, "Nikolov", "Nikolov", 0.0, "4204190914", "images/profiles/default.jpg", 1, "217e3e65-026d-4a8e-97af-a4fb30dfab30" },
                    { 6, 1, "GSM:888183734", new DateTime(2005, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5681), "nina.borisova@gmail.com", "Nina", false, "Todorova", "Borisova", 0.0, "5392831842", "images/profiles/default.jpg", 1, "8f7bca8f-059f-4750-8bfe-7def13ef37e8" },
                    { 7, 1, "GSM:883764543", new DateTime(2004, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5697), "ivo.pavlov@gmail.com", "Ivo", false, "Pavlov", "Petrov", 0.0, "6758374932", "images/profiles/default.jpg", 1, "1a688e82-f609-47af-a359-d8bcdd62b5e9" },
                    { 8, 3, "GSM:882847361", new DateTime(2003, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5701), "katerina.gancheva@gmail.com", "Katerina", false, "Gancheva", "Alexandrova", 0.0, "8293840598", "images/profiles/default.jpg", 1, "01185cf1-525d-478a-ad05-b9629573333a" },
                    { 9, 4, "GSM:887654321", new DateTime(2002, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5708), "dimitar.mihailov@gmail.com", "Dimitar", false, "Mihailov", "Georgiev", 0.0, "9382843621", "images/profiles/default.jpg", 1, "cab3584a-da3f-4858-a65a-3f7bde9e553f" },
                    { 10, 5, "GSM:885676543", new DateTime(2001, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5712), "stefan.yordanov@gmail.com", "Stefan", false, "Yordanov", "Ivanov", 0.0, "4902385726", "images/profiles/default.jpg", 1, "325092c7-9882-40d9-854b-32326c2bd43b" },
                    { 11, 2, "GSM:882364788", new DateTime(2004, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5719), "diana.ruseva@gmail.com", "Diana", false, "Ruseva", "Stoyanova", 0.0, "2945641207", "images/profiles/default.jpg", 1, "2e830c43-2ce2-462d-9880-be8aa1e71696" },
                    { 12, 3, "GSM:889276400", new DateTime(2003, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5724), "petar.georgiev@gmail.com", "Petar", false, "Georgiev", "Zahariev", 0.0, "1298345761", "images/profiles/default.jpg", 1, "c64af0f1-3716-4e30-b5f7-b0c5153e2b01" },
                    { 13, 4, "GSM:883712508", new DateTime(2005, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5728), "tanya.ivanova@gmail.com", "Tanya", false, "Ivanova", "Vasileva", 0.0, "8471629304", "images/profiles/default.jpg", 1, "ab696b9f-f5d2-45a0-8495-96e2d2a01acc" },
                    { 14, 2, "GSM:887327015", new DateTime(2006, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5732), "aleksandar.pavlov@gmail.com", "Aleksandar", false, "Pavlov", "Dimitrov", 0.0, "6503849201", "images/profiles/default.jpg", 1, "8eb86d7d-02f7-477d-8e6f-539d7c155930" },
                    { 15, 5, "GSM:888014697", new DateTime(2004, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5736), "julia.dimitrova@gmail.com", "Julia", false, "Dimitrova", "Borisova", 0.0, "8473926140", "images/profiles/default.jpg", 1, "3034c6c5-e1f5-4655-9baf-079f41605550" },
                    { 16, 1, "GSM:884728672", new DateTime(2006, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5798), "kiril.kolarov@gmail.com", "Kiril", false, "Kolarov", "Vasilev", 0.0, "5392837362", "images/profiles/default.jpg", 1, "e8264a26-ea76-44c4-a013-12759599a081" },
                    { 17, 3, "GSM:889253738", new DateTime(2002, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5803), "daniela.todorova@gmail.com", "Daniela", false, "Todorova", "Dimitrova", 0.0, "8282020193", "images/profiles/default.jpg", 1, "e0e396e6-53f2-40e9-8013-664b8a8dbd46" },
                    { 18, 4, "GSM:888107316", new DateTime(2003, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5807), "lazar.grigorov@gmail.com", "Lazar", false, "Grigorov", "Nikolov", 0.0, "9273628105", "images/profiles/default.jpg", 1, "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf" },
                    { 19, 2, "GSM:887726051", new DateTime(2008, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5811), "ivanka.nikolova@gmail.com", "Ivanka", false, "Nikolova", "Georgieva", 0.0, "3846204951", "images/profiles/default.jpg", 1, "0c4b8988-22f2-4ed5-8486-85e757a97e41" },
                    { 20, 5, "GSM:883467150", new DateTime(2005, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5816), "gergana.georgieva@gmail.com", "Gergana", false, "Georgieva", "Todorova", 0.0, "1294956172", "images/profiles/default.jpg", 1, "3a76fd9d-a1bb-48f2-9626-1122ecf2d797" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Absences_CourseId",
                table: "Absences",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Absences_StudentId",
                table: "Absences",
                column: "StudentId");

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
                name: "IX_News_PublisherId",
                table: "News",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_CourseId",
                table: "Remarks",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_StudentId",
                table: "Remarks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_TeacherId",
                table: "Remarks",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolId",
                table: "Teachers",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absences");

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
                name: "News");

            migrationBuilder.DropTable(
                name: "Remarks");

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

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
