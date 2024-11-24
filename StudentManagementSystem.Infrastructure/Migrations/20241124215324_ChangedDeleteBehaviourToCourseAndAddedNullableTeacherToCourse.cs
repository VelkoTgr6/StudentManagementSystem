using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDeleteBehaviourToCourseAndAddedNullableTeacherToCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Courses",
                type: "int",
                nullable: true,
                comment: "Teacher of the Course",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Teacher of the Course");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Teacher of the Course",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Teacher of the Course");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb8b9e2a-2a23-4416-948c-9fa5c83f3f62", "AQAAAAIAAYagAAAAENobwoo5x+QgsT2Kx8P6SkFwz0EEF7pl8HHjqmZnStFEf4Hym/hxWr2pu4LeDWmrvg==", "d1ee3ed7-761a-407a-b0f8-7682319ade0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eee7ab97-f365-4e51-b19c-59a46a753ce6", "AQAAAAIAAYagAAAAEKKpyCcuLXPJNO00iIQ0bsmVX6X+gomhx/lTbSywNu1DI16VtoKEww3m7zXI6q93Mw==", "1d866470-e3d1-4569-93bf-874e97edd230" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85528309-59a9-4b06-a4ee-9d0ec7abf123", "AQAAAAIAAYagAAAAEN1dnFAQzErC9B6pg7lVPLyr/3Ta5aog0ZlSFckU/iHl3OWDjiCRYfVmtkU5p/S4gQ==", "74b7e73d-6f7c-41bc-9655-dea763ffc371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c3cf9a8-f5c6-4c6f-aed1-15ca01bab327", "AQAAAAIAAYagAAAAEDOiYZKZgLdjQmvbeClqneDL6SsWzTeUhJXqiXSCuN5m8OspvNGSS44biqD9NzL3mg==", "ffd00957-09b7-440c-b080-914de9985338" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17385cec-f21b-40e6-9203-ab07145669b5", "AQAAAAIAAYagAAAAEAX78Jhnv6gJwaXe6O3eLMbyVRhO1mnC9u3WNswxNzQZqVHqvsOh3K0JUnWNozgLrQ==", "eca8016b-023b-42eb-87f7-d6739c39d6a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcfd517d-a793-44a1-941b-18b49a8b94ff", "AQAAAAIAAYagAAAAEHuoUYjnl/hTY4FZnvfYxHO2xYv2lBRrLR7uWpKi/InOye8OvB/UJCW3umewOXm7Iw==", "40216fb9-e2c9-4891-a6c3-d9ffc99433ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c91829a-7ad0-4715-8a6e-46418faa9f9f", "AQAAAAIAAYagAAAAEIDe/rqeXDCBpjekPVDDGRiFZDIEQU3ZEjvmOvQeEKsiXdGf4m7ZGjs/lWaTtPLMJQ==", "555c4e5f-4124-44fc-818e-0d07781c89c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ac24a1d-489b-405f-8830-51646e8d7014", "AQAAAAIAAYagAAAAEMj8QA4kIM0RKHCO21iLCUwoEk1HJI6WVRsPzptPpBPDU21H11WlKYld9Pgky/mdbg==", "78c77d2d-0365-40cf-b53f-396cf4c8cb39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdf2f10d-cea9-4621-b6ee-abb10d0585ca", "AQAAAAIAAYagAAAAEAlnMmee6pJSIJYaVYJeCVU2RHPFPFFyC9wn97HcJ4QY6jZRwEnP2/KrGf/aFze9ww==", "69985f29-20d9-4997-8044-47ce1bbfbc7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e4502f2-babe-43fc-8663-874192848aad", "AQAAAAIAAYagAAAAEJpERlU2a8q5jwoG2NH44ZtKIWSkgtTwdN+ygK8opvIQOoPNFu7g5FCzErUlrqjpnw==", "482ac0e1-0016-4d8e-801e-16de99710c34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae3a7c02-a8ee-4143-a150-7de5aa13df41", "AQAAAAIAAYagAAAAEFrlG3kcQHx4ANkHFKQO4z0sRgnAHb7QfS37ASqsXUUYOeiTe0gEu9U37NNKI1Vx6A==", "b915c5ee-6c88-4474-96f6-6405b5dbbe62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7168b83d-b122-4d10-b499-ecb6945cef19", "AQAAAAIAAYagAAAAENcNiKPBWGRlIelgmVAxd1kkshCBWRoFi/Lq2v8a2Z1yxzabYiKgzaW+xDwWK8ZVnQ==", "39b11741-105c-4e8c-8d2b-9f97d2614f55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bb44236-889d-4383-82e0-b848a3ab845d", "AQAAAAIAAYagAAAAEJUcuBZZ+Kl6nB5EKTdHPB0d8klm+s8qmeeasdYSWX5iyJ3XTRN+HiGNC92XnVXhYQ==", "1010acf3-fe4c-4d14-b2f2-b0ed1469b1cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27903b19-6e3d-41f6-9956-34ed7cc6a6ec", "AQAAAAIAAYagAAAAEEJFIl/7jsBys7H/RNERxt08agyXckF5zf8HlDv8WQqAaFLRamtozCsDdIZZndBbuQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "195641ac-638e-453a-9771-bfd7a5383824", "AQAAAAIAAYagAAAAEEMaDqDkLeTzJgLoYxG5BG9q1DD0/9yR8yKrwQyZd3mnJWwbxqrvButdyQpovlmHQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b4860b8-e684-4e19-adcc-6e7cc27668bc", "AQAAAAIAAYagAAAAEKtKTAJ61kSogzlaptproODHbak0gw4SegBxkZw7cEpBntBhoMLeBtteTpBElu9fJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ace223dd-765e-453f-8572-5fad4cd6fb59", "AQAAAAIAAYagAAAAEDWQyqU+lguqLa+K8hoRhRSKMoCCybQhcovjCxW4brRqpLRLVPf5Nmpg3dHop5pEzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4131f59a-35e5-424f-8572-e1773459a2c7", "AQAAAAIAAYagAAAAEI6R53euz2t6v6Nw5L+BoyfxUhZhanjgQtiyQTnbm0cGf/rExqki6rrjljR71DYOMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1763ce5-f1b1-4215-921f-3972913bb6fe", "AQAAAAIAAYagAAAAEC2wfcvbuoMExD+m4Bxp8w0n1QOTKo62+RdtmdPE1U1z4IWuZt8mIRMLMHxCUdTRQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f068509-2136-4f6b-8899-b8bb358d5a15", "AQAAAAIAAYagAAAAEM6TGQEcjJ5U/ZWd403l17g2PQhjEY9heWg85k4kOOGGeqJPdISIbIpdAMu+2XQoiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "447767fa-405e-462d-8b6c-b168138e9385", "AQAAAAIAAYagAAAAEHAuqzSCU03dUDB7iTgu8uUEcolMFgCyRCL0Kx9KAOQOtVAnlHQd+1DMHbYUAYJZ/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b23e0775-1d09-41c9-a944-5bebc05c31e0", "AQAAAAIAAYagAAAAEANRjgtI/sJZp6yGZ/89mMnLKWEhICmA6N8X5lN91po3/aZAIBIqbNgw5Ef7Fnh9Uw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3ddee7f-d367-4fbd-8073-d5eba54e56a4", "AQAAAAIAAYagAAAAEFj1V6E1AwaS0xMSj2Xu9Y95Rn4xPehFEgb0h8ZL6l8vNoFEltn08d92+MKy3EB2aw==", "369c668c-3d89-4549-8940-0dbf311c41f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8a8b955-0e3d-4b72-ad00-6cce82925cad", "AQAAAAIAAYagAAAAEPqmQJD0i13rJnr1b8+s5swD6Kkmj4zKWivz0V8rYUFcTcXhl2jMG+GE51Wqk0yEVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5509e075-4934-43da-a0fc-8da227cec926", "AQAAAAIAAYagAAAAEDek6QFtJTP9mXehUMka2tthy8UazMwYQFJKokIq7VQ2ihh/8Jtk7o26PcYQ6hubYQ==", "048d4924-3234-4666-b6ac-044c6d13943d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a51d11f8-34da-437e-bf17-e1907b7c6f23", "AQAAAAIAAYagAAAAEPk6lBIQaSv8wy4ALLMKCd9VnFMOhssVxfRUEvVRtkYyyjEm9izo8xywLAgd6vHI0A==", "a377abf4-5008-4c69-a995-716ac330ef2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7feaad46-3275-4b50-a8b3-9f424b24c0e8", "AQAAAAIAAYagAAAAEApZwXjyTzvj4a+tLgGVCVw9AtQCaSxfbCEMqfvLrOriDDMgjjV/yz49oaRfnHxOQA==", "091b3ea1-d241-494e-84da-a21860f924dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8804d4c6-b9bc-4b65-9cc9-00397b819e81", "AQAAAAIAAYagAAAAECeh0Kcm6bBhOXK2ea99QGGr7BlQ0Jt0JXtNea2GrkMhu43dV8dNkbG9j8XNWq2FFg==", "edec66d8-20b1-4025-85a1-735df20086c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9fd1f6d-5ccf-4012-82c6-99cf5d200325", "AQAAAAIAAYagAAAAEFKDLvdLI7bNEONxHNHFs1YXSUDpHqId4uzTLx+jNc9JaBTKwL9kza4LGYa6lXU+gw==", "498ab0ea-f35f-4227-a742-1611cb0e9b55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d170516-7214-4572-901a-ab10be0b5aee", "AQAAAAIAAYagAAAAEGT8UBIoq5ScpgqUp7s/vzODmxY89YYfpl5CEqytDhKiqTIzKE55MU9z7Zxg8Wp6AA==", "2228eba7-7785-46fe-a225-2597d2e2c98e" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 24, 23, 35, 40, 661, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
