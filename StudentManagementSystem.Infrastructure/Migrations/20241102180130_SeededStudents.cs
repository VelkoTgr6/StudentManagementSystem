using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeededStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "cba9866a-3c02-4516-aade-b72b2e2ba201", "gosho123@gmail.com", true, false, null, "GOSHO123@GMAIL.COM", "GOSHO123@GMAIL.COM", "AQAAAAIAAYagAAAAEC9QRT1w250vaAynHDhFcGyHRzd0lmYWGyTJSr89vqic92QF9A4tHMb2jarWT+/Ukg==", null, false, "f4cb9d87-4f8f-4285-b3a9-f796a4fb7222", false, "gosho123@gmail.com" },
                    { "2", 0, "36c4c1fe-04e1-43d4-9c8d-a1ecb06e9aaa", "pesho321@gmail.com", true, false, null, "PESHO321@GMAIL.COM", "PESHO321@GMAIL.COM", "AQAAAAIAAYagAAAAEN+JOwhEckuxBjs4Loj2La46/o+uYeN5FyPiaEp3DmlVCt9rmUSf64sOh6xqZp7jIQ==", null, false, "7f16c6b9-0199-4985-afa3-c181f83afdf0", false, "pesho321@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ContactDetails", "DateOfBirth", "Email", "FirstName", "LastName", "MiddleName", "Performance", "PersonalId", "UserId" },
                values: new object[,]
                {
                    { 1, "GSM:0881237865", new DateTime(2004, 11, 2, 20, 1, 29, 724, DateTimeKind.Local).AddTicks(8329), "gosho123@gmail.com", "Gosho", "Grigorov", "Petrov", 0.0, "0230456078", "1" },
                    { 2, "GSM:0881237865", new DateTime(2002, 11, 2, 20, 1, 29, 724, DateTimeKind.Local).AddTicks(8416), "pesho321@gmail.com", "Pesho", "Ivanov", "Petrov", 0.0, "0140656070", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
