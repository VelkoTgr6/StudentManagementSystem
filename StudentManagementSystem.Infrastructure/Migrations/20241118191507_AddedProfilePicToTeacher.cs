using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedProfilePicToTeacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePicturePath",
                table: "Teachers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                comment: "Path to the profile picture of the student");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd9460bd-d32c-43e8-9428-7835df05c0cc", "AQAAAAIAAYagAAAAEMz+Pc1+ZhNFG6peqcXk4/zDwq4MF5chVeKMky/HHk+hy0nFdKXpxguR7gt8TAylgQ==", "02995e4c-421e-4461-9dcc-d76060091dbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c2a5895-afbc-484c-8a8c-c60a5661b65a", "AQAAAAIAAYagAAAAEPebuDDs/fsTgFNOp+a6/zktCq6Pg1E4opSG3jIL2mFKt+BaeMF7yp9VK0xWvFJGJQ==", "94b0c24d-a8f4-4286-85c5-d8caf318cedb" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 18, 21, 15, 6, 830, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 18, 21, 15, 6, 830, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfilePicturePath",
                value: "images/profiles/default.png");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfilePicturePath",
                value: "images/profiles/default.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicturePath",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69d55643-d517-4412-b0a6-2c501dea7416", "AQAAAAIAAYagAAAAEK8GaWoKFz93yEglW/O2JMvEw8ye5KabGkkPOMnUDvHr85roC9wQJZKWIysB1OFU9A==", "eda3d778-eda8-4c84-856e-62b3d5b1a9dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fd49f65-7b88-456c-9c9f-792a2a826c50", "AQAAAAIAAYagAAAAEC8aVvUEHMh3KN4dHsZOAgTKQZ/fxEZDw7M9hacvHEo2OjVSnUkoeSS9GTgZEXJdKw==", "26269e73-b1f6-4f29-a62a-c609dc29ce1a" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 18, 21, 12, 25, 878, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 18, 21, 12, 25, 878, DateTimeKind.Local).AddTicks(6587));
        }
    }
}
