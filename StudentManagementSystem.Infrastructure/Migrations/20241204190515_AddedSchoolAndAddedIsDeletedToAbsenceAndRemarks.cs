using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedSchoolAndAddedIsDeletedToAbsenceAndRemarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 1,
                comment: "School Identifier");

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 1,
                comment: "School Identifier");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Remarks",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Shows if remark is Deleted");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Absences",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Shows if absence is Deleted");

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "News Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "News Title"),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "News Content"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "News Date"),
                    PublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Publisher Identifier"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Shows if news is Deleted")
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
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "School Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "School Name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b3a5962-c4ba-4213-a4d1-c818ae3f40e9", "AQAAAAIAAYagAAAAEHyEbl2KnD6e00sXNRXjpAPy9HI/BsDur/aOz5jKLUn9mpEaxdLINrSMdbAa7PkZcA==", "e4a54a7b-02a3-4902-bb77-ec62ded3dc34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "659c090d-f4d6-4be1-9bc7-fc67428fdc75", "AQAAAAIAAYagAAAAEH4UtuyCeeaa3/eDZfjttJQsJCzfoGPqYn1kjX9Uafeum7YkN+yavpSSkpcuYX/0Tw==", "d1d6d4b4-fa90-4223-be3f-3d478aa122a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bea24560-0cab-4764-a52c-12094a2f61cb", "AQAAAAIAAYagAAAAEDUgAG+KDCPkZKWui0Itsf9LH4dgZTWOjLQox53LqXVLHj1aoZiGHEWDwv4H83iNgw==", "e5d4cee7-8f04-4aa4-b941-f3e0447a4b3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05e2645b-8159-43e9-a08a-bb8eb9b3121e", "AQAAAAIAAYagAAAAEAZ2kVaRSYw/99MkJrt9mbSe2Yucmo3n/8GKwz+drCh74np7/TqUBUkreUwlZqF9Aw==", "1480f1f7-8f1c-45ac-81f0-f45ab918dcf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24de44e5-9676-4018-a78c-b0232de6775e", "AQAAAAIAAYagAAAAEF/JI/dQJYQXz784HgrZIfl5a9c6u61w5HbLEnccpXeeyJYwz02JC7O4eosE+1ihrQ==", "ab811866-d3d5-4c18-a6b9-3e2c821d316e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccaab036-dc5b-4f29-83f5-d80f6a760fab", "AQAAAAIAAYagAAAAEHuRV8UKFsvYvq2YSOl9RM9p8iznEiBGhLcqLgDIH0/76nwKPmUzB2KdjrgmoN4log==", "f7f53a27-b370-454c-88f8-255944c78a4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33c0c38f-1788-4eb9-beba-d563f19b4bdc", "AQAAAAIAAYagAAAAEDWKjA4pZYm7AdsFARcWonCKqHeXthaBjm+d4zHap7Q6p9abzLbUbC+532bf2Zn8NQ==", "bc1dcddd-9433-4228-a279-fba63ee979b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e82b821e-0237-43b9-bd47-e82f0f6e2d9d", "AQAAAAIAAYagAAAAEH6T1sET2Y6AYorwA7d9Gq+ZPquGCtkpnAVRwk8e0n2xhOAyOTNss2mZpL7PLZOZBw==", "37260788-c66d-4743-8307-71f96dac2a48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7ce8f6e-188f-40d8-be3c-27aa33fb85cb", "AQAAAAIAAYagAAAAENW6NsWSRZi+yzFNHz6Q2xUmIeQXcXgE6J2SLuCXOFqJ5GIsL9vqFCoMeNOin8Zu+A==", "f0048fda-111d-4790-93c2-6a0ed4a1744d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ec58298-aac4-4dc8-822e-b6725ac22e35", "AQAAAAIAAYagAAAAEEHkwJCQbRhITxpmnUe09QGGJDUTtwVDmtKI4bcle2xgyJhCHoYVIssU8yQo462UEA==", "942b800b-567f-4754-b81d-936e8de87a34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b61b154d-2b0c-46a5-9215-e1dfe0b7d5a9", "AQAAAAIAAYagAAAAEGMdMIEWK6hTy2grPwmTX7nOp3GjI0EghWBpRWgZm81fKGsUCLNao3lFfzcGnxTwHg==", "e1c4d1dd-1381-4c74-b6d9-fc9beb5e699a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e338a08f-ab92-4000-8279-c85cefa78639", "AQAAAAIAAYagAAAAEOtnHbk9GHWUQ3UaAe5NyfxkHD8aXbCPKEfC3TmPVcCQukX0HWbvx3vb4PIapWJbig==", "d4ec19a3-64e6-4b48-a5a8-7a5b07c9ca8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71f09cfd-74d5-4764-816e-c74684c3ff20", "AQAAAAIAAYagAAAAEDNY2CLMIMwcv9CDaRWYmEnOo/6O7Tlbpex/7JJXLEcX42WsCb6vO4mD/fujMNIa8w==", "24801eee-f6fa-49c1-b19b-106524704cad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ea82a04-1f15-46ae-8ac1-8e70c04f6688", "AQAAAAIAAYagAAAAEKdRFxm0mW2oZyE83iIUDJm9TrXa6UI57aicJ9KgMSz6yUptrvxOG91DlpC2Zec24A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe00fae0-c40b-403f-94c7-e133aa1a88ec", "AQAAAAIAAYagAAAAEGt5Kdw3ywlmgh6mIyuzs7G7dC3kF4m/pT3GV2rY4yrjz366D/OyxqwYvpcbx7nfRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86cc5c11-532d-4543-93da-f2c3c4261e47", "AQAAAAIAAYagAAAAEAdHWig8rVbHVM2SPaoiLw5sMOB8bHttR0CgqUf30uGLDx94uBHZMlh+WwM1tgIPiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "498ff5d6-a1da-4371-8a0d-2a6e52e05a56", "AQAAAAIAAYagAAAAEB04fGz+GRT+v+oTM1FuYWeYhgd9P7Pc2k7J2VnqGkN5Pr/CvCzMtAmHwT1zx1vKAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "469f29ef-09dc-449f-aa11-1ea15443af43", "AQAAAAIAAYagAAAAEGh2BjuqNUv9QuUPtv1yo5CN7TN1BqNtBq03+/zlz4GYsg4OifGM3DPGXxEzoMOhig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84750334-c996-4aba-a9b1-108875d4be7b", "AQAAAAIAAYagAAAAEPddRTikl/9+PpxOZ/MXCHWV1jWOBHk4qMv9OTZzY8CR5BInHFO3Tp/AJYY6a+KbYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73b57e5f-8e1c-4989-a151-a48eb97e8284", "AQAAAAIAAYagAAAAEHWb1BuAcQgLKYWCCSY9Yy9FAjf189lt8VkHdFXFJ7+/L9X4Rxr4iA/7W782elU6zg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21aa7482-3419-4747-b1fa-75eb1e5f0917", "AQAAAAIAAYagAAAAEE0Y3q1e/4Urk3jasRODpBNbsFRDGvb5WTza3JPnjt8mpT/Pc1/FjPSoUHDt44ePiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e09b83b3-c7b4-483c-907a-6d773096c95f", "AQAAAAIAAYagAAAAEA14AfhH0Wcfu5vWUcKwHU4cY6C9oryPBjlzbW9K/ZhGJZxk7KbOTGLVdee/tk/tkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "163a5164-01a2-489f-bff9-1ad6d0764f03", "AQAAAAIAAYagAAAAEEuhzLt7G+SkH6IN9alIkJOXTQ7Z+FZHjmSP+UC1mpKtHi2mRB8xusubblCL7M7NTg==", "e78b621b-f8d7-45eb-837c-56a7fb7aebaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f328d513-3418-41e5-a1c4-0e836fc92aae", "AQAAAAIAAYagAAAAEJXXTSD5zkQTJAPiQxWQ6zQUGnK0FIOVVSrZ/2jUdcDIf3sw+SVXDrxFsdMNIJhScQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0c40e92-a5ca-445e-b642-7e81338c8e48", "AQAAAAIAAYagAAAAEK2HaRvfFRCSemaPm93NXZ+jw9tQbEu5ask+wDl+TpMeZUJEK6ZfrrtlWh5+dHCzdA==", "8e6448f0-ef57-4dea-85f8-51625f057b3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d517f8a-7a4e-465e-a546-4d691a043385", "AQAAAAIAAYagAAAAEIaeANUplXuS4EKgJPXJeW3mK6BTnOptcsxOU/iK1c4M6GJrISROC8Vv4RKKOeN62w==", "246a9b18-0cdd-40b2-8cac-aa2951b91aca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0156a8ca-aea6-433e-8e8c-30eb33cb84ac", "AQAAAAIAAYagAAAAEBCnIfj+JksqJ3QSnzz1BcxoMGBDvuBu9dJtcNSVbfuq1AZr3QLpJY4m/uAxD3FmyA==", "92ad6049-0f80-46bb-a476-5d3cc9b98ba0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2724bbd5-d8e3-4ab2-986c-0aedc8e123ee", "AQAAAAIAAYagAAAAEKN4Y7+KmhKgUOG1+I3TLh2ip5rZDWz6nwEsNviNG65exkuFU4OP6PsSDJlI5GadGg==", "ccde491e-f11f-4681-b020-edbdc2df6ec5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3256ea3-8f69-4eda-a7f2-44fe82b15746", "AQAAAAIAAYagAAAAEP3fUkfyXmw+jPdDFkqKic83xZxcn6VdzE0Vyjy7cgXsa3IqKlxeSg1xohgXWIdePQ==", "cabe2ec6-5284-498f-b8a5-786524e700bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b79dfea8-f244-4970-8eae-ea412c2b9013", "AQAAAAIAAYagAAAAENgEZW9bNRy53ekKL/WPC/9FV8+QwVdnZhLj5+T13PBect77ko7UyGYBCbf6osmPfA==", "12570ae5-2e09-432e-a1b6-99477239b002" });

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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2006, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1058), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2007, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1125), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2007, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1131), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2006, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1146), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2008, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1151), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2005, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1155), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2004, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1170), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2003, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1174), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2002, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1182), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2001, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1187), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2004, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1194), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2003, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1198), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2005, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1203), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2006, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1207), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2004, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1211), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2006, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1231), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2002, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1235), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2003, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1239), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2008, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1243), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOfBirth", "SchoolId" },
                values: new object[] { new DateTime(2005, 12, 4, 21, 5, 14, 86, DateTimeKind.Local).AddTicks(1248), 1 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 21,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 22,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 23,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 24,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 25,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 26,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 27,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 28,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 29,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 30,
                column: "SchoolId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolId",
                table: "Teachers",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_News_PublisherId",
                table: "News",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SchoolId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_SchoolId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Absences");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a2453b-ab71-45fa-bb8f-fdfab9589458", "AQAAAAIAAYagAAAAEGDAi4FPsN1KUTkX9jmM5i1g4AuGWuEpsyGTPdVTTeHvQCvKvErdtUEG9pHIQucLjA==", "89eb0dc6-936f-485c-9a32-8f85cced295a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "943931ea-d2e6-490b-9c79-9149691edb46", "AQAAAAIAAYagAAAAEM2sR5/dtd0Hecf4y7V8HcLDhMdlvqBKg6i/kIZlZPFXhbzphaE+/K3LJEPT+PzVzQ==", "13bdb72c-c15f-4895-bc70-fb53008983e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8dba2d1-51d3-40cf-a071-4e73cf0265c6", "AQAAAAIAAYagAAAAEG/mkhHe90g8B2FUp9XAcpbXxXF7CoTGjY4Yn57os5FOBDoI8iGPEXfNdNlY1oNxrQ==", "9a9eb482-111b-493f-b436-a377f95cc82a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "176c04f9-4ac2-4118-9fd9-589a9c089fb8", "AQAAAAIAAYagAAAAEHGaqkn1DZABicvdf+1ISb5PrhXrnIWkdnWsWRlNGK7tUQTFLKrDU/FdJH7BUeZ8jQ==", "01e8a2ab-e95b-4150-bbeb-266cd4f01f65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79066092-c0eb-45fd-a840-0132da037622", "AQAAAAIAAYagAAAAELQtGXP2fNzXDpuUdxiINKBcvgQGcO5bXT9JjI19nkeSAr+bKvk/HqaeDGzf7RihXQ==", "99426dfa-9fef-46fb-91cd-d641383b7069" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f89c627a-86ff-43bd-8025-5395672a3549", "AQAAAAIAAYagAAAAEAlPfX0sfLnnsGiri4VyBIGrhOO+hQS7OfARwoiD3lfd4RPa6M3ZxK10rUpPnaCk4w==", "ff0d6b26-15ee-4592-a4ba-a13881b30925" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cda5d90-ded4-42f9-89e7-27928c875ebe", "AQAAAAIAAYagAAAAEDNIFGvPBki0Sg2Yg3sll3Imdz5gTl3n6PW5XeZINlaSnZdNM97JpFLRCFW3gJ5ypQ==", "708a3f43-6ae4-47f1-abd0-94ac71495e7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97dccf7a-a480-4bcd-a49f-a4d065610c51", "AQAAAAIAAYagAAAAEF+1v6NI5y5aCXZIbTMAOzUbgt2dUXQ62TRf35eW7bCRHankiMrIXg9fQEkH9GRLjg==", "304ebaf3-7b31-4dbd-9318-3f1c5b093cb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48aed287-f56c-4c82-8937-69698c9cb406", "AQAAAAIAAYagAAAAECob9Gd3kstBpCukKC3dyzlR7YTIwumRFVDxumqfTYBNEe8h+pFwRZ34N/04eHSAyA==", "d85ffb5e-ed4a-45fa-aa71-6fed3fe26942" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d44aa859-2884-409c-b498-82ce1881b188", "AQAAAAIAAYagAAAAED9vU/l0zvB3llOJhprRhuLdrEwd7XKgokJ7z+LlpC/HQBGZTyYp80ID7h779fzWyw==", "f37e515c-2f6a-41ec-b075-3cc1bee1f45b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afba39a3-c9c4-4ba4-adb1-d0fedaad037f", "AQAAAAIAAYagAAAAEG7m2oMDUf6XDgZzztQbXwSH8rzOerBWeI5MjOiXzCgSicDrV+P6SzggPlsLRqvOew==", "a1ae8cc2-4e6f-4d57-acb2-793107a8f4da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "702c53b1-453c-4ea0-a694-56502402f853", "AQAAAAIAAYagAAAAEHAYKAKTy/gSrGbUczb+wW3FVfaH0qxhACg9SI+iiWfcHLN+1LlZCcMkDGoAtC0qJQ==", "b53af52f-b7fb-4340-85cc-4668c6e05f0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bd628a6-80b1-4fed-aa0b-b18b5a4cdd25", "AQAAAAIAAYagAAAAECtq/hszp7EnDqyTzR3HHWwZ5VytyKFu0nWYAlXU8K0wHcXpUG4S1P9GH5vBHdqZDQ==", "6e988b1b-7d82-46c3-9406-a048a05aa197" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f345dcf-74e8-4800-96cd-9479100c5081", "AQAAAAIAAYagAAAAEDqSqSUfgFXirxYoxidNLThMrIksihCMEDLi4VeTbR++SQ5CnmvSqb3fbBuN1psgpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bcf92725-9085-437b-9f60-f740fa03a009", "AQAAAAIAAYagAAAAEG+hTwt7AtGjUMercZDf+EmN4OjfcUH96clzpb+uwg2OwU43Py32Den/lTNp+3BM+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f709b85e-20b7-4762-806b-1947dea42b16", "AQAAAAIAAYagAAAAEGY5SIdPS1IchWVkxW9UE416ThlkZWVtgbL6UG3vfvRNITS/g+QGds836RCEKXzkzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8fea6f52-143a-4297-aaf0-0b337af4f77c", "AQAAAAIAAYagAAAAELaJVOfdKaDzql6d9u5vjpqGR/Ks8xbGtW5If5YROHb7YaaEyrWyJBienUTGnRe8Vw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ec1ee99-3d77-4142-88f1-2ff1ae70d81a", "AQAAAAIAAYagAAAAEHnXkfXAceGjxjxKS5rER+bu9lo/gygb8U+QVbPud76L1bEvX/LYsrVv4lm9zfp1XQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91ec2f8a-4e7e-4d09-8528-de1df9a685b2", "AQAAAAIAAYagAAAAEMkhpnhKAzerWwsqrpolILDntsQkgEputSmDasBRYzjTN3OsHJxTEjg7ui9lZccBSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ec9f988-ebed-4b6e-866a-69f62330656e", "AQAAAAIAAYagAAAAEK/vqwXmsKhbaaXKhFfR+XhYacm70zspC0OMQYrDczRJJ7wbzfP/PLmEreS3dWUAzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b034eaf-1dec-414b-b5f4-af9dc7a48f21", "AQAAAAIAAYagAAAAEA/HnqzT2ATNez1Wpk8ThN4WDVlkntQ3tXn81dqV0efOL9wICmlhY+K+zhJF2/cqlA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1615dbb8-abac-4fa2-ab63-0e60fff4c953", "AQAAAAIAAYagAAAAEMbqWhUB7/iFan8au1nFXi3WUgjEvFiGlBlVBoRxGxS3ViPlxYaxdQikGqhn8oOOOg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2237b40c-6a00-46a9-ba92-852c71f41c7f", "AQAAAAIAAYagAAAAELLxzJ8ifX+4KY2zJcoUWpRE9kHQzOBZg6OvBY4B45xmZ2B+KHINt3A8WcGmmMN3oQ==", "8ba4d9e5-7236-43d1-9684-5f75bde1ddae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3cae331d-35a0-4b86-9487-099a7a8f45d2", "AQAAAAIAAYagAAAAEHVnGbFZO7zSpt2uzDYWagPRWcsewhUXUEisJgMq9aZsXjK7FTKCrlHV+2MB4hDN4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53c01f25-59e4-4ffc-8a44-c832858853be", "AQAAAAIAAYagAAAAEEszylfAbKJ9isCc3kXA1ZgYqz8CoKpnJvgwkpAcGoHgLvk9Rh/pEMA78rQT9PIw+w==", "9781e055-2dc2-4858-bff3-72dd3188b8c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d0fe245-1deb-4980-890d-d733ef7a9d50", "AQAAAAIAAYagAAAAEG9JGei7qGAyrVnJU8uoODF/PEEJ2lFZDFqTBaR8mJ4OvYqET+Ab84Iue8fpZOuHqg==", "4702f12a-c8dd-4b03-a25d-81d45d3eea9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cfb252f-7aac-402d-bd61-6666097d11dd", "AQAAAAIAAYagAAAAENE3EL9V0giU8KVaeGtr8+QNfvPVfGCWz2BCYnAF4EzYJUGEffrVgKfBQRYOFf5l/Q==", "38428672-b8c1-426d-afd4-dcfdf7572c47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d13bf12-3031-41eb-981e-7533246d933a", "AQAAAAIAAYagAAAAEEE+e2Q/xUM98C4a3Rdy4uA4VH8tEoAWVQeIXJrCKVuFRZ+dGY2OuPQboE837cimuA==", "85c9615d-7149-4301-821f-a98329eee434" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ab69ddd-828b-4262-87cb-59f1c526acab", "AQAAAAIAAYagAAAAEPIc2IJ2qJ2ipzKrhK9/meubFkTwLFkRU+e+KYbgywm1D0Iwv9snQf7Lh6OY+E/osQ==", "ec14d7d8-7a21-4bda-838a-4246990a6325" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "352fda53-3600-4ab2-b159-4b257b58fc7d", "AQAAAAIAAYagAAAAEJBawUH9d7/7GzLj4rasHRMnj9iP2wciRUOdcaAgJtFlCU/8zXZdrHGJAW53aG7Tjg==", "0b4a3121-3ec7-434a-8fe1-7d80f348bc6c" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 24, 23, 53, 22, 983, DateTimeKind.Local).AddTicks(9483));
        }
    }
}
