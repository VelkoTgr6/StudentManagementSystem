using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedFunctionalityToStudentWithAddedAbsencesAndremarksClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remark",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Аbsence",
                table: "Students");

            migrationBuilder.CreateTable(
                name: "Absences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Absence Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of Absence")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Absences_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Absences_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Remarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Remark Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RemarkText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Remark Text"),
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier"),
                    TeacherId = table.Column<int>(type: "int", nullable: false, comment: "Teacher Identifier"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remarks_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Remarks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Remarks_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbe93904-6c92-4248-a57d-a57c410527a6", "AQAAAAIAAYagAAAAEOUIR2tEbuCa/9SMqCoftjqwe49Pg5bD9J9/Pb7qGzYIZXcc0mT1v5ue975d/VFr9Q==", "19e2c51d-828e-41f3-bd7d-d3c902ed4833" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2fb7fb7-244d-4486-97e3-f39ff2c10cda", "AQAAAAIAAYagAAAAEDlEH2OtdgyybY3TL7yaW9HvvwLwmYHqLg+fdVZDxxNYb7aNeg34ndRu7wunM4gD+g==", "795b70e5-bc45-4c59-bd72-7121dcc8a81c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc4b73cd-40f2-4374-9d88-d6d16d91c672", "AQAAAAIAAYagAAAAEPXB7OpDgtF9Y2kmxcvQ+oTCwhn/ys51FlkO698glx9Fy6AGu06F5SPmQs2VvAw+Gw==", "eb349acc-e73a-4066-bb96-d0c237d49f2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feeb403f-7d51-4300-88bf-af371a21c51c", "AQAAAAIAAYagAAAAEKduZRsftaesAiyZ/thZr00bCU9Za3vwA0mMdz2IgPIJUubMo2Ip0AiScnlXuwXvTg==", "4b3c2e8a-b003-4c5f-b1c5-6bcca05fb980" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f01f3af5-31dd-4d8c-98d4-fc2918bccc7b", "AQAAAAIAAYagAAAAEM1CoLaGK3sZl/QSiOGO3nV7UP9YOlbL2gbs5wuwvrZX+rol/4IeNwhGPwx8+Ugpsg==", "d8d422f5-8061-4a74-9368-dcee90290232" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a53957c-39d0-46c4-b8b1-0d3e2ef69057", "AQAAAAIAAYagAAAAEOGSZd8TEOrfRKH5KzThKECc5ry67s3l32sDbz0nyno+u/x+4ZsDb65mbNh9+bl94A==", "9cf81cde-e916-4e15-afbc-d76a1f2593a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "180d0862-494f-4d29-987f-e8eec437c6da", "AQAAAAIAAYagAAAAEOIxStveyafKDwovolnTSucQYKuQNZZ+H91qaSWwdjJVmWOpA1FGQxXffUXToyHtjQ==", "42d910f6-99cb-4737-bec8-04279c0b2755" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0a4cd80-9723-4b3d-a256-3dc787b5e91e", "AQAAAAIAAYagAAAAEHJCqkiSXoryRLWPO086qZ3EfBAU+2Wb8wafdwASog9wqVr2eIcrnUK/ygIcQBtTWA==", "feb6c8cd-c69e-4dd2-a238-bec1b672ced4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c246a499-77f3-478d-abf4-61421840da13", "AQAAAAIAAYagAAAAEGlPe5FkAWcLLeTqs3jwOpw584ZVHe1z3S43NhxwRkNehb+bMe+pvYJM03Q43MM/iA==", "d9ca6c3e-f66e-498c-8087-88a40162fec1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88544682-0a53-44a0-b674-909f631db22b", "AQAAAAIAAYagAAAAEAhZ+x3a3M2zH+qUTEpTrkC6fA+XOMxGRhSEzp47iEKknHXRSEQGc09T6F1iVFRogw==", "7296814b-25f3-4cca-b242-360d7fc2b9cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c174610f-bfc1-4d5b-a28f-926db7e6c4ec", "AQAAAAIAAYagAAAAEK7bxY2aEOZsboWhdhclgPvfTAta/hJJZLAmm4r8oDgrayOrKxUArNfet18pW/N+4w==", "49c10b3f-553a-42ec-9b44-90b150e304dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd92be96-d1e6-4252-bc05-26b68b1e51cc", "AQAAAAIAAYagAAAAECim1A1JfLjail09vGR3LZ+l4Ng4azj2BHrfg5NxIrlOV4rAItw2jhb7W8xTcuKSUw==", "e822ac42-ff43-4682-b686-70359057a612" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a32d326c-6ae7-499d-acbf-d34bfc820505", "AQAAAAIAAYagAAAAEKehPU44TfHERi6KBKuROYyJcTilMp8SqJpwXcAs9jstHtdW4ImLWTB2tRwxNjLiVA==", "22efffa6-7339-4d4c-ae4d-2cf4236c75a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1cff9c5-8122-498b-9973-48400f373900", "AQAAAAIAAYagAAAAEEewgsAzQEASdTqnVSw9P8hYVYRL+jP+K+Et4SHNo86Uxqa/RbB90eROFmRx7gDPCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed967c59-331b-48e2-8a76-d3d3903e9894", "AQAAAAIAAYagAAAAEMJfpNnisCCCVg1Em078smF3fAUBer5mZr7Jwsu9g7U+GH7zGgSzcoTWaqQ1WMNXrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a6b9d85-41fd-403a-a891-d8a097a3b54d", "AQAAAAIAAYagAAAAEDO9zkqyB0ZHFp+GwFWW3mPYrwJPKQ8/ZWcE7JBBjQJ6H9eoc4XXJaQ3jYoR2N2FEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "00547323-e122-4472-b956-dc3dc99ad78f", "AQAAAAIAAYagAAAAEPsJ0QmwFrkME6BZ3+QhayI2OyKdNLeSKO4w8pLh7DrDAPzcS4SL1KJz6UjJFKzeeg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d12ba407-d6d0-4b58-a986-79ebedf3de45", "AQAAAAIAAYagAAAAEK0uQZAMqR/LZFhEomrJf3XL9mA/Db6wMtnYMtngHpYQuKe3JstARrsc2Ipe+lXvxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9044da8f-ab9b-4f59-ab4a-8a066e811f2c", "AQAAAAIAAYagAAAAEG6+f36I32joCapm6Du5d19IKdiSUXA3umpoUIVn5izRjWBAx1vnVHa1eTY1IA2eCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b68c593-d005-40cc-8e4e-7b052cb5e9b5", "AQAAAAIAAYagAAAAECraA0h706iPGRMDG8D/somUkc8cAwm0LQ8gsVlrnx2b9ARv4OyLSadt995d5xJlKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e40ba31-ea81-42c8-a78a-b727a5251274", "AQAAAAIAAYagAAAAEC+nyxS9cHUkKupOWxxxMZw0s7+6yB63ks73GficqpvgNd4eXJt265zNS7r7sGRl4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "743513c2-6126-4914-97fa-20a3f608bd18", "AQAAAAIAAYagAAAAEGYTfonC9242P+ObfRIjzcg8t+qGDZ32LYLSksYZgvAZN8bjCbBEkXgcX6/KDCYOqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56c28b5f-437f-4e61-a044-4faf6acc3299", "AQAAAAIAAYagAAAAEOXiVlO3JaGcYP6i22c8hb8jYS17YL58M3L9QszAtBSyhSYTFCTY9A6HYLD4BD/92g==", "a6a8b234-8715-42b1-ab07-c7135f7fa1c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c28dbbcd-ece1-4643-ac6e-4358cdfd98c9", "AQAAAAIAAYagAAAAEOUnzkFIzRAUO3w+Y+f3DpaWWJBGLO+VP290zyTg7j3vA4hIJmMuq2O9wDWYMp6/GQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d2baa21-0221-4347-8955-3a0191788b84", "AQAAAAIAAYagAAAAEMry9fsnEadvB/NJY7Qsg6zn7SGfDho2BGUG67E7K7NSSjJZ/b6RGsmlAWFZvJOmvA==", "7bf973d7-d85a-4352-ae41-b6287482b998" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c6f4ff5-86c9-4d3e-88fd-a1b545406769", "AQAAAAIAAYagAAAAEI3MgPRFgM+Gwoj0VIzGpSiygw+G1XUAgY7FSYvkuFz6tnEkcAm2CHwdD5Yx6mALeA==", "3e2e1baa-0ee6-4c2a-9818-d4de9715acf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb6748bc-3ef2-4038-ae7c-7c5126bf5704", "AQAAAAIAAYagAAAAEJ2TtOUub1jfN3FAKPqsgjWuDYGvZs6A1UaTy43SOoulI0saGoL/nkqXDsXquXnfYA==", "baea44cf-261e-44ce-8856-6ad5477ff18f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cc936cf-d292-467e-8106-1f28be38dcf2", "AQAAAAIAAYagAAAAELAWHCvHvY0vXWiCWw63WM6TZ9p/0cJKTl1xcBNTpO0n2w6jlbgWZgcU36VY8FGkXw==", "95fb46bf-3907-4b0e-93ae-5b39fe54a900" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f010cc47-3564-43ac-bfcd-69fb9177f199", "AQAAAAIAAYagAAAAEM/s94aGfzOVZlHMpvItAI3ZR5zqxxXJPSBRHdjZ7/dK6NkEN5M0NDdqjd5ooL2bbQ==", "7898f115-3c45-4fa3-bbd2-556f634b88ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23474dba-26e8-4193-b093-8ea142ccc510", "AQAAAAIAAYagAAAAEOBrtyAcyPWvwhwfdBwLXSYRIjVvvtNYuBnZbY4Cl5wNPa/aLvz7fABaiuN+E4E7Lg==", "55e836b1-fb7a-47e3-8a99-10ccf370e4be" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 20, 23, 31, 22, 93, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.CreateIndex(
                name: "IX_Absences_CourseId",
                table: "Absences",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Absences_StudentId",
                table: "Absences",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_CourseId",
                table: "Remarks",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_StudentId",
                table: "Remarks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_TeacherId",
                table: "Remarks",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absences");

            migrationBuilder.DropTable(
                name: "Remarks");

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "Students",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "Remarks about the student");

            migrationBuilder.AddColumn<double>(
                name: "Аbsence",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                comment: "Shows if student is Active");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "465d045d-e248-4ea4-aa28-dbbcc505721a", "AQAAAAIAAYagAAAAELHrSX0sxbLPJg3ET2UUyzG2CSYwnL3v9Y8BS80ZECZ5D6btYd2H3DaZiNKmPn5Deg==", "673fb029-0c84-451f-a6d2-f3eb9b7c763a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22420630-799f-4346-814c-315e23fa5baa", "AQAAAAIAAYagAAAAEB37JrzMRrfZO+WWpujpHEx0TmvLKNrssdYMRJYik0kTkzqVubpUlnWDPQ86qF/ogw==", "f80b343c-bed2-4bb4-8396-866da19e9926" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30ba4375-e977-451e-80fb-a885b258a26d", "AQAAAAIAAYagAAAAEPTXRX+5VNOoa27Zhi48q7nyVcelxRoec0vvUgWxVD9zj4xJjxLH0LN0fHzqhm0olQ==", "17bc388a-d85c-4604-ba81-7088a09f6fa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2cc22b5-6319-4f5f-829e-7e978b80f0fe", "AQAAAAIAAYagAAAAEOdX7j+eQ/+7rqG8OQMrg9mTCrShgwiNedxtL82vAGIy54McaBCoVC8JqSEj+d1amA==", "7915a03b-5cf1-4ff9-a4e2-42bdeb14a2b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71bbf25e-549c-4d19-b1bf-6a11394a62e8", "AQAAAAIAAYagAAAAEBzijO3mkfli5Gp7tb8fVMiCxrd4zWglvRmF4vzhYTLpfqA98RJmD8a9RXPm5JtPKg==", "b98977af-140d-4406-9b7b-e462ac3999f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e36e497d-d3f1-48dd-87e4-981672c833b6", "AQAAAAIAAYagAAAAEAlrf1/tZ5OCnxHEKTJ5Neo3yg1NaCH+9RwBuLiUMdran/nzhO4mV63IvOv7QU3qZQ==", "21ccadb4-39e8-454c-b967-1f1105987357" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6017bb07-50df-40cb-a491-659d77763d06", "AQAAAAIAAYagAAAAEBW47z5qjNuqXua3mxj46YiC0w3GoqhyjYnOG+dnEI2mWwrIMTdEjYtpoEO70XwsEg==", "f572cb2a-7c0e-49cc-a29f-432c4fc7d8ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b25ec2d7-c0c6-4820-b296-8926071087e7", "AQAAAAIAAYagAAAAEKm4rMPCyBl9/xeVSPqyExAet6dBNnkGnAVp7ul1Le1NTOM8IgF9tFg9EVYyabXJvg==", "5cb3bf82-4436-4be6-afe3-c3638a3fa652" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d64e3cbd-0faa-4d13-9f81-bcd5add4834a", "AQAAAAIAAYagAAAAEBvNWWYRO1JhI/CQASd7gGxz55njySH4iS4fHD9YHJhkl/eJBEDoI1QXQDrtkplbwQ==", "3d7d5b88-d022-4479-8902-edc9eb2175b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "069d615b-e4e8-402f-98f7-7ebbac2a1592", "AQAAAAIAAYagAAAAEO0Qcm9OTjiX+yQrx1eGtsjBooAwZviYtu2+7p6/zGAX4ziIBmqyPRd1Ulou9fC38Q==", "b50f4043-6705-4101-b829-a24e76dfe73a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0dfda5d-27ee-4609-a816-cccc47ecfab7", "AQAAAAIAAYagAAAAEO+Tk6Gc2nJJyP9ue6170o0Jekw3dDeYc8x5J3wdIvORuj1MOVJyXy5RPJ3sUWnp4w==", "9599a599-9b5a-4b39-b1fb-94f094ede191" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0815301a-6b72-49df-9379-0d08acbc549e", "AQAAAAIAAYagAAAAEG8aTGmiSZU53u1h9XZ63UK9YLJiATaNT76UhInHTkgFWYqkFyGzysfjooTa/UfntA==", "c8ccc63c-8c85-464f-a15e-d47429a66058" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2bef8f2-9033-4e0a-ba47-75a1d6645fc7", "AQAAAAIAAYagAAAAEO4Q27INihRqaphnIZO+ABUWclvWU0OhiVGqgZilorB3y6ZKvaH4joZfloFZIdlIfA==", "6265a54d-c3ac-4389-b469-8bf4770b6a7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a39e8fd-5650-4dd8-ac79-1cd0dfe0803f", "AQAAAAIAAYagAAAAENuTUXe4SxEhur+AEADLskC8B/HWWza1/MxPhPyEQ8y2o57eDeXueczDTzXE2/tHmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55ea6fec-c087-4beb-be3f-585120e88c12", "AQAAAAIAAYagAAAAEI+wdLqE1lgUYkCMJ59lI8B9GJfhij1CxpFdmJHRiup9UoOObEBG/isQBC9O0/U9pw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c93797a-5208-4395-899f-1cd0459fe897", "AQAAAAIAAYagAAAAEDQzMa8z2uTl02ce7aV5ZecHtN5WcacqCVJz8v0X0LhqFLKJGM4nPkOAFqpiQ26TBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71164e91-c0af-4621-ba30-6d43919b2bb3", "AQAAAAIAAYagAAAAEKsg6bdPKZvSTbat9S8kCbCEg4SWzkRY9IScvg81iptHmFrc4YG2IV5doyKveXG/Tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "413d704e-32fd-4c39-809b-f67bd477bb4a", "AQAAAAIAAYagAAAAEPzlsNBnSKhgxdYKar5lfZUqxJBNDjeTLoxNin69Do1aFYzYhqyVHYWWU0QsdnwWKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b03beef-7747-4a9c-86ed-e355142f1925", "AQAAAAIAAYagAAAAEGMpUC3FdIYedxazctIq3Py81GtrapPOkEamp3iQak6EjvvNdn/rBTf81R01BxYE8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1d51a57-248f-4e2d-8992-0c62334d4e17", "AQAAAAIAAYagAAAAEPLb72xKAiJCnsj03EhEn/2VTkeHt7/0B/LCrnUirGnCYFQJruVhxYJ5WZL/4g01SA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af6623d6-5fcf-492d-b252-ce3eae7af050", "AQAAAAIAAYagAAAAEKzYCbhHVCLcDIrzozwXGlI2ksYF8FxixEV8tWYBPi8MeMwG9rpr49Pp1vU8ZUHGMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfcac21d-013e-4c12-835f-6396c5abc9d0", "AQAAAAIAAYagAAAAEIujUMT8rdeMXUKk6Bjt2DIR76I/rXmqdjipPDFBS4K8t1JRA+zBWthRwX03Nx4ynA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d52d0e24-c1a7-47d7-b422-9313003dcbd4", "AQAAAAIAAYagAAAAENvy5eOymlsv3yFpu/ACWOYgxuB/qWMMT8SVkWLDmje4RaqI6Up7Z7Sbb09MQHt7Nw==", "71bb5d7f-6098-4f17-a052-78e3a8b04c28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d8e61cf-1459-4bfb-908e-ac31e7ac4ce7", "AQAAAAIAAYagAAAAEEKhQ5Hyeq7aMT3+/S+1Q+2jxdliUxMackI2ykcNdRRZpv8fhfojjyYlELSmokWRvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9c878c3-2e03-4efc-b74d-6699692c8dff", "AQAAAAIAAYagAAAAEK4JctkzDhgNaj3KWt/nucv/J6ADbC4q6pW8dbBpv+ubNHSWl9UtphjdrE+CFT90RQ==", "4fe92041-94ff-4357-ab01-767aed3fee90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32febbf0-d79c-449d-87e7-7eb314921463", "AQAAAAIAAYagAAAAEBTARElucHXvam7vRe7Jyrm8EimudugByciN8HdxpVrdu04mo9s3V0FjEf/QKJw6gQ==", "f8037f41-dde9-49e3-afd2-b9c8e03ca73a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc0a6d8c-5d1e-4ec7-b166-526f52dee6c0", "AQAAAAIAAYagAAAAEA9ynP4I3DDU50e8nGvWMeGyflPqA/OSf1oUcTgpGqFT03jTid7yiSUvP/7mzZBvCg==", "4206df03-6ba5-47b6-8c00-fa7ddf2bd5bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f1a048c-ded0-4a6e-8526-3b1002695e2d", "AQAAAAIAAYagAAAAEEtreY3DH5quxHoVbelifVj7VBtLZhcLDmvDc9FoiC1zD5miW3687lK/d/JTt03mJA==", "f45af3bb-fddf-4eea-87ee-5c03680e54b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9904ad01-e303-4952-a815-5c73d2420a8f", "AQAAAAIAAYagAAAAEMMMPJtJIVk5QWI0mjy4OX/LQVtpwH+RSyz8bmk9ljuvjUsXGJB/JDvti+SEC+crew==", "7987a3b9-c605-4686-9211-6c2ea9b7e855" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca7308d1-fd7f-4fa2-8cba-0a0f2baa0438", "AQAAAAIAAYagAAAAEAg8BEFeC/uArHDmKHe1/Kgbhx5BGKEQ5QW5yXVqaBw5WQnQVFjZScXfDI2TeaoSyA==", "739bd31a-1669-469f-908e-565fdee18cb7" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1669), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2007, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1775), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2007, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1779), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1783), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2008, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1786), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2005, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1791), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2004, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1807), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2003, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1812), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2002, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1823), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2001, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1827), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2004, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1835), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2003, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1839), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2005, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1842), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1846), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2004, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1850), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2006, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1869), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2002, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1873), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2003, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1876), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2008, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1880), null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateOfBirth", "Remark", "Аbsence" },
                values: new object[] { new DateTime(2005, 11, 19, 0, 57, 57, 367, DateTimeKind.Local).AddTicks(1884), null, 0.0 });
        }
    }
}
