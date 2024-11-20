using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedFunctionalityToStudentWithAddedAbsencesAndremarksClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remark",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Аbsence",
                table: "Students");

            migrationBuilder.CreateTable(
                name: "Absence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Absence Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of Absence")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Absence_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Absence_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Remark",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Remark Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RemarkText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Remark Text"),
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier"),
                    TeacherId = table.Column<int>(type: "int", nullable: false, comment: "Teacher Identifier"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remark", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remark_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Remark_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Remark_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "557b1859-f452-4ff2-b7f5-a1eaf680794f", "AQAAAAIAAYagAAAAEHaEQenrB4jK8yrRLCOWY1n0FkxBrWA6z5cdB8co/nFDyutV7lwuk24ckEmKnAcmPA==", "b260cf49-e6ea-4385-8568-16751c2e3cc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2022a2d8-6ec2-4ad6-a14d-ce7a0a13128b", "AQAAAAIAAYagAAAAEG4Uq4q3gjxWD+RAkKNqDQ6390DW6mnpVEbP8QOTzranMmdyLxKylFEdJmTnzcR6Ag==", "909d78d2-cac5-4abf-906a-d7a4cc0991ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "024a206d-89cb-4eb5-bec1-3494a6c6877a", "AQAAAAIAAYagAAAAEIfNQKff83hwjgK/AbSgwRCD2ZQZhcwy5a581LuaY94nkKIz9i9m2ZEebMxPZ9f6rg==", "60d2e3ea-9acd-4617-8bfa-739933fd83d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb912b72-d1b7-4938-bae6-44a243b6a965", "AQAAAAIAAYagAAAAEHcX+Zhkz3S+Xpf0apmBUYxSl70r/Na7CGtzO/zBzFpAQmugDHiTENDuQP1orKTPiA==", "3d6a08ee-2f0f-4f65-8490-aafa19fedcf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69a8a2ed-f9f1-452d-99cd-c37cb601f241", "AQAAAAIAAYagAAAAEChnnoLlvHtz0h5kJ7xHO0cNxZAY3Q+ky9yRrX0a6cs0hwR+b9KMkC7Wacy7atPE2g==", "de29f68d-5bca-4627-b39c-8322a91f3b76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8e23e6b-09a0-4c0f-9265-dc8d4b3d584a", "AQAAAAIAAYagAAAAEGfKj4GXunT25frYlNz4l9XqmjR6JR5ykrMo1YdiUgnClpX6/+TD9Z9sJMHPQ5c9nw==", "146d10e7-3c47-456a-a9c7-843b61fd3b11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f52168a9-7dce-49a6-818b-f839f622df11", "AQAAAAIAAYagAAAAEKYy6b7CFK/CjABISK9WXxQGlrPg+BFRYFgP7K/TFVbJFpEv+NmY9MTbUpAD3y0R1w==", "baea1c39-a1ba-4cb8-a486-4b7abd94ce9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2983dad8-23ba-4a00-9826-d0bba7bba88e", "AQAAAAIAAYagAAAAEPtJp7B38MiRjNbHXV8eNcl6w4/JzVczAB83XZ274VxBK0Y06XavZORp3kqeJf1sIw==", "30cc937a-e88d-4b63-9251-aa94c2295b8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d97732ba-0d90-4e5c-8ead-d55f0dc026ef", "AQAAAAIAAYagAAAAEP6zwhAPjLtqLT8P0jDZQON1dvTRJ3UJSBbO0yPyUCxnXyyz07OOybhnu/gfv4pjwA==", "86bbd1d8-c597-4f34-8cc7-8abcc0790d27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f161ca1a-eb9c-4061-bf2d-b87d6e043caf", "AQAAAAIAAYagAAAAEDGg32beyfyI1m/BG6ntb0d8MKkzY6ASelDF7lK9oKLc+hsmecF10oc5X4yfChZzTQ==", "18d5690f-8153-405c-ae0b-5eb025020005" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb6502d8-c886-4285-afe4-d704ece5ea40", "AQAAAAIAAYagAAAAEJkZpkmEGt2Day3lUZceQSknG57m/VRQJip4VtrfyTyBY69vqiHJtG1lw4T2QeDoaQ==", "ea975afe-dcbb-4b70-9cce-d49f21149a60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c039f3e0-6efc-4075-bdcc-de31285649b1", "AQAAAAIAAYagAAAAEALOIm5yXf4YXpe2c90mV3VY3WiOi24omog1e8VuXsVqHXQDUmRzS2WG9PItSyMcaQ==", "843a5b9b-4411-4dfd-8a32-d41e81cee4db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c028ae7-782d-4412-ae77-6f4e83eb2e99", "AQAAAAIAAYagAAAAENCfvYTr2ChcVHGYdRnoWxNHKHeIOusxJ0w2WNP66qjAF07hdt28OYTYzvT5cwmqWA==", "8843ace7-d1df-45e3-8311-852294f61c29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70a38e90-002e-4657-bdd4-892b42cabcec", "AQAAAAIAAYagAAAAEG38D80ncgwuPg/szMjs9i478Wx6MX26nOT3AbbgMYDCW0PC2DVihJQUtVHVpm4HDg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "978168da-5f0b-415a-98f5-33043506fcd7", "AQAAAAIAAYagAAAAEFRSunmGOlX6Z7jxaPvtawIqIDjXWftb5F6VgkpBBCYmqxyBROZsW04hQWKb4P6bbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7d0a2cd-0e92-45a4-8a3b-a7cdd0c4e5e6", "AQAAAAIAAYagAAAAEJJi4///7lDJNF+xKy5Vxf4FNFCLuq67bfrkQT7TUST/3NJfl54/lw/7Me18QYk+iw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b1e9907-53b3-4911-bbd3-6d9044fa3051", "AQAAAAIAAYagAAAAEKwNrI9x1QG7xJjx/idN6jsm23NNGsshQF0AbcyZinDh6lBmrwuzFk73dtHtFC8Z0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8e30ced-3819-4a56-85ef-0d9f527b4929", "AQAAAAIAAYagAAAAEOC8/90RS4lj0/sLsoKi2w3RAfmiw7ZyEqYsdwDtcnIreWWqS8MCpWps4iQo3IVHWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2907252-6dab-4f40-b790-840a27fa6f44", "AQAAAAIAAYagAAAAEJyKlW9Vvcx6jkcSbIGmFqklnKewVsEjS4jG/z7Gt62QraxJBKxtNAmAJ+GfnvcGQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acab01fa-b31d-41b6-ae11-c24f5bf49598", "AQAAAAIAAYagAAAAEKOAGgfBH6TvE0hok+eq/4+xB23yO9zpz2iWaK/PDsvo+HDAy5z85n4cKE3S4A5Vtw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31262217-18fa-42f0-9e7a-4cfbbd5b5bae", "AQAAAAIAAYagAAAAELCZp5hbryh3msA+niA1OeQdpmeDE836O2Pf25Gy2Q0VRj+xcGLXU8NGlbVzj0QUnw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1607616b-69a2-4c78-b3bb-1d4bd150b9a1", "AQAAAAIAAYagAAAAEG1L+6bcjZoWK1xM/cHe+kpjF8gal5jdblT6pVVNC5R5mER7ohd/EYtDC2DuY4qiUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38c208c8-c443-480b-80ad-ea14ad031060", "AQAAAAIAAYagAAAAEDP9yXoZGUMVZ0CF4d33GTlWSun6n/b/lmi94Q/8BjBiiXLyuO/QUKuclkP6wJEHcg==", "66fab974-5843-4eb8-a7d6-5186b93ec597" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ec2005d-d831-4557-83b3-bcd6aaf12098", "AQAAAAIAAYagAAAAEPIOBGBaIELWr4OajHfbRdtBseTmKdYnulYteWFAHjlshW5AwSmQ619jI/97JpEZFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ede6c227-5f82-4818-b27f-6c42f995ba08", "AQAAAAIAAYagAAAAEIT0SihyY3YI+Skto8eun1gU5Z5jdoQuAC3OvGXB8QKdnmtvXK5ZCvEb/ThVlFGgRg==", "014f1cc6-ac82-4758-a989-71a8c4659fcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd9032e9-8de4-4471-b936-3e72cbd893e3", "AQAAAAIAAYagAAAAEP0VdF/kV/FEduww63u7DYuIuOlQwjO0F8OMP0skvurbU9k95Tb4z7LC9D44ZLvSTA==", "c6d47eda-8cdb-4166-b471-194a0067cb0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f3ed64c-1b5d-4172-be2c-73bde2187657", "AQAAAAIAAYagAAAAEJTG/pcBjRGy913VUi67YYtyJNGONROP5JnrE6xQW3fjYcblmQ3aqsQ5a4NcEjH8Lg==", "435dcd29-b3d7-463f-82d2-cdbef0d15336" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7978bb87-150b-440f-a653-b95acad33a31", "AQAAAAIAAYagAAAAECUnCej6TWZ3eNRScGlFAZW4d/D2+7K6WHtJYFnZrG91xsPUzHFFLSJhUZXCFpC1kw==", "ed1666b4-bd99-45fc-b12e-9c06a91bb34b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84ab402b-fa54-47f3-865e-f3acfeb66310", "AQAAAAIAAYagAAAAEMssSytHq/w0lmMQ/e9idk1885PscLFzmDOU3CQ8i9i9zuFUTDsG3IcFXJdH3PZkrw==", "6ba31dd8-2501-46b8-a2f8-d7fcaa3da504" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f911408-d58f-48ff-b777-6361d0ece5b6", "AQAAAAIAAYagAAAAECmMkPmSUPRyBbSNc26CzLiJk/zCS6O4n9mbcO6nKhJjzAhDIpMrT+uHKuP0Yvnh7g==", "99d96230-242b-4582-8ac2-e0ae9b18ddc9" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 20, 20, 27, 24, 899, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.CreateIndex(
                name: "IX_Absence_CourseId",
                table: "Absence",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Absence_StudentId",
                table: "Absence",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Remark_CourseId",
                table: "Remark",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Remark_StudentId",
                table: "Remark",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Remark_TeacherId",
                table: "Remark",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absence");

            migrationBuilder.DropTable(
                name: "Remark");

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "Students",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "Remarks about the student");

            migrationBuilder.AddColumn<double>(
                name: "Аbsence",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                comment: "Shows if student is Active");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "465d045d-e248-4ea4-aa28-dbbcc505721a", "AQAAAAIAAYagAAAAELHrSX0sxbLPJg3ET2UUyzG2CSYwnL3v9Y8BS80ZECZ5D6btYd2H3DaZiNKmPn5Deg==", "673fb029-0c84-451f-a6d2-f3eb9b7c763a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22420630-799f-4346-814c-315e23fa5baa", "AQAAAAIAAYagAAAAEB37JrzMRrfZO+WWpujpHEx0TmvLKNrssdYMRJYik0kTkzqVubpUlnWDPQ86qF/ogw==", "f80b343c-bed2-4bb4-8396-866da19e9926" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30ba4375-e977-451e-80fb-a885b258a26d", "AQAAAAIAAYagAAAAEPTXRX+5VNOoa27Zhi48q7nyVcelxRoec0vvUgWxVD9zj4xJjxLH0LN0fHzqhm0olQ==", "17bc388a-d85c-4604-ba81-7088a09f6fa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2cc22b5-6319-4f5f-829e-7e978b80f0fe", "AQAAAAIAAYagAAAAEOdX7j+eQ/+7rqG8OQMrg9mTCrShgwiNedxtL82vAGIy54McaBCoVC8JqSEj+d1amA==", "7915a03b-5cf1-4ff9-a4e2-42bdeb14a2b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71bbf25e-549c-4d19-b1bf-6a11394a62e8", "AQAAAAIAAYagAAAAEBzijO3mkfli5Gp7tb8fVMiCxrd4zWglvRmF4vzhYTLpfqA98RJmD8a9RXPm5JtPKg==", "b98977af-140d-4406-9b7b-e462ac3999f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e36e497d-d3f1-48dd-87e4-981672c833b6", "AQAAAAIAAYagAAAAEAlrf1/tZ5OCnxHEKTJ5Neo3yg1NaCH+9RwBuLiUMdran/nzhO4mV63IvOv7QU3qZQ==", "21ccadb4-39e8-454c-b967-1f1105987357" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6017bb07-50df-40cb-a491-659d77763d06", "AQAAAAIAAYagAAAAEBW47z5qjNuqXua3mxj46YiC0w3GoqhyjYnOG+dnEI2mWwrIMTdEjYtpoEO70XwsEg==", "f572cb2a-7c0e-49cc-a29f-432c4fc7d8ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b25ec2d7-c0c6-4820-b296-8926071087e7", "AQAAAAIAAYagAAAAEKm4rMPCyBl9/xeVSPqyExAet6dBNnkGnAVp7ul1Le1NTOM8IgF9tFg9EVYyabXJvg==", "5cb3bf82-4436-4be6-afe3-c3638a3fa652" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d64e3cbd-0faa-4d13-9f81-bcd5add4834a", "AQAAAAIAAYagAAAAEBvNWWYRO1JhI/CQASd7gGxz55njySH4iS4fHD9YHJhkl/eJBEDoI1QXQDrtkplbwQ==", "3d7d5b88-d022-4479-8902-edc9eb2175b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "069d615b-e4e8-402f-98f7-7ebbac2a1592", "AQAAAAIAAYagAAAAEO0Qcm9OTjiX+yQrx1eGtsjBooAwZviYtu2+7p6/zGAX4ziIBmqyPRd1Ulou9fC38Q==", "b50f4043-6705-4101-b829-a24e76dfe73a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0dfda5d-27ee-4609-a816-cccc47ecfab7", "AQAAAAIAAYagAAAAEO+Tk6Gc2nJJyP9ue6170o0Jekw3dDeYc8x5J3wdIvORuj1MOVJyXy5RPJ3sUWnp4w==", "9599a599-9b5a-4b39-b1fb-94f094ede191" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0815301a-6b72-49df-9379-0d08acbc549e", "AQAAAAIAAYagAAAAEG8aTGmiSZU53u1h9XZ63UK9YLJiATaNT76UhInHTkgFWYqkFyGzysfjooTa/UfntA==", "c8ccc63c-8c85-464f-a15e-d47429a66058" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2bef8f2-9033-4e0a-ba47-75a1d6645fc7", "AQAAAAIAAYagAAAAEO4Q27INihRqaphnIZO+ABUWclvWU0OhiVGqgZilorB3y6ZKvaH4joZfloFZIdlIfA==", "6265a54d-c3ac-4389-b469-8bf4770b6a7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a39e8fd-5650-4dd8-ac79-1cd0dfe0803f", "AQAAAAIAAYagAAAAENuTUXe4SxEhur+AEADLskC8B/HWWza1/MxPhPyEQ8y2o57eDeXueczDTzXE2/tHmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55ea6fec-c087-4beb-be3f-585120e88c12", "AQAAAAIAAYagAAAAEI+wdLqE1lgUYkCMJ59lI8B9GJfhij1CxpFdmJHRiup9UoOObEBG/isQBC9O0/U9pw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c93797a-5208-4395-899f-1cd0459fe897", "AQAAAAIAAYagAAAAEDQzMa8z2uTl02ce7aV5ZecHtN5WcacqCVJz8v0X0LhqFLKJGM4nPkOAFqpiQ26TBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71164e91-c0af-4621-ba30-6d43919b2bb3", "AQAAAAIAAYagAAAAEKsg6bdPKZvSTbat9S8kCbCEg4SWzkRY9IScvg81iptHmFrc4YG2IV5doyKveXG/Tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "413d704e-32fd-4c39-809b-f67bd477bb4a", "AQAAAAIAAYagAAAAEPzlsNBnSKhgxdYKar5lfZUqxJBNDjeTLoxNin69Do1aFYzYhqyVHYWWU0QsdnwWKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b03beef-7747-4a9c-86ed-e355142f1925", "AQAAAAIAAYagAAAAEGMpUC3FdIYedxazctIq3Py81GtrapPOkEamp3iQak6EjvvNdn/rBTf81R01BxYE8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1d51a57-248f-4e2d-8992-0c62334d4e17", "AQAAAAIAAYagAAAAEPLb72xKAiJCnsj03EhEn/2VTkeHt7/0B/LCrnUirGnCYFQJruVhxYJ5WZL/4g01SA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af6623d6-5fcf-492d-b252-ce3eae7af050", "AQAAAAIAAYagAAAAEKzYCbhHVCLcDIrzozwXGlI2ksYF8FxixEV8tWYBPi8MeMwG9rpr49Pp1vU8ZUHGMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfcac21d-013e-4c12-835f-6396c5abc9d0", "AQAAAAIAAYagAAAAEIujUMT8rdeMXUKk6Bjt2DIR76I/rXmqdjipPDFBS4K8t1JRA+zBWthRwX03Nx4ynA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d52d0e24-c1a7-47d7-b422-9313003dcbd4", "AQAAAAIAAYagAAAAENvy5eOymlsv3yFpu/ACWOYgxuB/qWMMT8SVkWLDmje4RaqI6Up7Z7Sbb09MQHt7Nw==", "71bb5d7f-6098-4f17-a052-78e3a8b04c28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d8e61cf-1459-4bfb-908e-ac31e7ac4ce7", "AQAAAAIAAYagAAAAEEKhQ5Hyeq7aMT3+/S+1Q+2jxdliUxMackI2ykcNdRRZpv8fhfojjyYlELSmokWRvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9c878c3-2e03-4efc-b74d-6699692c8dff", "AQAAAAIAAYagAAAAEK4JctkzDhgNaj3KWt/nucv/J6ADbC4q6pW8dbBpv+ubNHSWl9UtphjdrE+CFT90RQ==", "4fe92041-94ff-4357-ab01-767aed3fee90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32febbf0-d79c-449d-87e7-7eb314921463", "AQAAAAIAAYagAAAAEBTARElucHXvam7vRe7Jyrm8EimudugByciN8HdxpVrdu04mo9s3V0FjEf/QKJw6gQ==", "f8037f41-dde9-49e3-afd2-b9c8e03ca73a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc0a6d8c-5d1e-4ec7-b166-526f52dee6c0", "AQAAAAIAAYagAAAAEA9ynP4I3DDU50e8nGvWMeGyflPqA/OSf1oUcTgpGqFT03jTid7yiSUvP/7mzZBvCg==", "4206df03-6ba5-47b6-8c00-fa7ddf2bd5bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f1a048c-ded0-4a6e-8526-3b1002695e2d", "AQAAAAIAAYagAAAAEEtreY3DH5quxHoVbelifVj7VBtLZhcLDmvDc9FoiC1zD5miW3687lK/d/JTt03mJA==", "f45af3bb-fddf-4eea-87ee-5c03680e54b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9904ad01-e303-4952-a815-5c73d2420a8f", "AQAAAAIAAYagAAAAEMMMPJtJIVk5QWI0mjy4OX/LQVtpwH+RSyz8bmk9ljuvjUsXGJB/JDvti+SEC+crew==", "7987a3b9-c605-4686-9211-6c2ea9b7e855" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca7308d1-fd7f-4fa2-8cba-0a0f2baa0438", "AQAAAAIAAYagAAAAEAg8BEFeC/uArHDmKHe1/Kgbhx5BGKEQ5QW5yXVqaBw5WQnQVFjZScXfDI2TeaoSyA==", "739bd31a-1669-469f-908e-565fdee18cb7" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1669), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2007, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1775), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2007, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1779), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1783), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2008, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1786), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2005, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1791), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2004, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1807), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2003, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1812), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2002, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1823), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2001, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1827), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2004, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1835), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2003, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1839), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2005, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1842), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1846), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2004, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1850), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1869), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2002, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1873), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2003, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1876), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2008, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1880), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2005, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1884), null, 0.0 });
        }
    }
}
