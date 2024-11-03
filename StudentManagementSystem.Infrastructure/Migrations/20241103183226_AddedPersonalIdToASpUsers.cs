using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedPersonalIdToASpUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonalId",
                table: "AspNetUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                comment: "Personal ID is a unique identifier for each person.");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "c46a8cb1-057e-448d-8efd-1fcbeb8adae2", "IdentityUser", "gosho123@gmail.com", true, false, null, "GOSHO123@GMAIL.COM", "GOSHO123@GMAIL.COM", "AQAAAAIAAYagAAAAEE3U2Oty5ZwO+s8lXl4MX/GdN9iYT/cwrUTUp3RykO04PXo4p1OoBQVCqroFoCemrQ==", null, false, "3c0bdb88-0c1d-42d0-b9aa-6b1d3abd8900", false, "gosho123@gmail.com" },
                    { "2", 0, "0386494f-8b41-47b4-8ac9-cced518594b3", "IdentityUser", "pesho321@gmail.com", true, false, null, "PESHO321@GMAIL.COM", "PESHO321@GMAIL.COM", "AQAAAAIAAYagAAAAEG5Hq5ENZ4LqX4/CoRTiJn6S1CaBVLtLAr5YbzPCV5fJDW0/Z98ajiyrVrCrWW7ouA==", null, false, "fd7d9039-d446-4d52-831a-4442166c2b71", false, "pesho321@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 3, 20, 32, 25, 241, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 3, 20, 32, 25, 241, DateTimeKind.Local).AddTicks(6403));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cba9866a-3c02-4516-aade-b72b2e2ba201", "AQAAAAIAAYagAAAAEC9QRT1w250vaAynHDhFcGyHRzd0lmYWGyTJSr89vqic92QF9A4tHMb2jarWT+/Ukg==", "f4cb9d87-4f8f-4285-b3a9-f796a4fb7222" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36c4c1fe-04e1-43d4-9c8d-a1ecb06e9aaa", "AQAAAAIAAYagAAAAEN+JOwhEckuxBjs4Loj2La46/o+uYeN5FyPiaEp3DmlVCt9rmUSf64sOh6xqZp7jIQ==", "7f16c6b9-0199-4985-afa3-c181f83afdf0" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 2, 20, 1, 29, 724, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 2, 20, 1, 29, 724, DateTimeKind.Local).AddTicks(8416));
        }
    }
}
