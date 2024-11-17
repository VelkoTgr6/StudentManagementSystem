using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IsDeletedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Teachers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Shows if teacher is Deleted");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Shows if student is Deleted");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Shows if course is Deleted");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f09ff62f-ef77-4563-8de7-5ed6da8635ea", "AQAAAAIAAYagAAAAEFUDH5Ka1upibrML5q4nK6ZNAlVfn9PZfVfwOvoh9QsMzsz51GG8QEYGU0RxPiGsaA==", "d1fa6a07-d1c3-4529-b9a3-99076c4ea72d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17067691-02d2-4c83-99a5-993deb85b913", "AQAAAAIAAYagAAAAEDoP4qXJGKOqromkGEZTCpVYWXjY42RCSkeycYig6URWppO0VM15T+oUewDCxnegOw==", "1f0a2079-1e9b-411c-9f36-999c1b381d33" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "IsDeleted" },
                values: new object[] { new DateTime(2004, 11, 17, 12, 36, 33, 318, DateTimeKind.Local).AddTicks(6467), false });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "IsDeleted" },
                values: new object[] { new DateTime(2002, 11, 17, 12, 36, 33, 318, DateTimeKind.Local).AddTicks(6554), false });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Courses");

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
    }
}
