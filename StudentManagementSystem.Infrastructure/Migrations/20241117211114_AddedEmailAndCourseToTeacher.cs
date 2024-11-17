using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmailAndCourseToTeacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "The ID of the course taught by this teacher");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Student Email Address");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Teachers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "User Identifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36aad082-8562-45aa-a8ed-5fb5107039d9", "AQAAAAIAAYagAAAAEFIkBCCu+B6cwIreXYsRdO0FbS6sPRT8UZZe3oXndc6vDScpfzT1Xa8eGyxxV1NwqA==", "d4991144-9b42-44fe-9f3e-8ca04336fdb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8754c5c1-028d-4671-8db1-0f2a9fb919bf", "AQAAAAIAAYagAAAAEFt5OOiwF5hJ/oNoGZZUhyre0YoYez/QLXYgO2WRBVzBzmc55XpaA7bOnnlgAr0TlQ==", "6e91c5eb-ce85-409f-8be7-e394728225c4" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 17, 23, 11, 11, 533, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 17, 23, 11, 11, 533, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Email", "UserId" },
                values: new object[] { 1, "stan12@gmail.com", "1" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Email", "UserId" },
                values: new object[] { 2, "ivdra23@gmailcom", "2" });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CourseId",
                table: "Teachers",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction); // Specify NO ACTION for delete

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Courses_CourseId",
                table: "Teachers",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Courses_CourseId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_CourseId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af3c7fb5-f2ca-4193-a2d6-56d7dd04a12f", "AQAAAAIAAYagAAAAEGzYTpr8unRzsDPpzzEwvLZWva9jv8Yl2stwlNmOvwEkx6x6TkHBfVysgYluw7qa2g==", "627ccdd7-f7da-4788-b442-8eb85fab9e55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bebe4261-9487-4f75-acfc-0a75585fa98b", "AQAAAAIAAYagAAAAEH7Q6XQ9FEd6CT6Qk3IVDGsp1eco4i+XC6XBLT4oOoDSrZLfmcS9DmZZrJe3x0Jg6w==", "6b41578c-c555-4190-ae95-c7a782d96cb0" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 17, 18, 32, 50, 289, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 17, 18, 32, 50, 289, DateTimeKind.Local).AddTicks(8489));
        }
    }
}
