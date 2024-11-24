using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changedDeleteBehaviourInClassCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourses_Classes_ClassId",
                table: "ClassCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourses_Courses_CourseId",
                table: "ClassCourses");

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
                name: "FK_ClassCourses_Classes_ClassId",
                table: "ClassCourses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourses_Courses_CourseId",
                table: "ClassCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourses_Classes_ClassId",
                table: "ClassCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourses_Courses_CourseId",
                table: "ClassCourses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b12ffe72-eede-49f5-b32c-9cc7b6122fc0", "AQAAAAIAAYagAAAAEHE3GnvrZWOSpTM2ZV7f5ZLZmGVAkuvuA7Lga4l5IK0dmn4aZnIA3dY6blcg7q6LKQ==", "a2064546-5b05-49e6-9dfe-231449fdb33d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1290cdcb-abc8-48b8-a77b-4264dc2eea81", "AQAAAAIAAYagAAAAEOwVpLe/thuiunrLks8n7l/G+JgR/Cv60rjFMgsXoJZnMB3yXNIzyFPHgaC1Z8hsLA==", "0bd8993b-4cb1-4052-a1ba-4998ef3b7f3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "232c6d2d-f484-41ae-815c-7cc28e2fe4c4", "AQAAAAIAAYagAAAAEOIaOe5wp/7c5NCyimOsdL+IUeVeSQs2LSn3T5kOL+Uo4ejqkX1zzUnuRIOCC1FF1Q==", "22366fae-e42f-42f2-8bbc-8c661a54cd44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cdf3905-8b4a-4e48-ad73-904117bd1076", "AQAAAAIAAYagAAAAECbcvH2siNGpAbw2M9kaybkgXG6gpHCGCxkpG3B6O+WIfJ3g4mKwgMH645la85hY0w==", "44172c21-3926-48fa-ab20-95ad3144b24a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "516d4e80-9cf9-440a-8763-4c2c6f6c76d8", "AQAAAAIAAYagAAAAEK3LNda4QcWs8dJ3Ga7/2Omwh4azTC6OV9Kaq7IMdGh/KfFHMXpqNecmhQvAsrxXmg==", "16159938-12ac-44ff-be15-7e35242bec07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65b83cf3-dd04-42e8-8eb7-d5739a927490", "AQAAAAIAAYagAAAAEPWSFItlnptmGarIz8d3NgosS/1M7rqc1QwaCxi8WAIJ+iKFTxuHo9wtRSr5BJVsnQ==", "4eb6df49-6f12-4652-bca2-913bfcf9cf42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1231980b-aaf6-4ad3-92ee-8fc6b760d301", "AQAAAAIAAYagAAAAEKiJXIlM6uKprmy7ATOdlHnpHAFsfqgjQnB8d1aprmV3ZIN3zxAdFLf9vS2QyO/cjg==", "3415e0d5-d711-4c83-b7ac-6dae290d571e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa93e517-682e-4ee7-8cbd-9df4eff73e23", "AQAAAAIAAYagAAAAEOzNng03PLo1linfpCGC9yIsjoAvs1tpseSuM25DHhkls1UlYvrqwLSExyQUUfJFcw==", "b791f5c3-de37-4c0d-98cb-c120d676b9ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c680293-2359-4495-9c79-b7fa12a49000", "AQAAAAIAAYagAAAAEAMYJXlGkojJudGVLp5Vib8EetlQ6E5ldoQEeAX/ro9UyzHvL7bOs7miAq9SG6LA5g==", "b7509752-3ace-48ec-8b6b-2ee5e1d3dc29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07aae696-da82-4cfb-9316-7814187944bc", "AQAAAAIAAYagAAAAEDWaIoYe9pN5VkrmfZfAahHg5lrb9FArEJEzC5iYt4O/jz4e+CQaX0fPNqzxmX4DFw==", "25cce692-a75a-46c0-9bb0-421a7c31865a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29f862cf-2ef2-45ef-917b-1d971b503335", "AQAAAAIAAYagAAAAEAtjcXOU//QHr7rCevC6T9ZbNRN4rdNeEUayTEz9axABX4TqvabNMfbkFpEc126qqA==", "7e3b7910-9238-40a4-a543-c2ccfd1f8b83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb64caf2-66f5-40a5-b011-c62a353b365f", "AQAAAAIAAYagAAAAEEMbNKDjcZ6O0vGVCnDPvSms7xEH3vtfWBbDu+ckOg9Bx8IDhHy4kt7sqR+xaJGqag==", "a7c643e1-aca2-4388-9445-1376cbefbef9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e792c68a-d741-43f2-b337-9b0a87ade8a7", "AQAAAAIAAYagAAAAEIOqbp7IpEPVrPrP7fJbHfhmsX2sXn23ZnCdDBRHnJyu5lCgp/rGLm4dEEx8VqRhxA==", "57e838ef-e7e1-4d45-bc3b-c79b8cb01bf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15745b7f-9b23-473c-a3fa-5fa7c586cf9c", "AQAAAAIAAYagAAAAEMhwHodAQvIEMOqZzHb7SfpHlVxkKssOkN63n4KxsrChVJJfWenq35lmAJgfcrDHLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eee17217-8f37-45c6-9fc6-d4ad89f20ca0", "AQAAAAIAAYagAAAAEKb5NB7KeDx9WP18ecBf9a1kvcIm6mcve8fRYjtIk6KA64/dOfUUif3OGDn+fEAEng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9a1c335-b077-4802-ba61-06f455df65b1", "AQAAAAIAAYagAAAAEO+woJpreQZjxu2v61+z9HGJ9khtOq8Xm/CCw7XkLPO8G7aa2QUxPeq3Mg1JAwtTzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dddafa70-7615-4a7c-9ca6-b36e28c9feff", "AQAAAAIAAYagAAAAEM4XfNj/tFpd/gi3TBpNV0pcp6XAMB9NVLawWsbNthOKSMEFCdycGLLzWYofXi/7Eg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "efa04e72-cd50-46e2-978b-1e4df83804aa", "AQAAAAIAAYagAAAAEFYZjYUVanE71fPrwSGZiD6r60Kaci8Lkve0KMt2I51aFXBTxMG8BToAo+kalNSu6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "420a619e-4fc5-4204-ac69-7bcb73ea82e8", "AQAAAAIAAYagAAAAEJPmL2I6tQ/vcBRorRmBnhhApOxQ6bRfQplxSWOBdq4Kxr2ZIFQpMJnWrrwnXKQEdw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac9a2212-d44d-484b-a66f-87f76968b505", "AQAAAAIAAYagAAAAEPENqbM8P6YuK2vdF2HCcPCDcjNO10rCGhi8Lu7ufFAIMf7CCAa/8HEP8NriegW8sQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "271910ab-0f4d-4c32-965f-e8f51a652476", "AQAAAAIAAYagAAAAECRjOOlyRYYPd/TdatmLhUyNigmHxOA6Bm1ohmyfMsMwCPXNDVzQZYtQD34ayyXL2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "341422bc-a5d5-4ac9-964d-b76a5ed247c6", "AQAAAAIAAYagAAAAEASSCLjZi4/oLDG314el4OLEtO8b0oSCjS9G7OWtMhqKyRfIOybb7oeq4KdNQqnAsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3ef0654-8c66-4798-ac1c-0715d1d582e8", "AQAAAAIAAYagAAAAENFI+Gd6WwueBz9bFNYcwin0hFk7HLfVRzIn2zp5Vge0j9fH5bcbQqFxF+6z28stfQ==", "825f11c6-cc35-401b-95b5-06ce3b65dc79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6cf0f23-e1dc-41a5-a5db-ac1baae541be", "AQAAAAIAAYagAAAAEJftN9f7lK6ci81fgl3uUHKWsN8lIjzyAQpccjPdoknApMM6fqehT5I7WW2KI91vxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58ed5833-5832-4557-9b80-11549c08eba7", "AQAAAAIAAYagAAAAENWx+qSruP+Maz7VrM52l97xhpjTn5Skv4EaszNCBtWrA4guaF9IOhoGvLC6t4Zrkg==", "fcd534bc-6784-415f-98d8-c320a84b522e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b6ea065-5bdb-464b-bd27-22a2e81ded3a", "AQAAAAIAAYagAAAAEF8D9OH3uxcOSR9qDt5HgJj5BvrRK+XaVk/Jjrp7TeL5x6MEtZY19KTlfby0n7EvJQ==", "8b291508-4b5d-4a78-b516-17440e97b783" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b73b0f36-4219-4817-8f3b-7152e5ea785f", "AQAAAAIAAYagAAAAEIWi+5ddonzDrAG/+ZVOk5O/gV66tCUcTKk+oeoZGIqf4K7M4T8eNhDDdwlnYg4XHw==", "a9668539-04cc-49b1-8b0f-6fff1f826d90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b328b52e-e5c8-4b89-9d13-d299bb5f6b44", "AQAAAAIAAYagAAAAEO21TdOj6M+cyGIeevrLNaZurld88Sgwi6dJtejR2hc30elmSMpg+I1z/J1aNmIeTg==", "3e38b538-2ecb-48be-8943-d42ff7cf40d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57610e5e-9290-4e95-9976-9386e247e8cd", "AQAAAAIAAYagAAAAEI8HG4k9LNlWN3nVNfe1Tz3cLmYuL8gKR+5urqXcWFCDi0XQvPnubgB6RqhUpXPfDw==", "520cfcbb-e96a-48ca-b5ec-ca7edebd01a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1722fe1d-40a7-4970-b377-b6a37bcbc2fe", "AQAAAAIAAYagAAAAEMJcPI0sM7QfpTVdmmCKYV+ecTLqfrn8y03DWbkbsB2gmidJOJX5cdEHW7N4q/PVWg==", "38f17448-1cc9-4bec-b53f-e45809a4868e" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 24, 19, 7, 51, 905, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourses_Classes_ClassId",
                table: "ClassCourses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourses_Courses_CourseId",
                table: "ClassCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
