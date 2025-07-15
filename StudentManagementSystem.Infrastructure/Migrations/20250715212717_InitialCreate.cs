using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false),
                    PersonalId = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true, comment: "Personal ID is a unique identifier for each person."),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true, comment: "First name of the user."),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true, comment: "Last name of the user."),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "School Identifier")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "School Name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "News Identifier")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "News Title"),
                    Content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false, comment: "News Content"),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "News Date"),
                    PublisherId = table.Column<string>(type: "text", nullable: false, comment: "Publisher Identifier"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Shows if news is Deleted")
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
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "Teacher Identifier")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SchoolId = table.Column<int>(type: "integer", nullable: false, comment: "School Identifier"),
                    Titles = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "Teacher Titles"),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Teacher First Name"),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Teacher Last Name"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Shows if teacher is Deleted"),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "Student Email Address"),
                    ProfilePicturePath = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "Path to the profile picture of the student"),
                    UserId = table.Column<string>(type: "text", nullable: false, comment: "User Identifier"),
                    ContactDetails = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "Teacher Contact Details")
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "The name of the class"),
                    TeacherId = table.Column<int>(type: "integer", nullable: false, comment: "The ID of the teacher for this class"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Shows if class is Deleted")
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
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "Course Identifier")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "Course Name"),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "Course Description"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Shows if course is Deleted"),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Course Start Date"),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Course End Date"),
                    EnrollmentCap = table.Column<int>(type: "integer", nullable: false, comment: "Maximum number of students allowed"),
                    TeacherId = table.Column<int>(type: "integer", nullable: true, comment: "Teacher of the Course"),
                    PublisherId = table.Column<string>(type: "text", nullable: false, comment: "Publisher Identification")
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
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "Student Identifier")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SchoolId = table.Column<int>(type: "integer", nullable: false, comment: "School Identifier"),
                    PersonalId = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false, comment: "Student Personal Identification Number"),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Student First Name"),
                    MiddleName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Student Middle Name"),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Student Last Name"),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "Student Email Address"),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Date of birth of Student"),
                    ContactDetails = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "Student Contact Details"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Shows if student is Deleted"),
                    UserId = table.Column<string>(type: "text", nullable: false, comment: "User Identifier"),
                    ClassId = table.Column<int>(type: "integer", nullable: false, comment: "Class Identifier"),
                    ProfilePicturePath = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false, comment: "Path to the profile picture of the student"),
                    Performance = table.Column<double>(type: "double precision", nullable: false, comment: "Student Performance")
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
                    ClassId = table.Column<int>(type: "integer", nullable: false, comment: "Class Identifier"),
                    CourseId = table.Column<int>(type: "integer", nullable: false, comment: "Course Identifier"),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Date of enrollment")
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
                name: "CoursesSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "Course Schedule Identifier")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CourseId = table.Column<int>(type: "integer", nullable: false, comment: "Course Identifier"),
                    ClassId = table.Column<int>(type: "integer", nullable: false, comment: "Class Identifier"),
                    Day = table.Column<int>(type: "integer", nullable: false, comment: "Day of the week"),
                    StartTime = table.Column<TimeSpan>(type: "interval", nullable: false, comment: "Start Time"),
                    EndTime = table.Column<TimeSpan>(type: "interval", nullable: false, comment: "End Time")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursesSchedules_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesSchedules_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Absences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "Absence Identifier")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentId = table.Column<int>(type: "integer", nullable: false, comment: "Student Identifier"),
                    CourseId = table.Column<int>(type: "integer", nullable: false, comment: "Course Identifier"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Shows if absence is Deleted"),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Date of Absence")
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
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "Unique Identifier for the Grade entry")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CourseId = table.Column<int>(type: "integer", nullable: false, comment: "Identifier of the Course"),
                    StudentId = table.Column<int>(type: "integer", nullable: false, comment: "Identifier of the Student"),
                    GradeScore = table.Column<double>(type: "double precision", nullable: false, comment: "Grade received by the student for a specific course assessment"),
                    GradeAssignedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Date when the grade was assigned"),
                    GradeType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Description or type of the grade (e.g., Midterm, Final, Homework)"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Shows if grade is Deleted")
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
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "Remark Identifier")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RemarkText = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false, comment: "Remark Text"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Shows if remark is Deleted"),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Date of the remark"),
                    StudentId = table.Column<int>(type: "integer", nullable: false, comment: "Student Identifier"),
                    TeacherId = table.Column<int>(type: "integer", nullable: false, comment: "Teacher Identifier"),
                    CourseId = table.Column<int>(type: "integer", nullable: false, comment: "Course Identifier")
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Administrator", "ADMINISTRATOR" },
                    { "2", null, "Teacher", "TEACHER" },
                    { "3", null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01185cf1-525d-478a-ad05-b9629573333a", 0, "85319641-ee07-4466-a443-f47879dd9013", "IdentityUser", "katerina.gancheva@gmail.com", true, false, null, "KATERINA.GANCHEVA@GMAIL.COM", "KATERINA.GANCHEVA@GMAIL.COM", "AQAAAAIAAYagAAAAEJmZg2fRXXxhEy1JpyFQnGT1NzWsGQ2M1HHPBcUT/WVMERjQRpKVVnF4AOAekTW8gg==", null, false, "d3d9e29f-e644-4029-8013-b3fc253b269e", false, "katerina.gancheva@gmail.com" },
                    { "030ddabd-7dcb-46ca-bab6-3feeae3492a8", 0, "4daae4ee-6816-4fa2-94ae-7d907eb5bf34", "IdentityUser", "nikolai.vasilev@gmail.com", true, false, null, "NIKOLAI.VASILEV@GMAIL.COM", "NIKOLAI.VASILEV@GMAIL.COM", "AQAAAAIAAYagAAAAELN8NEttCprQch9iRbHsHJwXpG8IR2sSPilAFuMd/zV9TJX2YKhT16C/HPtPA1wWng==", null, false, "", false, "nikolai.vasilev@gmail.com" },
                    { "04b6c6b1-5f9b-4c7a-9f42-86193c03d327", 0, "c79c0cca-f8b1-40a2-960c-2fd4936288ea", "IdentityUser", "stefan.kovachev@gmail.com", true, false, null, "STEFAN.KOVACHEV@GMAIL.COM", "STEFAN.KOVACHEV@GMAIL.COM", "AQAAAAIAAYagAAAAEAllgmc22HKiFIh0yeHwUC/uxlB+y50xokDTivT0qgwAFcqfy1btzlo0vO1bsKkb9w==", null, false, "", false, "stefan.kovachev@gmail.com" },
                    { "0c4b8988-22f2-4ed5-8486-85e757a97e41", 0, "4477223d-5baa-4d87-a7a8-7ac1aa754874", "IdentityUser", "ivanka.nikolova@gmail.com", true, false, null, "IVANKA.NIKOLOVA@GMAIL.COM", "IVANKA.NIKOLOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEKJlVflIDRac/6+alZkXaxlLhu8bTyynwkHLt2RwUrPsRDqA4lzoKpnGOzE97KA7zQ==", null, false, "f21fa442-df70-4056-85aa-240b2445bbb1", false, "ivanka.nikolova@gmail.com" },
                    { "1a688e82-f609-47af-a359-d8bcdd62b5e9", 0, "d5e7bddb-ecba-4a0c-93f0-7e98b5ecee6d", "IdentityUser", "ivo.pavlov@gmail.com", true, false, null, "IVO.PAVLOV@GMAIL.COM", "IVO.PAVLOV@GMAIL.COM", "AQAAAAIAAYagAAAAELLjXCH8oBnMjCtnn1pjQwGRkEEtHiJc0Lq6Nx5n5ueg1ybtBFQ00w10BqK4z+/13Q==", null, false, "ee3ff679-72e0-4128-9d86-fb7fc9467a28", false, "ivo.pavlov@gmail.com" },
                    { "217e3e65-026d-4a8e-97af-a4fb30dfab30", 0, "42ef50bc-fc6a-4e57-bdd5-dd18008ae1aa", "IdentityUser", "pesho278@gmail.com", true, false, null, "PESHO278@GMAIL.COM", "PESHO278@GMAIL.COM", "AQAAAAIAAYagAAAAEJqwEFCsg7Y8LgHl+fCYFYJzVHnorEWbwKTukvdmSXMTfGlCxtypStT2kdqLL3YsCQ==", null, false, "f053cf2c-7161-4047-8d40-8b1572187465", false, "pesho278@gmail.com" },
                    { "291cc1a8-8f2c-4f48-a919-ff4d9692a859", 0, "15f53ab1-4f1a-4148-b70f-5a69851f1b94", "IdentityUser", "radoslav.ivanov@gmail.com", true, false, null, "RADOSLAV.IVANOV@GMAIL.COM", "RADOSLAV.IVANOV@GMAIL.COM", "AQAAAAIAAYagAAAAEF9m4fYKdmStKq5HBnBnj8aV0sNaItqXCB2EytEazARxA3mTgNxiirO2bHdv161baQ==", null, false, "", false, "radoslav.ivanov@gmail.com" },
                    { "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45", 0, "03f2ee00-4cfb-4140-89ad-d32279f1dad3", "IdentityUser", "lidia.todorova@gmail.com", true, false, null, "LIDIA.TODOROVA@GMAIL.COM", "LIDIA.TODOROVA@GMAIL.COM", "AQAAAAIAAYagAAAAECEJpLwlPVZuRRo0vHRgOLYULsm2yERsafmMY2zWVchMRKsNj3dceVXm0gVhcmPZ2Q==", null, false, "", false, "lidia.todorova@gmail.com" },
                    { "2e830c43-2ce2-462d-9880-be8aa1e71696", 0, "b42d4e53-9357-4570-a210-89e9466c041e", "IdentityUser", "diana.ruseva@gmail.com", true, false, null, "DIANA.RUSEVA@GMAIL.COM", "DIANA.RUSEVA@GMAIL.COM", "AQAAAAIAAYagAAAAED3cGvDyv4g30Ca8XjNX4VlZG5xGiIZqDifvtqgmw1vHDA4BeZxTHOCO+Atw4fVqig==", null, false, "a6144ebc-c0e1-41d7-86a3-36ec8131fa53", false, "diana.ruseva@gmail.com" },
                    { "3034c6c5-e1f5-4655-9baf-079f41605550", 0, "b299beb2-ffbf-41e8-ac03-18f33a1e84af", "IdentityUser", "julia.dimitrova@gmail.com", true, false, null, "JULIA.DIMITROVA@GMAIL.COM", "JULIA.DIMITROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEAehzqwKXQP10IqgKl4FZwbTD1iaG0K/UvHHKW7aHBHmYgX6obFXwObX4enpPPZlKg==", null, false, "a25472ce-d234-4ac4-837c-77f7534edd88", false, "julia.dimitrova@gmail.com" },
                    { "325092c7-9882-40d9-854b-32326c2bd43b", 0, "ef7847f5-e55b-4c6a-9705-6d195265a3de", "IdentityUser", "stefan.yordanov@gmail.com", true, false, null, "STEFAN.YORDANOV@GMAIL.COM", "STEFAN.YORDANOV@GMAIL.COM", "AQAAAAIAAYagAAAAEHIUd/5A0aCan5/zv5+ttbvpSvRyBaIXrecMNPjS9MzL7fUDOLfnQMLH7C3VwXhN5w==", null, false, "1d6f87d4-06cc-4c1b-b0b0-84cf3c20a895", false, "stefan.yordanov@gmail.com" },
                    { "32739a60-8250-4178-a19c-96d90444ebd3", 0, "3f801017-0170-4e6c-a939-f6a70d77452f", "IdentityUser", "katerina.dimitrova@gmail.com", true, false, null, "KATERINA.DIMITROVA@GMAIL.COM", "KATERINA.DIMITROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEGzTHDFvAZ+LXs3Zc4nxgML5L0/jaKPYGFDGXhN9W1BNMtRwWWcM/d++gi5XluFNzA==", null, false, "", false, "katerina.dimitrova@gmail.com" },
                    { "331d08d0-d407-4d61-af6e-1bb134ae7998", 0, "b1755bf8-cb69-4ad3-bdac-bed72a9dd321", "IdentityUser", "mariya.petrova@gmail.com", true, false, null, "MARIYA.PETROVA@GMAIL.COM", "MARIYA.PETROVA@GMAIL.COM", "AQAAAAIAAYagAAAAECEeO4R2rP1zpgxYDVGcjOfia+krH/w4txSP+Pk3D/2QJG6bJIWeJ43f59UvPYPwXQ==", null, false, "", false, "mariya.petrova@gmail.com" },
                    { "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729", 0, "6d2aa81f-83b6-4575-8500-bfc410c7fee8", "IdentityUser", "gosho.georgiev@gmail.com", true, false, null, "GOSHO.GEORGIEV@GMAIL.COM", "GOSHO.GEORGIEV@GMAIL.COM", "AQAAAAIAAYagAAAAEMv9SKxYKz4jWWvfXhc7CuF4v1j9nAdq6eIRO0H6CrfwbgQW/wy45HWWWWq37RV0Vg==", null, false, "", false, "gosho.georgiev@gmail.com" },
                    { "3a76fd9d-a1bb-48f2-9626-1122ecf2d797", 0, "2b43b93b-af5c-40e5-a884-6a402dc4005f", "IdentityUser", "gergana.georgieva@gmail.com", true, false, null, "GERGANA.GEORGIEVA@GMAIL.COM", "GERGANA.GEORGIEVA@GMAIL.COM", "AQAAAAIAAYagAAAAEHVw6FSZBhi0XE+VTBpsTqHRBIxVMIrvzSYtv/p7LK36qyIttl1kubxZeHcVvXdvAg==", null, false, "57a3512a-c165-4ced-8de5-e49beb3242ad", false, "gergana.georgieva@gmail.com" },
                    { "51065229-23b9-402f-a54d-00bb813d6b1c", 0, "8823ae15-7f60-491e-a9fc-baa4e0988a8b", "IdentityUser", "stan12@gmail.com", true, false, null, "STAN12@GMAIL.COM", "STAN12@GMAIL.COM", "AQAAAAIAAYagAAAAEJCL8tHiUkAnLnMXL5aq42kgfF7saXx8oP8MQtuj6JAR0E3IUQ9KN5hm6BWj9eH07g==", null, false, "", false, "stan12@gmail.com" },
                    { "6b6433a7-3564-4cba-ace2-4a44afca4177", 0, "35ffa77a-a023-4736-ad7b-e5e04de92d88", "IdentityUser", "ivdra23@gmail.com", true, false, null, "IVDRA23@GMAIL.COM", "IVDRA23@GMAIL.COM", "AQAAAAIAAYagAAAAELrYwvwvsH6myRn1fLN6tJLqdP/MVU5rGMxCxsrJMYZdeJzRVFDKthulhaXyW1pWjg==", null, false, "", false, "ivdra23@gmail.com" },
                    { "8eb86d7d-02f7-477d-8e6f-539d7c155930", 0, "55dd143f-207a-4861-989b-ba5acc066068", "IdentityUser", "aleksandar.pavlov@gmail.com", true, false, null, "ALEKSANDAR.PAVLOV@GMAIL.COM", "ALEKSANDAR.PAVLOV@GMAIL.COM", "AQAAAAIAAYagAAAAEMzWJzKgeu6tnHF4kLoPamaPjcwyz3fvsMPHeUdKu35VcZcEST+EFbcfpzgZAN/i7Q==", null, false, "841f483d-81aa-4a78-a1b8-d3660bde332a", false, "aleksandar.pavlov@gmail.com" },
                    { "8f7bca8f-059f-4750-8bfe-7def13ef37e8", 0, "5a7ae014-fff9-42b0-bf5c-317810046f30", "IdentityUser", "nina.borisova@gmail.com", true, false, null, "NINA.BORISOVA@GMAIL.COM", "NINA.BORISOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEBf6JAgMnwXi1Ix0IV+nmVgWjCmrIcMgkiZBrqw/l1L006CE6ZSxEG9Anwvbnzpkjg==", null, false, "3431f198-ea13-4903-b16b-5c7b46318480", false, "nina.borisova@gmail.com" },
                    { "9ab8c775-88c0-4dc3-b11d-178c3ca2129", 0, "95caa177-35db-45d4-93b9-92cb6ce7fe78", "IdentityUser", "valentina.nikolova@gmail.com", true, false, null, "VALENTINA.NIKOLOVA@GMAIL.COM", "VALENTINA.NIKOLOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEE6jN2raZbh3uFu2Vp4jeG00ZygilZhUaamANtLIVBWaIaYaz5fmlOr5L0hhl3rGxg==", null, false, "", false, "valentina.nikolova@gmail.com" },
                    { "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c", 0, "07f66757-e878-4dbd-bfe3-3c2671179a32", "IdentityUser", "ivan414@gmail.com", true, false, null, "IVAN414@GMAIL.COM", "IVAN414@GMAIL.COM", "AQAAAAIAAYagAAAAEBRL0j2dtknYsTBJSG+WiknXM8RyXa+6wx5P+yv48Yfcg8JUYkZ0azdC5PAjWRLpZA==", null, false, "a5c12553-92da-40ac-9809-ef25ea2d71b1", false, "ivan414@gmail.com" },
                    { "ab696b9f-f5d2-45a0-8495-96e2d2a01acc", 0, "feeb8449-2e7f-4896-b5f3-cbb13184c123", "IdentityUser", "tanya.ivanova@gmail.com", true, false, null, "TANYA.IVANOVA@GMAIL.COM", "TANYA.IVANOVA@GMAIL.COM", "AQAAAAIAAYagAAAAEPY/eEFotiL98insqbW2xY6IQfeW0jAB3gBWnA5qdFm+oL2zInEFr6XoUM4VJAO+/g==", null, false, "49764c7c-7ecf-4f04-9947-2afbb23287d2", false, "tanya.ivanova@gmail.com" },
                    { "b65e6163-1454-4164-9869-2ff822f9da98", 0, "d05a8443-fedd-4118-802e-3374f0a6d239", "IdentityUser", "elena309@gmail.com", true, false, null, "ELENA309@GMAIL.COM", "ELENA309@GMAIL.COM", "AQAAAAIAAYagAAAAEBiPxYeobAfYoa4LtwS9FjmrDAD19FytPVGi5TP54qlhT6aJok1W//9aYIMUX39wnA==", null, false, "46e0ec46-9082-4ebd-8fe0-3505ad943e42", false, "elena309@gmail.com" },
                    { "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf", 0, "8359a559-bf9d-4bcb-8cb5-4ad90c4ae0a1", "IdentityUser", "lazar.grigorov@gmail.com", true, false, null, "LAZAR.GRIGOROV@GMAIL.COM", "LAZAR.GRIGOROV@GMAIL.COM", "AQAAAAIAAYagAAAAEBHcvLG6lQdnVg4gRX1j1lNxLZX4qW37TWlIPucMwHyuSxOqzpm3Maj3HBP7PpQ7Ng==", null, false, "656f41ec-caa1-4887-93a5-f8cde0aca79c", false, "lazar.grigorov@gmail.com" },
                    { "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f", 0, "91b32625-48ac-49df-b131-161214dee6b1", "IdentityUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJM/HNK4i5GvD2p/M+SHBti0t8ebaYzx8Ao7dX2DWshftgnr5yoB0jivV6Vmt24gcg==", null, false, "", false, "admin@admin.com" },
                    { "c5d7d80f-08d5-41ec-892c-30833098c047", 0, "f547726e-ba34-4e8f-9e02-1c8c84e7ac29", "IdentityUser", "viktor725@gmail.com", true, false, null, "VIKTOR725@GMAIL.COM", "VIKTOR725@GMAIL.COM", "AQAAAAIAAYagAAAAEJ3XTe8NgUNjU987Jk5pNqd3xRhKHxyq2DcdlFn5ywHDv9MVFrVtaVFwTrQ6Z8G5tg==", null, false, "af25370c-5343-4bbd-a803-17551441a13b", false, "viktor725@gmail.com" },
                    { "c64af0f1-3716-4e30-b5f7-b0c5153e2b01", 0, "02915589-bf33-499d-a346-de6d1c07b4d6", "IdentityUser", "petar.georgiev@gmail.com", true, false, null, "PETAR.GEORGIEV@GMAIL.COM", "PETAR.GEORGIEV@GMAIL.COM", "AQAAAAIAAYagAAAAEEt06IheEGnyAyIONnSe6nXce4/m6jUM15aKVy+gpYaGoaUN8AnWyDs9H4HRnWoZPw==", null, false, "39ea0f2d-76d9-49a8-b689-d508437fc59b", false, "petar.georgiev@gmail.com" },
                    { "cab3584a-da3f-4858-a65a-3f7bde9e553f", 0, "7b4f7aa1-54b1-4662-b186-a67b097b5e7f", "IdentityUser", "dimitar.mihailov@gmail.com", true, false, null, "DIMITAR.MIHAILOV@GMAIL.COM", "DIMITAR.MIHAILOV@GMAIL.COM", "AQAAAAIAAYagAAAAEMMIJvMpDkn+lWRYVl8p5FQ5jQMZcCph+YibGhYbko8XGyv3okpubWZW57+Qtl0U7w==", null, false, "87cdd141-f969-4ae8-b78d-c369359df055", false, "dimitar.mihailov@gmail.com" },
                    { "e0e396e6-53f2-40e9-8013-664b8a8dbd46", 0, "fe59f3a7-50f0-40ca-bfde-2d44527a63a2", "IdentityUser", "daniela.todorova@gmail.com", true, false, null, "DANIELA.TODOROVA@GMAIL.COM", "DANIELA.TODOROVA@GMAIL.COM", "AQAAAAIAAYagAAAAEOrfL65PSNY4iyTI1Ig7LGQFDPYv9A+/NZrk9lj9IOh9QWOl1r1mieTPLMcImJBYrg==", null, false, "8b4994c5-699e-4ea2-9f1c-4474ba901fef", false, "daniela.todorova@gmail.com" },
                    { "e8264a26-ea76-44c4-a013-12759599a081", 0, "f5dc2a18-f91b-4b56-80a1-c7295211fdf1", "IdentityUser", "kiril.kolarov@gmail.com", true, false, null, "KIRIL.KOLAROV@GMAIL.COM", "KIRIL.KOLAROV@GMAIL.COM", "AQAAAAIAAYagAAAAEDGCxtJGIOjdNzOkLDYdBD09VA0GgB68enDRiSRIxAqqFjEqagvLcmIn5UG1hYtCQA==", null, false, "2e9b12c5-c347-4e6d-9af1-f29fe2166eaf", false, "kiril.kolarov@gmail.com" },
                    { "f2875100-0cf1-4b1d-ba91-1dfa38690f84", 0, "cd74b7ed-de99-4c39-8b99-1b5a55f1c5aa", "IdentityUser", "maria270@gmail.com", true, false, null, "MARIA270@GMAIL.COM", "MARIA270@GMAIL.COM", "AQAAAAIAAYagAAAAEEXMcycgafVqXDzo3xwPDmFdSkIop3YXPK1A9Yr3i9R8KhBcrkj4alDPVygFrvaRyA==", null, false, "5378ef2c-c5c8-4f80-962f-ddbb35c8e5af", false, "maria270@gmail.com" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "01185cf1-525d-478a-ad05-b9629573333a" },
                    { "2", "030ddabd-7dcb-46ca-bab6-3feeae3492a8" },
                    { "2", "04b6c6b1-5f9b-4c7a-9f42-86193c03d327" },
                    { "3", "0c4b8988-22f2-4ed5-8486-85e757a97e41" },
                    { "3", "1a688e82-f609-47af-a359-d8bcdd62b5e9" },
                    { "3", "217e3e65-026d-4a8e-97af-a4fb30dfab30" },
                    { "2", "291cc1a8-8f2c-4f48-a919-ff4d9692a859" },
                    { "2", "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45" },
                    { "3", "2e830c43-2ce2-462d-9880-be8aa1e71696" },
                    { "3", "3034c6c5-e1f5-4655-9baf-079f41605550" },
                    { "3", "325092c7-9882-40d9-854b-32326c2bd43b" },
                    { "2", "32739a60-8250-4178-a19c-96d90444ebd3" },
                    { "2", "331d08d0-d407-4d61-af6e-1bb134ae7998" },
                    { "2", "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729" },
                    { "3", "3a76fd9d-a1bb-48f2-9626-1122ecf2d797" },
                    { "2", "51065229-23b9-402f-a54d-00bb813d6b1c" },
                    { "3", "51065229-23b9-402f-a54d-00bb813d6b1c" },
                    { "2", "6b6433a7-3564-4cba-ace2-4a44afca4177" },
                    { "3", "8eb86d7d-02f7-477d-8e6f-539d7c155930" },
                    { "3", "8f7bca8f-059f-4750-8bfe-7def13ef37e8" },
                    { "2", "9ab8c775-88c0-4dc3-b11d-178c3ca2129" },
                    { "2", "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c" },
                    { "3", "ab696b9f-f5d2-45a0-8495-96e2d2a01acc" },
                    { "3", "b65e6163-1454-4164-9869-2ff822f9da98" },
                    { "3", "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf" },
                    { "1", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f" },
                    { "3", "c5d7d80f-08d5-41ec-892c-30833098c047" },
                    { "3", "c64af0f1-3716-4e30-b5f7-b0c5153e2b01" },
                    { "3", "cab3584a-da3f-4858-a65a-3f7bde9e553f" },
                    { "3", "e0e396e6-53f2-40e9-8013-664b8a8dbd46" },
                    { "3", "e8264a26-ea76-44c4-a013-12759599a081" },
                    { "3", "f2875100-0cf1-4b1d-ba91-1dfa38690f84" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Content", "Date", "IsDeleted", "PublisherId", "Title" },
                values: new object[,]
                {
                    { 1, "The new school year has officially begun. We are excited to welcome all students back to campus and look forward to a successful year ahead.", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "New School Year Begins" },
                    { 2, "The annual science fair will be held next month. Students are encouraged to participate and showcase their projects.", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "Science Fair Announced" },
                    { 3, "Sports day is scheduled for the end of the semester. Students can participate in various sports activities.", new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "Sports Day Scheduled" },
                    { 4, "An art exhibition will be held in the school auditorium. Students' artworks will be displayed.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "Art Exhibition" },
                    { 5, "A parent-teacher meeting is scheduled for next week. Parents are encouraged to attend and discuss their child's progress.", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "Parent-Teacher Meeting" },
                    { 6, "The school will be celebrating the upcoming holidays with various events and activities. Students are invited to participate.", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Utc), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "Holiday Celebration" }
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
                    { 1, false, "10 B", 21 },
                    { 2, false, "9 A", 22 },
                    { 3, false, "11 C", 23 },
                    { 4, false, "12 A", 24 },
                    { 5, false, "8 B", 25 },
                    { 6, false, "7 A", 26 },
                    { 7, false, "6 C", 27 },
                    { 8, false, "10 A", 28 },
                    { 9, false, "9 B", 29 },
                    { 10, false, "11 A", 30 }
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
                table: "ClassCourses",
                columns: new[] { "ClassId", "CourseId", "EnrollmentDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CoursesSchedules",
                columns: new[] { "Id", "ClassId", "CourseId", "Day", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, 1, 2, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, 1, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, 1, 4, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 5, 1, 5, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 6, 1, 6, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 7, 1, 7, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 8, 1, 8, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 9, 1, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 10, 1, 10, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 11, 1, 1, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 12, 1, 2, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 13, 1, 3, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 14, 1, 4, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 15, 1, 5, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 16, 1, 6, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 17, 1, 7, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 18, 1, 8, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 19, 1, 9, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 20, 1, 10, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 21, 1, 1, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 22, 1, 2, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 23, 1, 3, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 24, 1, 4, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 25, 1, 5, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 26, 1, 6, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 27, 1, 7, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 28, 1, 8, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 29, 1, 9, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 30, 1, 10, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 31, 2, 1, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 32, 2, 2, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 33, 2, 3, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 34, 2, 4, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 35, 2, 5, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 36, 2, 6, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 37, 2, 7, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 38, 2, 8, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 39, 2, 9, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 40, 2, 10, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 41, 2, 1, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 42, 2, 2, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 43, 2, 3, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 44, 2, 4, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 45, 2, 5, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 46, 2, 6, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 47, 2, 7, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 48, 2, 8, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 49, 2, 9, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 50, 2, 10, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 51, 2, 1, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 52, 2, 2, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 53, 2, 3, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 54, 2, 4, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 55, 2, 5, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 56, 2, 6, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 57, 2, 7, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 58, 2, 8, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 59, 2, 9, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 60, 3, 10, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 61, 3, 1, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 62, 3, 2, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 63, 3, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 64, 3, 4, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 65, 3, 5, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 66, 3, 6, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 67, 3, 7, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 68, 3, 8, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 69, 3, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 70, 3, 10, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 71, 3, 1, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 72, 3, 2, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 73, 3, 3, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 74, 3, 4, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 75, 3, 5, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 76, 3, 6, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 77, 3, 7, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 78, 3, 8, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 79, 3, 9, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 80, 3, 10, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 81, 3, 1, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 82, 3, 2, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 83, 3, 3, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 84, 3, 4, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 85, 3, 5, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 86, 3, 6, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 87, 3, 7, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 88, 3, 8, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 89, 3, 9, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 90, 3, 10, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 91, 4, 1, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 92, 4, 2, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 93, 4, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 94, 4, 4, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 95, 4, 5, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 96, 4, 6, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 97, 4, 7, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 98, 4, 8, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 99, 4, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 100, 4, 10, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 101, 4, 1, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 102, 4, 2, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 103, 4, 3, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 104, 4, 4, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 105, 4, 5, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 106, 4, 6, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 107, 4, 7, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 108, 4, 8, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 109, 4, 9, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 110, 4, 10, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 111, 4, 1, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 112, 4, 2, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 113, 4, 3, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 114, 4, 4, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 115, 4, 5, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 116, 4, 6, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 117, 4, 7, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 118, 4, 8, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 119, 4, 9, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 120, 4, 10, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 121, 4, 1, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 122, 5, 2, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 123, 5, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 124, 5, 4, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 125, 5, 5, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 126, 5, 6, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 127, 5, 7, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 128, 5, 8, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 129, 5, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 130, 5, 10, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 131, 5, 1, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 132, 5, 2, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 133, 5, 3, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 134, 5, 4, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 135, 5, 5, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 136, 5, 6, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 137, 5, 7, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 138, 5, 8, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 139, 5, 9, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 140, 5, 10, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 141, 5, 1, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 142, 5, 2, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 143, 5, 3, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 144, 5, 4, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 145, 5, 5, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 146, 5, 6, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 147, 5, 7, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 148, 5, 8, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 149, 5, 9, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 150, 5, 10, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 151, 6, 1, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 152, 6, 2, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 153, 6, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 154, 6, 4, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 155, 6, 5, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 156, 6, 6, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 157, 6, 7, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 158, 6, 8, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 159, 6, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 160, 6, 10, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 161, 6, 1, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 162, 6, 2, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 163, 6, 3, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 164, 6, 4, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 165, 6, 5, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 166, 6, 6, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 167, 6, 7, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 168, 6, 8, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 169, 6, 9, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 170, 6, 10, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 171, 6, 1, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 172, 6, 2, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 173, 6, 3, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 174, 6, 4, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 175, 6, 5, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 176, 6, 6, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 177, 6, 7, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 178, 6, 8, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 179, 6, 9, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 180, 7, 10, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 181, 7, 1, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 182, 7, 2, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 183, 7, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 184, 7, 4, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 185, 7, 5, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 186, 7, 6, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 187, 7, 7, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 188, 7, 8, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 189, 7, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 190, 7, 10, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 191, 7, 1, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 192, 7, 2, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 193, 7, 3, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 194, 7, 4, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 195, 7, 5, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 196, 7, 6, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 197, 7, 7, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 198, 7, 8, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 199, 7, 9, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 200, 7, 10, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 201, 7, 1, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 202, 7, 2, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 203, 7, 3, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 204, 7, 4, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 205, 7, 5, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 206, 7, 6, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 207, 7, 7, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 208, 7, 8, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 209, 8, 9, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 210, 8, 10, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 211, 8, 1, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 212, 8, 2, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 213, 8, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 214, 8, 4, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 215, 8, 5, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 216, 8, 6, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 217, 8, 7, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 218, 8, 8, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 219, 8, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 220, 8, 10, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 221, 8, 1, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 222, 8, 2, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 223, 8, 3, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 224, 8, 4, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 225, 8, 5, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 226, 8, 6, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 227, 8, 7, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 228, 8, 8, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 229, 8, 9, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 230, 8, 10, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 231, 8, 1, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 232, 8, 2, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 233, 8, 3, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 234, 8, 4, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 235, 8, 5, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 236, 8, 6, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 237, 8, 7, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 238, 9, 8, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 239, 9, 9, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 240, 9, 10, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 241, 9, 1, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 242, 9, 2, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 243, 9, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 244, 9, 4, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 245, 9, 5, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 246, 9, 6, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 247, 9, 7, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 248, 9, 8, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 249, 9, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 250, 9, 10, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 251, 9, 1, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 252, 9, 2, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 253, 9, 3, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 254, 9, 4, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 255, 9, 5, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 256, 9, 6, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 257, 9, 7, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 258, 9, 8, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 259, 9, 9, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 260, 9, 10, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 261, 9, 1, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 262, 9, 2, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 263, 9, 3, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 264, 9, 4, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 265, 9, 5, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 266, 9, 6, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 267, 10, 7, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 268, 10, 8, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 269, 10, 9, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 270, 10, 10, 2, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 271, 10, 1, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 272, 10, 2, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 273, 10, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 274, 10, 4, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 275, 10, 5, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 276, 10, 6, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 277, 10, 7, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 278, 10, 8, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 279, 10, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 280, 10, 10, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "ContactDetails", "DateOfBirth", "Email", "FirstName", "IsDeleted", "LastName", "MiddleName", "Performance", "PersonalId", "ProfilePicturePath", "SchoolId", "UserId" },
                values: new object[,]
                {
                    { 1, 3, "GSM:882163890", new DateTime(2007, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8654), "ivan414@gmail.com", "Ivan", false, "Petrov", "Grigorov", 0.0, "9564039305", "images/profiles/default.jpg", 1, "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c" },
                    { 2, 5, "GSM:889556992", new DateTime(2008, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8666), "maria270@gmail.com", "Maria", false, "Grigorov", "Georgiev", 0.0, "6934567210", "images/profiles/default.jpg", 1, "f2875100-0cf1-4b1d-ba91-1dfa38690f84" },
                    { 3, 5, "GSM:883854732", new DateTime(2008, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8670), "elena309@gmail.com", "Elena", false, "Todorov", "Grigorov", 0.0, "3699302616", "images/profiles/default.jpg", 1, "b65e6163-1454-4164-9869-2ff822f9da98" },
                    { 4, 4, "GSM:886992374", new DateTime(2007, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8672), "viktor725@gmail.com", "Viktor", false, "Todorov", "Todorov", 0.0, "2940063663", "images/profiles/default.jpg", 1, "c5d7d80f-08d5-41ec-892c-30833098c047" },
                    { 5, 2, "GSM:884738222", new DateTime(2009, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8675), "pesho278@gmail.com", "Pesho", false, "Nikolov", "Nikolov", 0.0, "4204190914", "images/profiles/default.jpg", 1, "217e3e65-026d-4a8e-97af-a4fb30dfab30" },
                    { 6, 1, "GSM:888183734", new DateTime(2006, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8678), "nina.borisova@gmail.com", "Nina", false, "Todorova", "Borisova", 0.0, "5392831842", "images/profiles/default.jpg", 1, "8f7bca8f-059f-4750-8bfe-7def13ef37e8" },
                    { 7, 1, "GSM:883764543", new DateTime(2005, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8681), "ivo.pavlov@gmail.com", "Ivo", false, "Pavlov", "Petrov", 0.0, "6758374932", "images/profiles/default.jpg", 1, "1a688e82-f609-47af-a359-d8bcdd62b5e9" },
                    { 8, 3, "GSM:882847361", new DateTime(2004, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8684), "katerina.gancheva@gmail.com", "Katerina", false, "Gancheva", "Alexandrova", 0.0, "8293840598", "images/profiles/default.jpg", 1, "01185cf1-525d-478a-ad05-b9629573333a" },
                    { 9, 4, "GSM:887654321", new DateTime(2003, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8687), "dimitar.mihailov@gmail.com", "Dimitar", false, "Mihailov", "Georgiev", 0.0, "9382843621", "images/profiles/default.jpg", 1, "cab3584a-da3f-4858-a65a-3f7bde9e553f" },
                    { 10, 5, "GSM:885676543", new DateTime(2002, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8718), "stefan.yordanov@gmail.com", "Stefan", false, "Yordanov", "Ivanov", 0.0, "4902385726", "images/profiles/default.jpg", 1, "325092c7-9882-40d9-854b-32326c2bd43b" },
                    { 11, 2, "GSM:882364788", new DateTime(2005, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8722), "diana.ruseva@gmail.com", "Diana", false, "Ruseva", "Stoyanova", 0.0, "2945641207", "images/profiles/default.jpg", 1, "2e830c43-2ce2-462d-9880-be8aa1e71696" },
                    { 12, 3, "GSM:889276400", new DateTime(2004, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8724), "petar.georgiev@gmail.com", "Petar", false, "Georgiev", "Zahariev", 0.0, "1298345761", "images/profiles/default.jpg", 1, "c64af0f1-3716-4e30-b5f7-b0c5153e2b01" },
                    { 13, 4, "GSM:883712508", new DateTime(2006, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8727), "tanya.ivanova@gmail.com", "Tanya", false, "Ivanova", "Vasileva", 0.0, "8471629304", "images/profiles/default.jpg", 1, "ab696b9f-f5d2-45a0-8495-96e2d2a01acc" },
                    { 14, 2, "GSM:887327015", new DateTime(2007, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8730), "aleksandar.pavlov@gmail.com", "Aleksandar", false, "Pavlov", "Dimitrov", 0.0, "6503849201", "images/profiles/default.jpg", 1, "8eb86d7d-02f7-477d-8e6f-539d7c155930" },
                    { 15, 5, "GSM:888014697", new DateTime(2005, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8732), "julia.dimitrova@gmail.com", "Julia", false, "Dimitrova", "Borisova", 0.0, "8473926140", "images/profiles/default.jpg", 1, "3034c6c5-e1f5-4655-9baf-079f41605550" },
                    { 16, 1, "GSM:884728672", new DateTime(2007, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8735), "kiril.kolarov@gmail.com", "Kiril", false, "Kolarov", "Vasilev", 0.0, "5392837362", "images/profiles/default.jpg", 1, "e8264a26-ea76-44c4-a013-12759599a081" },
                    { 17, 3, "GSM:889253738", new DateTime(2003, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8738), "daniela.todorova@gmail.com", "Daniela", false, "Todorova", "Dimitrova", 0.0, "8282020193", "images/profiles/default.jpg", 1, "e0e396e6-53f2-40e9-8013-664b8a8dbd46" },
                    { 18, 4, "GSM:888107316", new DateTime(2004, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8741), "lazar.grigorov@gmail.com", "Lazar", false, "Grigorov", "Nikolov", 0.0, "9273628105", "images/profiles/default.jpg", 1, "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf" },
                    { 19, 2, "GSM:887726051", new DateTime(2009, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8743), "ivanka.nikolova@gmail.com", "Ivanka", false, "Nikolova", "Georgieva", 0.0, "3846204951", "images/profiles/default.jpg", 1, "0c4b8988-22f2-4ed5-8486-85e757a97e41" },
                    { 20, 5, "GSM:883467150", new DateTime(2006, 7, 15, 21, 27, 15, 205, DateTimeKind.Utc).AddTicks(8746), "gergana.georgieva@gmail.com", "Gergana", false, "Georgieva", "Todorova", 0.0, "1294956172", "images/profiles/default.jpg", 1, "3a76fd9d-a1bb-48f2-9626-1122ecf2d797" }
                });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "Date", "IsDeleted", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 1 },
                    { 2, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 1 },
                    { 3, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 2 },
                    { 4, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 2 },
                    { 5, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 3 },
                    { 6, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 3 },
                    { 7, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 4 },
                    { 8, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 4 },
                    { 10, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 5 },
                    { 11, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 5 },
                    { 12, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 6 },
                    { 13, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 6 },
                    { 14, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 7 },
                    { 15, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 7 },
                    { 16, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 8 },
                    { 17, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 8 },
                    { 18, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 9 },
                    { 20, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 9 },
                    { 21, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 10 },
                    { 22, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 10 },
                    { 23, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 11 },
                    { 24, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 11 },
                    { 25, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 12 },
                    { 26, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 12 },
                    { 27, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 13 },
                    { 28, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 13 },
                    { 29, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 14 },
                    { 30, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 14 },
                    { 31, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 15 },
                    { 32, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 15 },
                    { 33, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 16 },
                    { 34, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 16 },
                    { 35, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 17 },
                    { 36, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 17 },
                    { 37, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 18 },
                    { 38, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 18 },
                    { 39, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 19 },
                    { 40, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 19 },
                    { 41, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 20 },
                    { 42, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 20 }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseId", "GradeAssignedDate", "GradeScore", "GradeType", "IsDeleted", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Final", false, 1 },
                    { 2, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Midterm", false, 1 },
                    { 3, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 1 },
                    { 4, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Quiz", false, 1 },
                    { 5, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Project", false, 1 },
                    { 6, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Second Term Assessment", false, 1 },
                    { 7, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "First Term Assessment", false, 1 },
                    { 8, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 1 },
                    { 9, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Quiz", false, 1 },
                    { 10, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Project", false, 2 },
                    { 11, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Final", false, 2 },
                    { 12, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Midterm", false, 2 },
                    { 13, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Homework", false, 2 },
                    { 14, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Quiz", false, 2 },
                    { 15, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Project", false, 2 },
                    { 16, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Second Term Assessment", false, 2 },
                    { 17, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "First Term Assessment", false, 2 },
                    { 18, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Homework", false, 2 },
                    { 19, 10, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Quiz", false, 2 },
                    { 20, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 3 },
                    { 21, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 3 },
                    { 22, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 3 },
                    { 23, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 3 },
                    { 24, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 3 },
                    { 25, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 3 },
                    { 26, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 3 },
                    { 27, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 3 },
                    { 28, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 3 },
                    { 29, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 4 },
                    { 30, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 4 },
                    { 31, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 4 },
                    { 32, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 4 },
                    { 33, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 4 },
                    { 34, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 4 },
                    { 35, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 4 },
                    { 36, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 4 },
                    { 37, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 4 },
                    { 38, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 5 },
                    { 39, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 5 },
                    { 40, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 5 },
                    { 41, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 5 },
                    { 42, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 5 },
                    { 43, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 5 },
                    { 44, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 5 },
                    { 45, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 5 },
                    { 46, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 5 },
                    { 47, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 6 },
                    { 48, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 6 },
                    { 49, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 6 },
                    { 50, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 6 },
                    { 51, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 6 },
                    { 52, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 6 },
                    { 53, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 6 },
                    { 54, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 6 },
                    { 55, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 6 },
                    { 56, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 7 },
                    { 57, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 7 },
                    { 58, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 7 },
                    { 59, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 7 },
                    { 60, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 7 },
                    { 61, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 7 },
                    { 62, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 7 },
                    { 63, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 7 },
                    { 64, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 7 },
                    { 65, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 8 },
                    { 66, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 8 },
                    { 67, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 8 },
                    { 68, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 8 },
                    { 69, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 8 },
                    { 70, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 8 },
                    { 71, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 8 },
                    { 72, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 8 },
                    { 73, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 8 },
                    { 74, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 9 },
                    { 75, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 9 },
                    { 76, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 9 },
                    { 77, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 9 },
                    { 78, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 9 },
                    { 79, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 9 },
                    { 80, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 9 },
                    { 81, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 9 },
                    { 82, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 9 },
                    { 83, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 10 },
                    { 84, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 10 },
                    { 85, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 10 },
                    { 86, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 10 },
                    { 87, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 10 },
                    { 88, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 10 },
                    { 89, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 10 },
                    { 90, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 10 },
                    { 91, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 10 },
                    { 92, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 11 },
                    { 93, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 11 },
                    { 94, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 11 },
                    { 95, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 11 },
                    { 96, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 11 },
                    { 97, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 11 },
                    { 98, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 11 },
                    { 99, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 11 },
                    { 100, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 11 },
                    { 101, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 12 },
                    { 102, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 12 },
                    { 103, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 12 },
                    { 104, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 12 },
                    { 105, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 12 },
                    { 106, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 12 },
                    { 107, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 12 },
                    { 108, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 12 },
                    { 109, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 12 },
                    { 110, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 13 },
                    { 111, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 13 },
                    { 112, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 13 },
                    { 113, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 13 },
                    { 114, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 13 },
                    { 115, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 13 },
                    { 116, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 13 },
                    { 117, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 13 },
                    { 118, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 13 },
                    { 119, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 14 },
                    { 120, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 14 },
                    { 121, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 14 },
                    { 122, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 14 },
                    { 123, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 14 },
                    { 124, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 14 },
                    { 125, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 14 },
                    { 126, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 14 },
                    { 127, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 14 },
                    { 128, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 15 },
                    { 129, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 15 },
                    { 130, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 15 },
                    { 131, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 15 },
                    { 132, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 15 },
                    { 133, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 15 },
                    { 134, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 15 },
                    { 135, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 15 },
                    { 136, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 15 },
                    { 137, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 16 },
                    { 138, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 16 },
                    { 139, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 16 },
                    { 140, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 16 },
                    { 141, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 16 },
                    { 142, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 16 },
                    { 143, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 16 },
                    { 144, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 16 },
                    { 145, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 16 },
                    { 146, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 17 },
                    { 147, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 17 },
                    { 148, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 17 },
                    { 149, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 17 },
                    { 150, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 17 },
                    { 151, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 17 },
                    { 152, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 17 },
                    { 153, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 17 },
                    { 154, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 17 },
                    { 155, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 18 },
                    { 156, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 18 },
                    { 157, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 18 },
                    { 158, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 18 },
                    { 159, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 18 },
                    { 160, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 18 },
                    { 161, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 18 },
                    { 162, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 18 },
                    { 163, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 18 },
                    { 164, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 19 },
                    { 165, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 19 },
                    { 166, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 19 },
                    { 167, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 19 },
                    { 168, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 19 },
                    { 169, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 19 },
                    { 170, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 19 },
                    { 171, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 19 },
                    { 172, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 19 },
                    { 173, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Final", false, 20 },
                    { 174, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "Midterm", false, 20 },
                    { 175, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 20 },
                    { 176, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 20 },
                    { 177, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 6.0, "Project", false, 20 },
                    { 178, 6, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2.0, "Second Term Assessment", false, 20 },
                    { 179, 7, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3.0, "First Term Assessment", false, 20 },
                    { 180, 8, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 4.0, "Homework", false, 20 },
                    { 181, 9, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 5.0, "Quiz", false, 20 }
                });

            migrationBuilder.InsertData(
                table: "Remarks",
                columns: new[] { "Id", "CourseId", "Date", "IsDeleted", "RemarkText", "StudentId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 1, 22 },
                    { 2, 3, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 1, 23 },
                    { 3, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 1, 24 },
                    { 4, 3, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 2, 23 },
                    { 5, 4, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 2, 24 },
                    { 6, 5, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 2, 25 },
                    { 7, 4, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 3, 24 },
                    { 8, 5, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 3, 25 },
                    { 9, 6, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 3, 26 },
                    { 10, 5, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 4, 25 },
                    { 11, 6, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 4, 26 },
                    { 12, 7, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 4, 27 },
                    { 13, 6, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 5, 26 },
                    { 14, 7, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 5, 27 },
                    { 15, 8, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 5, 28 },
                    { 16, 7, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 6, 27 },
                    { 17, 8, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 6, 28 },
                    { 18, 9, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 6, 29 },
                    { 19, 8, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 7, 28 },
                    { 20, 9, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 7, 29 },
                    { 21, 10, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 7, 30 },
                    { 22, 9, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 8, 29 },
                    { 23, 10, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 8, 30 },
                    { 24, 1, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 8, 21 },
                    { 25, 10, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 9, 30 },
                    { 26, 1, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 9, 21 },
                    { 27, 2, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 9, 22 },
                    { 28, 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 10, 21 },
                    { 29, 2, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 10, 22 },
                    { 30, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 10, 23 },
                    { 31, 2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 11, 22 },
                    { 32, 3, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 11, 23 },
                    { 33, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 11, 24 },
                    { 34, 3, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 12, 23 },
                    { 35, 4, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 12, 24 },
                    { 36, 5, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 12, 25 },
                    { 37, 4, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 13, 24 },
                    { 38, 5, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 13, 25 },
                    { 39, 6, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 13, 26 },
                    { 40, 5, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 14, 25 },
                    { 41, 6, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 14, 26 },
                    { 42, 7, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 14, 27 },
                    { 43, 6, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 15, 26 },
                    { 44, 7, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 15, 27 },
                    { 45, 8, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 15, 28 },
                    { 46, 7, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 16, 27 },
                    { 47, 8, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 16, 28 },
                    { 48, 9, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 16, 29 },
                    { 49, 8, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 17, 28 },
                    { 50, 9, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 17, 29 },
                    { 51, 10, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 17, 30 },
                    { 52, 9, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 18, 29 },
                    { 53, 10, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 18, 30 },
                    { 54, 1, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 18, 21 },
                    { 55, 10, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 19, 30 },
                    { 56, 1, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 19, 21 },
                    { 57, 2, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 19, 22 },
                    { 58, 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 20, 21 },
                    { 59, 2, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 20, 22 },
                    { 60, 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 20, 23 }
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
                unique: true);

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
                unique: true);

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
                name: "IX_CoursesSchedules_ClassId",
                table: "CoursesSchedules",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSchedules_CourseId",
                table: "CoursesSchedules",
                column: "CourseId");

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
                name: "CoursesSchedules");

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
