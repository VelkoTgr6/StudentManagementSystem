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
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Teacher Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titles = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Teacher Titles"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Teacher First Name"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Teacher Last Name"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if teacher is Deleted"),
                    ContactDetails = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Teacher Contact Details")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of birth of Student"),
                    ContactDetails = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Student Contact Details"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if student is Deleted"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User Identifier"),
                    ClassId = table.Column<int>(type: "int", nullable: false, comment: "Class Identifier"),
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
                    GradeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Description or type of the grade (e.g., Midterm, Final, Homework)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier"),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of enrollment")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "af3c7fb5-f2ca-4193-a2d6-56d7dd04a12f", "IdentityUser", "gosho123@gmail.com", true, false, null, "GOSHO123@GMAIL.COM", "GOSHO123@GMAIL.COM", "AQAAAAIAAYagAAAAEGzYTpr8unRzsDPpzzEwvLZWva9jv8Yl2stwlNmOvwEkx6x6TkHBfVysgYluw7qa2g==", null, false, "627ccdd7-f7da-4788-b442-8eb85fab9e55", false, "gosho123@gmail.com" },
                    { "2", 0, "bebe4261-9487-4f75-acfc-0a75585fa98b", "IdentityUser", "pesho321@gmail.com", true, false, null, "PESHO321@GMAIL.COM", "PESHO321@GMAIL.COM", "AQAAAAIAAYagAAAAEH7Q6XQ9FEd6CT6Qk3IVDGsp1eco4i+XC6XBLT4oOoDSrZLfmcS9DmZZrJe3x0Jg6w==", null, false, "6b41578c-c555-4190-ae95-c7a782d96cb0", false, "pesho321@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ContactDetails", "FirstName", "IsDeleted", "LastName", "Titles" },
                values: new object[,]
                {
                    { 1, "for more info visit ...", "Stanimir", false, "Grigorov", "prof. dr. " },
                    { 2, "gsm:12345678655", "Ivan", false, "Draganov", "doc. " }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "IsDeleted", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, false, "10b", 1 },
                    { 2, false, "9a", 2 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "IsDeleted", "Name", "PublisherId", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Best bilogy learning system in the world", false, "Biology", "1", 1 },
                    { 2, "Best History learning system in the world", false, "History", "1", 2 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "ContactDetails", "DateOfBirth", "Email", "FirstName", "IsDeleted", "LastName", "MiddleName", "Performance", "PersonalId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "GSM:0881237865", new DateTime(2004, 11, 17, 18, 32, 50, 289, DateTimeKind.Local).AddTicks(8406), "gosho123@gmail.com", "Gosho", false, "Grigorov", "Petrov", 0.0, "0230456078", "1" },
                    { 2, 1, "GSM:0881237865", new DateTime(2002, 11, 17, 18, 32, 50, 289, DateTimeKind.Local).AddTicks(8489), "pesho321@gmail.com", "Pesho", false, "Ivanov", "Petrov", 0.0, "0140656070", "2" }
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
                name: "IX_StudentsCourses_CourseId",
                table: "StudentsCourses",
                column: "CourseId");
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
                name: "Grades");

            migrationBuilder.DropTable(
                name: "StudentsCourses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
