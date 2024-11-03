using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PersonalIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85a634c5-96bd-4435-bfcd-6d4ded65c33b", "AQAAAAIAAYagAAAAEHLRX2VXGdNSOFU/fMN/UgXhumubqaFXMgfCIFjgWJOWwllXiFhDOu9v/rrOpoY3eQ==", "de7c1a7d-8d73-4794-9b16-5539ccbc08f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "216d985d-85aa-471b-9ca8-341680c7a68c", "AQAAAAIAAYagAAAAEMecxgmf9AJf/Fr1uHzJZuTbq/21hvf6pOdy89KL7ebaQ0teQ+D7/7E86xqDSWyIFg==", "9a333896-43ad-4d6d-beac-f10d60cb05ad" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 3, 20, 53, 55, 501, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 3, 20, 53, 55, 501, DateTimeKind.Local).AddTicks(1094));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c46a8cb1-057e-448d-8efd-1fcbeb8adae2", "AQAAAAIAAYagAAAAEE3U2Oty5ZwO+s8lXl4MX/GdN9iYT/cwrUTUp3RykO04PXo4p1OoBQVCqroFoCemrQ==", "3c0bdb88-0c1d-42d0-b9aa-6b1d3abd8900" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0386494f-8b41-47b4-8ac9-cced518594b3", "AQAAAAIAAYagAAAAEG5Hq5ENZ4LqX4/CoRTiJn6S1CaBVLtLAr5YbzPCV5fJDW0/Z98ajiyrVrCrWW7ouA==", "fd7d9039-d446-4d52-831a-4442166c2b71" });

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
    }
}
