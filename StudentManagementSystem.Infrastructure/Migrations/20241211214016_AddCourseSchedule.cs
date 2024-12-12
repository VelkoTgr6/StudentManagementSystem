using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "CoursesSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Course Schedule Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier"),
                    ClassId = table.Column<int>(type: "int", nullable: false, comment: "Class Identifier"),
                    Day = table.Column<int>(type: "int", nullable: false, comment: "Day of the week"),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false, comment: "Start Time"),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false, comment: "End Time")
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01185cf1-525d-478a-ad05-b9629573333a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9735849-17b7-4b68-99de-5e16af5d8ee4", "AQAAAAIAAYagAAAAENDglC+loZQPOyb7SUAGhRdtrtPs6Jf1n5elF40j9zx9Zj32JZRHTgIzZ3h5O63rDA==", "fb7fd78b-942a-4585-9571-10408231f0f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "030ddabd-7dcb-46ca-bab6-3feeae3492a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5ece589-b50e-48b5-88ae-d59af6e55b46", "AQAAAAIAAYagAAAAENUdSkomZFYTn4GpvQEPEMy71C71XKFLj7JHPZSDJMu7c1pQW53oYhJGSf1JxBzrZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04b6c6b1-5f9b-4c7a-9f42-86193c03d327",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bdef660e-d07e-4b2d-b5e4-2b6fd11ca8b6", "AQAAAAIAAYagAAAAEFbJ0kvsCxF5bqWTy7ZUDcYlbKOguKPq0Pca/c+UTXFh6bWY5cDeqS+A3jvSQpPDNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4b8988-22f2-4ed5-8486-85e757a97e41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3e71c85-d230-4c2f-957c-9a562f191c11", "AQAAAAIAAYagAAAAEOO036DvHY9xKax4Fh/r2daQcfIb68IW6EoDORS9hMfryZlBoQHGrkVAyU2y921LcQ==", "ee03ec45-a9a7-43ea-b952-21ae2febbf95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a688e82-f609-47af-a359-d8bcdd62b5e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea1228d7-845a-4075-a81c-c6c764c0ee2f", "AQAAAAIAAYagAAAAEElkQkhlPVa1qpb4F4KXW6HZ9bglXurz5FSPACPvdSxbxxB8GD5+yDB6GOY/9cGvmg==", "a865a551-214c-43cb-a83f-804dcdb9386d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "217e3e65-026d-4a8e-97af-a4fb30dfab30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bd8d7ad-88f5-44c1-921c-ac680b60346f", "AQAAAAIAAYagAAAAECYdFU/QJJ01hwo3+ZzcYTROsx4gkJENYZr518liCMDK+7uA9GdHaUTtfpInRyWZmw==", "30a49595-9a44-45e0-91a9-641077f5e804" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291cc1a8-8f2c-4f48-a919-ff4d9692a859",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7cdd0333-c250-4baa-bdc5-46b5f8b3cc82", "AQAAAAIAAYagAAAAEECf8YNiB0n4vmkg2J3cC/3t82y0nfZUts1tKLbiOdcF6G0ZdCX48Zt42rbEKKaQUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0408c898-c357-4d64-a041-04ff4296d271", "AQAAAAIAAYagAAAAEK7zO3wfbkoGGLV6PlnNKtI9dn64yle86JZzrbeanzXdN+WWUlKwMiuaYiAw8Xnrfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e830c43-2ce2-462d-9880-be8aa1e71696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86777ae3-3c55-4cc8-b41e-4791ef03639a", "AQAAAAIAAYagAAAAEGZsQNPZd2byGA3bJEnAFHnb/dpXT2VFyaPiNqvEYMespk80IpkFZmhrK/vLp0ueHw==", "4c5cac00-6b72-404d-accb-82476963cd17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3034c6c5-e1f5-4655-9baf-079f41605550",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35dec442-c515-49c9-88f8-c677d1820b30", "AQAAAAIAAYagAAAAENrq2fHZI+0tObZhD0agGjegT9WsiNNZ9PJCuqVSp8IgRpYQMjhme+AGwKc+WBhfhw==", "bff7c245-5129-422a-9304-4ceb7b588cb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "325092c7-9882-40d9-854b-32326c2bd43b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1517f73b-53a8-49f0-b448-5daf08a9d366", "AQAAAAIAAYagAAAAEEdt3/ks6EKXdAkNmjpIRcvfDofmiE0jaZpRdwpGIDykad8rrtNeP3rSZCwWUHv37g==", "b6d79182-feb4-44f5-b267-ef10196302fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32739a60-8250-4178-a19c-96d90444ebd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b66e8890-92df-42d3-bc7b-4cfaeb008579", "AQAAAAIAAYagAAAAEL3kRbTehjaFMWkY1xrOh2Um1g7RZVdBtzyyD+uSM95lFQd1ell/tvvPApE7C6qAig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331d08d0-d407-4d61-af6e-1bb134ae7998",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2365b58e-3996-4196-afff-fe22d9e20917", "AQAAAAIAAYagAAAAEPqM4zHCXnBKYhum7yyY4BRjtzrwTSp9smzBY3fJtKU/ts+G3SzoeIv/qln7b4YOZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b9fe69b-3365-4e4b-93cd-4937ffd4459f", "AQAAAAIAAYagAAAAEBUHFbftkNGHCVZL+RzntVKkaJUP3uVwsdl28Py+INu5qgUJpyhuCXs7hrxRr133nQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a76fd9d-a1bb-48f2-9626-1122ecf2d797",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3442ca5-6fe1-43b0-822b-d6f15f088433", "AQAAAAIAAYagAAAAEC/waosCmGlW2I4vEWO7L/8iBTbTIdrSvOnB83WlZe0CDcT7zn6bhqT7OOnRSKAPug==", "8e7f848f-2e4b-477e-bd64-468b55533373" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51065229-23b9-402f-a54d-00bb813d6b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a55e2b0e-07cc-4019-9b9b-3b2ef6486ddd", "AQAAAAIAAYagAAAAEEtbwgvrWvC8aRe1boJzXZPq8a0KbJxlYiLxnrQo8Dl2kdeWBprowgJ6ikTuHpDkcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b6433a7-3564-4cba-ace2-4a44afca4177",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da53eb47-ed29-42fd-9e04-356a9d46ad83", "AQAAAAIAAYagAAAAEKjUq2vVSdx4/1KRjaOnKUs7eWIxRgfZT0dh16VFo+9aPD90TnouOybSNVCiaSdZEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8eb86d7d-02f7-477d-8e6f-539d7c155930",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b549df07-47f8-4c74-8743-7a428de33ad7", "AQAAAAIAAYagAAAAEHRKXvxYfMk6zV/d8A+cEuTV+tSLf3VkED1PxhzeUKBkdy3rMazo1+X1xKQJwLVxYw==", "4ff63f36-c4d5-4e6d-afbf-6548b3f63a73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f7bca8f-059f-4750-8bfe-7def13ef37e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c079519-dff4-4164-889f-f7182dfbbcae", "AQAAAAIAAYagAAAAELO90toL2rKbwjCieRkPXd5l/bIw0md9VQBGnRJMYXWK7Sd/wT20ZUZn2yfmJcLqbQ==", "f072b324-e567-4eef-8be4-c78dc4b71f60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab8c775-88c0-4dc3-b11d-178c3ca2129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da456284-7d9a-43b7-b210-40e2e8faaf4f", "AQAAAAIAAYagAAAAEG6SEq84c10TIfo6CwoauM9bw5us7XPkeGNSSzuP54T9BhWOhtqegId3MBXHvCIQlg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eead06e8-029e-4ed6-b562-0e2cb3e55ab5", "AQAAAAIAAYagAAAAEMLDnq49Z5cWQmn4d7/7kXFMoV049QSOUH65EXXH033ww4Lph6XdU841vHgw+Q5YbA==", "3e451559-247b-45d7-9082-0024f483b1cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab696b9f-f5d2-45a0-8495-96e2d2a01acc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47e9798d-c883-4cb3-b6df-dd88bfc74cef", "AQAAAAIAAYagAAAAEEG+WvSnTMd4rR/t1qz0NFuf5MOPD0d9eQwGFGWEUgebbJi8SrC9KSp0yEH3kR016Q==", "ed22af25-6b0c-4b6c-9db1-a1f5f15f3bc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b65e6163-1454-4164-9869-2ff822f9da98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ceaeb7eb-4fcd-4e7f-9b33-705975812b14", "AQAAAAIAAYagAAAAEPMbo3zRTm774dCBUcfKZT3RZCPpg/58Q6jpP6l5UbyL8ktAxpNckozwvgWNfEuLcw==", "64b93f04-fea4-4494-81e4-6fd79c0d1b58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce23eb0d-12b9-4981-9af4-bf8e2ae0aacd", "AQAAAAIAAYagAAAAEOEhHznFM7Ey1Bn4S33qWxxwTe36bmX2KRPVPOhBWP1Hx2fNyCoIXmf93w5ymiv0fA==", "e7b4c0bb-b390-4528-af1c-088919a5920f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4dc51ae2-b8ad-43e5-990f-4c5f332c7e8a", "AQAAAAIAAYagAAAAEC7ZIXKzgvssXPc7MjqBxgaXqKb0xw437YK1xRzke5Z4xcBw1MaBqTNH/YJrQF8saQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5d7d80f-08d5-41ec-892c-30833098c047",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f8dc9a4-a94e-47aa-867c-f78ea7eda692", "AQAAAAIAAYagAAAAEHQRIioCexur6mYDZ3IBoWrswz9PYoX6NL1CP8hMST3afSy/n62zyGOeDM/GcxxYeA==", "1edd5618-a437-46cb-8a07-797231b442fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c64af0f1-3716-4e30-b5f7-b0c5153e2b01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1a7ea85-34dc-4274-a87e-38c74a046b76", "AQAAAAIAAYagAAAAECKwdY6V59ljFdD63hG/LjN/2TXEcfGkvmy2BhRKVkHPftjioyd3oSgtUwf2klzkXA==", "ac5c60d3-bcae-4170-9fed-6e2420284445" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cab3584a-da3f-4858-a65a-3f7bde9e553f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9360f048-7c5d-4919-a79c-e87b4337cc53", "AQAAAAIAAYagAAAAEGk0lYPqIQ0lRtP0yyEasm3nHCK+WBJevOFYwUK/U8LDbk+fP+LlVlLRF/NwCqNFug==", "35e13c4a-7cf1-41c0-93b1-2ad03578cf05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0e396e6-53f2-40e9-8013-664b8a8dbd46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "419d4cc3-b1a5-4de1-b716-bdfc6d80a00d", "AQAAAAIAAYagAAAAEL9h3QjSbshj9FlZF1Y5JHwwZaOAx1zp7jctX53k+BDSQ0B8nqB5QQcWqUjF106/8w==", "7aa89003-4189-4708-80b9-e44864cf3000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8264a26-ea76-44c4-a013-12759599a081",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1e56204-4a65-4ae0-8ec7-93cd102fa383", "AQAAAAIAAYagAAAAED9ZZIoYFCRKFOX18NPusOO629gwlZkv6Urut3jtWT4GlJazYhHHBkxyzXQI1OIQiA==", "45cd7d03-885a-449e-b960-f685e70dc565" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2875100-0cf1-4b1d-ba91-1dfa38690f84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65b126db-7971-424d-9b8b-8176752815cc", "AQAAAAIAAYagAAAAEEIHUxAZDUlrI9GGAwKWewfGtwMY2RPIUQFOtIXWw+3dD9ZxaAwbzZDZjbjaSt50pw==", "f4538cca-0998-4a4b-9567-ce17c32c888e" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 11, 23, 40, 14, 114, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSchedules_ClassId",
                table: "CoursesSchedules",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSchedules_CourseId",
                table: "CoursesSchedules",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursesSchedules");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01185cf1-525d-478a-ad05-b9629573333a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40bdfb6a-e787-4a5e-aa75-5056dce082fe", "AQAAAAIAAYagAAAAEOoHoSBqZAHVXMSw0aLHeUx9y/IbbJC/cFdjUY8tyo6q1hqjeluBUZhYeqvV7U2vRQ==", "c367c63f-99dd-40c7-be3d-60aa20bd4243" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "030ddabd-7dcb-46ca-bab6-3feeae3492a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e3ac846-82ab-42bb-9072-0a1cb81c96c0", "AQAAAAIAAYagAAAAEI5j1YCgRLHwInKoh3UZYRJM/R0vUEZCRQ6Yglu3haYbAgyBbm6SMj/3aFRwbKVcPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04b6c6b1-5f9b-4c7a-9f42-86193c03d327",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84c686ef-7642-4a5d-adc7-2c2f341e3e2c", "AQAAAAIAAYagAAAAEE5Sq/KF7cT7Vr7l5EAyuHRS8v6u4ZHG9W6jtoN1btx69e4PPLjvFJgUNL0TXzuVkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4b8988-22f2-4ed5-8486-85e757a97e41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deae9467-01f4-446e-949f-2cb5d869ad28", "AQAAAAIAAYagAAAAEHjZMW61bYdkjDBG6lh/6smW8UZ8td4npVgbiy7jc026W0qHpVX3bkd3iMCPIpjOpQ==", "48d8b8f0-03d2-4956-b52e-4e628103a016" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a688e82-f609-47af-a359-d8bcdd62b5e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "562525bf-e8f9-4ea9-8d44-f744ee31ef80", "AQAAAAIAAYagAAAAECHTCDwhtek3OffwRxRNF2zHgRNTPigVsSZ3SEv2nbjtXlho8q6ZSyicG5ikGeZz1g==", "ceaa7f06-615b-430e-93db-0b92eb4693aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "217e3e65-026d-4a8e-97af-a4fb30dfab30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dd0be68-83fb-40fa-92fc-91e43f8a3984", "AQAAAAIAAYagAAAAEP6oBA19xwLMwF4C+v+mkcgJOPgqoagxWTdQkFgqczvFDyDTMBnPtux5O1fWWy54ng==", "c65d26a7-9f27-4ca8-abf4-3a6609291236" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291cc1a8-8f2c-4f48-a919-ff4d9692a859",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "903e1ad2-ce79-4773-bb7e-aebd162600ff", "AQAAAAIAAYagAAAAEP7N+qKNixVcyg5XYAwIgYLo4Q36SPz70kRLPEtimF3ttPJ7HGMRKmk69Rc/GWmt4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb952287-5c32-4ae7-a9c5-7136308fcc75", "AQAAAAIAAYagAAAAEE28jIC12e/N9dQ5TcDLdF4Z8vQHze5jJoP2oo3NJKGVkWzwj0DK1r3TIY0MX8QQwQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e830c43-2ce2-462d-9880-be8aa1e71696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5963eb82-2b1a-4c5b-9b61-584851d5e45d", "AQAAAAIAAYagAAAAEBoHrvP6QEO+eVyGk5k4PqX4+PZjXIQtu4cM8bcpLnBT9dOz7H4cmH44HvktCWUDiA==", "cd970466-b9d2-49bc-896c-5bb168f74ec7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3034c6c5-e1f5-4655-9baf-079f41605550",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d120d16a-f9e0-4459-9e76-029b699be45c", "AQAAAAIAAYagAAAAEEccgle1Zm0ejm93gR0ya2XezW9A4TQTR7pR7h8zFoINnawP7vXmqKen3yg6fAgg9Q==", "19516818-f9ea-4c6b-9c79-9d7f1266e39e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "325092c7-9882-40d9-854b-32326c2bd43b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "552a2b10-72fd-40cf-a016-16f9db25fa2f", "AQAAAAIAAYagAAAAEPzZb7yZW0hqTQ2kG2pEP1ea9vOTSspkuVMusp0obUEtK1FvgA5mpJPHt3DmA32lGQ==", "71a10b0e-28a6-446d-b993-be675995e745" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32739a60-8250-4178-a19c-96d90444ebd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88c5f051-b619-4173-98bd-3463d7caaaf4", "AQAAAAIAAYagAAAAECEUeAOhohjD2+ixo+BoMiHDa1rlyqmaW0TXZRIZEolD/4JhcMYIFFuBGuOqG/FK3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331d08d0-d407-4d61-af6e-1bb134ae7998",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e762a45-7ee2-4163-8b94-c5e4a15f4c13", "AQAAAAIAAYagAAAAEH0+9rWQCBa4i1cFZbDPE+fFf6gSFVYB7cvWTkcl7Z2PZ6kauVUkuFAFUecvLmoOyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abe8f222-6fe5-4271-bae5-565e945f8a08", "AQAAAAIAAYagAAAAEOP6KpjKlE+sJGDG51owqWd3navXdBzFB58Mk8OzVHdZ8WbZAN4x+MqA1g42iVVHLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a76fd9d-a1bb-48f2-9626-1122ecf2d797",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3ca3283-c453-4b30-8773-707bb0b1b879", "AQAAAAIAAYagAAAAEPNaK/w1AA1RKye6LB921S+CqaJ33B+zl+JuAxSsajDyi3XBIn9kshl36VKR1fA2Og==", "fc500cf5-ebfd-4df1-9791-9453c35a1bbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51065229-23b9-402f-a54d-00bb813d6b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f99be443-0d9d-4154-9f11-d900a26b5cbd", "AQAAAAIAAYagAAAAELwskAyRv72uGRcmXEth8YEm2xzklpaN4m4IdKHPPp13VBetjvI1VeBnADLFfkAJbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b6433a7-3564-4cba-ace2-4a44afca4177",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "895ecca8-15df-4971-9332-9eb3380da8a0", "AQAAAAIAAYagAAAAEKGzloLuwtLbNZFtL5O6unVdJ5U694spQR6tehiAic1H3B9zBN1Zv5NqnK9I0BCkxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8eb86d7d-02f7-477d-8e6f-539d7c155930",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fde7f5a9-b8cb-4d06-9198-d5cf8e60dbf1", "AQAAAAIAAYagAAAAEAysbEPqGplCyWqSz8pmjX2r1oeXNoTAS1IXCBrzkC/0UDGHTDNZ+PBwl6XAY0c+LA==", "1d3323ce-4c2a-4c1c-a0c6-2432a37643b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f7bca8f-059f-4750-8bfe-7def13ef37e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5b4dffe-9eee-489e-980e-331b975df4c8", "AQAAAAIAAYagAAAAENEojz8wg+Aa5CKkb7t/DjM/q0CCaLE3raqcY5kBTugGvmzYaelyaIrEi1YjvCFjxA==", "598c6862-c80d-4e15-9c01-d75937d3d3be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab8c775-88c0-4dc3-b11d-178c3ca2129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88d14218-7174-49d4-94f2-411c3fe6d226", "AQAAAAIAAYagAAAAEJxafz/13jXmxSXalS7Rk2TaTMU1VzmRQ2+BMKELK2jr+gzvZ+NZMHXWQThS9AfG0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc6f7d43-5391-4959-9bb9-198a23e90fac", "AQAAAAIAAYagAAAAEOvbEdelRID5QnW17gLF1xfUfZcpoQqAas19IPiz8cPDhxQzH5JV7Ht8wJWoM1N8EQ==", "5f4eefca-9d71-4d57-af56-4d9330f6f6ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab696b9f-f5d2-45a0-8495-96e2d2a01acc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a4d2cfd-be58-4850-99c8-eafe7820255a", "AQAAAAIAAYagAAAAENJLwgRtGOxHQDEXQbKiftywBN606CebVJLbPEBNVXde2QUt0mLiOhmcdomX2ay+yg==", "32edbf80-7597-4000-9156-a84d72e1e06f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b65e6163-1454-4164-9869-2ff822f9da98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6564e3c6-54dc-4fe9-bfdd-00ec36f94dc4", "AQAAAAIAAYagAAAAEKAoU1QUgDjytQTHDLNW2PNQuHRTK22MJnNA0RgNDBdTg2ilFfD0e8TOepU4EpzUdQ==", "a6b1222d-7ba0-4dff-bdb7-0dfd8bf0ccde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3a0143d-9a45-4a78-8a85-dd7d02371139", "AQAAAAIAAYagAAAAEKqZsB4vetnMZc2g4F7/8ipNFD9jg+iimB+kYkMCE9sGDAP1jM1zE3Hg60dIJP2D6A==", "34b69204-09bb-4405-a6c3-34728303ee60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6b456fb-9234-440f-9967-1f0fee2d9719", "AQAAAAIAAYagAAAAEM6amIi5NzDIF5FTmteuUSYSsy8I2ctkkjf07AsR3hGx+L9XhIdXqOvCu/Uw8AG9sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5d7d80f-08d5-41ec-892c-30833098c047",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54d42173-fd52-425b-83f5-4c205c781f32", "AQAAAAIAAYagAAAAEKJ/hUaRMFOHIeHHK8yZWKREXSZQjQkktHiWYyLv7LlCTVM9xauE94bKbRtLT+IcKA==", "bafe1686-b913-4158-b0e3-733099489add" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c64af0f1-3716-4e30-b5f7-b0c5153e2b01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f703926-d3ae-48ce-99be-89b79975c20a", "AQAAAAIAAYagAAAAEFG+pQYHFOHFUEMTEcsM5Lz8X//6ck7KvNAKZuKOSD0DJ5T1K71Lsznc0jigaTstSQ==", "e9800a90-e0af-4dbd-888b-784a19dab290" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cab3584a-da3f-4858-a65a-3f7bde9e553f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daa41785-1f7f-4663-9a5d-a4b3dbbb8aca", "AQAAAAIAAYagAAAAEPiAqxkhr6ovvS86jLuFJ7Fsmjpt2a+4wrKxo9s/ZDBPu4+ISrk/TGC9pzO+dZF4BQ==", "2b12c14b-087e-4aed-9a2b-6bb755faaf81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0e396e6-53f2-40e9-8013-664b8a8dbd46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8213fc0d-20f5-4152-8d42-c908513c58a1", "AQAAAAIAAYagAAAAEHqOi8bRufygqc6YnWacDZkZL1ywpAGoOe3Ti8ak3/o95ztywmt3KYLIlUWX6icSwA==", "254ba5f4-43eb-44b0-8745-5eebba3e9466" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8264a26-ea76-44c4-a013-12759599a081",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab86e954-886a-4fce-8e2d-37897e954ae2", "AQAAAAIAAYagAAAAEEdaX2WaEIoQEBgvb2t2Pj827OTYWxELbifh9B2FGy45QBA5eMcCbwdmCURWbft5qA==", "ef11f74d-5e70-4814-b9f2-5048bdce129a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2875100-0cf1-4b1d-ba91-1dfa38690f84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54047de5-6fc5-4f75-a7a7-d253a907a008", "AQAAAAIAAYagAAAAEAnu79HWOwj5Ti9yhHCvXH7emawLJbC4AIwB6Y+lyFiEEAZClgVaEUSt7PvZZlYj2A==", "7aaff1d7-1bc0-4925-9af9-06cfe54b47de" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 7, 0, 31, 6, 264, DateTimeKind.Local).AddTicks(2046));
        }
    }
}
