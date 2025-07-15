using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedDbSetIdentityRoleTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "51065229-23b9-402f-a54d-00bb813d6b1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01185cf1-525d-478a-ad05-b9629573333a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa1439c9-05e2-40fe-b12a-cbedeb76d5fb", "AQAAAAIAAYagAAAAEN5dOz4sVfsUoFB6Bm+TRU2q8GehUgB+etbdhtkGWTYRTsAn+P6zvyYn17UI7Z4hPA==", "0193428f-50bb-4556-89c4-f6b95fd98652" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "030ddabd-7dcb-46ca-bab6-3feeae3492a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2e32598-2623-44c1-84aa-160f06b9a9ca", "AQAAAAIAAYagAAAAENtL63ULo6ApNiTEx314evlrkcLc0nKpXCjzi366t2nmr/NKOae7p7HFockmyAQt6Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04b6c6b1-5f9b-4c7a-9f42-86193c03d327",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f8626b4-656b-43ff-965d-c4ae05f894fa", "AQAAAAIAAYagAAAAEBHXf+27b8lf2xe4baWOTeYHc7d3l3yqg6AlUB0PFy4XGDmoaf0d3JZCBYXERsnGZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4b8988-22f2-4ed5-8486-85e757a97e41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd3e8509-bbf8-4e85-804b-3a7e0c873412", "AQAAAAIAAYagAAAAEEjz5H/C3f6VBoyugayQYe8QaNHxDZ435TcIbO8xzF+8UimVxtjBiMkxde7Fyf7i9A==", "2fc0e4bb-90ac-4d11-956f-ce58afb958a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a688e82-f609-47af-a359-d8bcdd62b5e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b56feba-b4b8-458f-bd99-ad9eb11713a2", "AQAAAAIAAYagAAAAEAnlw48d0eLMdl87FIthvCAR3hYPcekghLwRflKSAUzKE04CL2ZVb2tAZK0UIdgZWQ==", "ce1fee01-e9ee-43a7-865f-afaa11f99081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "217e3e65-026d-4a8e-97af-a4fb30dfab30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1fe2ea8-9819-4957-9517-386b2b259bc3", "AQAAAAIAAYagAAAAEPF8PP/L6ct/+988+hC7D4SZFFe6pmK7udLOY2bcOKvIwOtBo3TsiIf4PBFjWn5Rng==", "b8ae32a1-6822-46ec-be50-3fb2d8bec816" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291cc1a8-8f2c-4f48-a919-ff4d9692a859",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15135e81-c5dd-4bf6-8b6b-e3955693d145", "AQAAAAIAAYagAAAAEJ56pj8hAaSTJUUBY1xD+AkON+89Vf63ZvKll/MfiFgbrYSNbDR1ERU34Uk/3gey3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b84b51ad-0987-4dba-8195-d09600477cf0", "AQAAAAIAAYagAAAAEGAIpJH2eK6fSUEuqNzeAjtKPDpepvY6smESRUrER44G3mHfh+/d2NZ+92oGlt6Ubg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e830c43-2ce2-462d-9880-be8aa1e71696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b4f29c8-1096-4079-ba46-ed740b2048fc", "AQAAAAIAAYagAAAAEHA/A0Gb1s3Sf2J7zpol6DpCNjT7Ghfdkw6Y+haS1pumghvgiYNHoBq46jdLYEWv0g==", "98522cd9-9b3c-4f80-84a7-616263b8b140" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3034c6c5-e1f5-4655-9baf-079f41605550",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1908543-17e6-4b81-9bab-db28a61ee026", "AQAAAAIAAYagAAAAEALi22HnH3tox88a3rnDjBX4xps4HpQHCvt6ag7sE891IKr344Uye1nnpBddKjSHKQ==", "ab6376f7-7531-4465-a110-d7c819cdbcef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "325092c7-9882-40d9-854b-32326c2bd43b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e76d891-eb1c-46aa-8b4e-950cc5969e1b", "AQAAAAIAAYagAAAAEFem+gMdnwJHN4hKg8pKRfiWsduVO6M1BvqsIW2+zWBY7k7HhUviwr3PIH56iYmEvA==", "45df2ebc-adf6-417d-bddd-29b571562ad9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32739a60-8250-4178-a19c-96d90444ebd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a0d5ae3-2d6d-40e7-a3f9-470cf5d7d18b", "AQAAAAIAAYagAAAAEK1hsW1xvjpP5LtrCj4qqHjGH37AjZlf1CV+92X0qDJYYyXt7vV3sNm8/VUtkwW1fg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331d08d0-d407-4d61-af6e-1bb134ae7998",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "735e00a5-8829-4728-b6bc-2f4d81bee59e", "AQAAAAIAAYagAAAAED9adYaxpCkan3G7QsgVKdAG5g1Mso2VaJxawW4d1LPplei3ev5KD4HQoQRlKXEwIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d969b05c-6a8f-450c-9370-f7b186aaa0bf", "AQAAAAIAAYagAAAAEIr3kYXHG9PLbJfLEC3jRTaLnUVsZ70SBfiB8H2BWRysDwQ9BtFV0v8QHbd5He3eOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a76fd9d-a1bb-48f2-9626-1122ecf2d797",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8305a95-3255-445d-828c-baeb18ca81ce", "AQAAAAIAAYagAAAAEMLTjH8DWSA0Rwk5thEQuzRDTlljZfHDMNKOc9Vd9TXMTsQRrDDgBgL9FMhqojmYTw==", "e82be895-ce23-4aa5-895b-00435e2e4259" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51065229-23b9-402f-a54d-00bb813d6b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa2b157c-45b8-4dc0-8853-58eed2bd1ced", "AQAAAAIAAYagAAAAEM20K88I4k5IoYPoFokxSTx9VSw9m0T1GlguU12ZtksV/VmxibD8pax/8XT4MW5XgA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b6433a7-3564-4cba-ace2-4a44afca4177",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "783326aa-d5d9-44d1-8c46-bbeffa019d60", "AQAAAAIAAYagAAAAELlKspvloImqf+Ix/nWvipVOfNXc4P3AKfkQKGyJz9DLv2ufl3rORrA3JyoRT5fKcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8eb86d7d-02f7-477d-8e6f-539d7c155930",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a918d6f-5288-4691-85ab-a0ffb9701c32", "AQAAAAIAAYagAAAAEHBBZjEEcnBw24PVrkBjf3z7Fo3DUyU6hTfUUFrJ8zMRvVnYlcdul0TZiK9/WK4/pQ==", "2842e4c9-7482-4f64-9ceb-d9e11701c94b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f7bca8f-059f-4750-8bfe-7def13ef37e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1c9b3b7-fe1b-4304-9997-85b70e9c448c", "AQAAAAIAAYagAAAAEHLjsleFqFRWMZOvMr3D47TevmQotHwGwzmiAAjz7JxFN7F/iNf73aJRaO77rx87lA==", "80495d11-0f52-4e2e-900d-4eb382348306" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab8c775-88c0-4dc3-b11d-178c3ca2129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc32a707-4978-4615-a993-74bb8234ddb2", "AQAAAAIAAYagAAAAELLntVGJEDFUZeZbSRZzOH7areIu0u+eB5P+uAS6VQrW33kbaBK8KJHVMYxXQJHamw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aa0f3da-d003-40cb-80d5-0e00ecf5a0c9", "AQAAAAIAAYagAAAAEMhy2i6Q0fNlHPHoa/DF0sjeQv2/hOenU7RXbOGMNCJlc3lp57ugB1+EkYahCQEIAw==", "039f6d7c-ed26-4e6c-b808-0fe6e843de77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab696b9f-f5d2-45a0-8495-96e2d2a01acc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90ba1a95-96b4-42de-916c-e09a54781274", "AQAAAAIAAYagAAAAEF/bzhqRriEbwMxfZLz0z8lI3uefdwSA0mkKDprIwSNLdQVySFI4JfStlY/VgtrE6A==", "8c94a352-3ac3-48d5-96eb-13fd6c364932" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b65e6163-1454-4164-9869-2ff822f9da98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d63aa808-eac7-4ff5-942b-8c9e18275c2b", "AQAAAAIAAYagAAAAENUY/gApl+J8f1v9MlHS4BDy0dTqi6FCe1ujyNPUgMRuUucJHFJuqQ50NpDOgYFsQg==", "563d282b-25c3-4ccb-9e93-09adc69c24db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "738ca739-402e-48c3-9f40-b6a56fe0e65c", "AQAAAAIAAYagAAAAEEeVbvE2CLIaPsBHvzsp7GXVMq86c7SUXEviBBYM4ASHhwFEfh/+pgIerQuT6Nhq4Q==", "d11d4b88-94e4-4faa-9942-4b7513c81e03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa79ebf2-bc04-48e9-83da-a795cb439606", "AQAAAAIAAYagAAAAEGvgjyFeuoUlXYzh5OBxqz+dYQboBJQe2QY5Sr7xXML20bmC4Ecpb/YFUCsIeAZISg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5d7d80f-08d5-41ec-892c-30833098c047",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "482d8c79-0d25-4d8f-b680-24ebd1eff164", "AQAAAAIAAYagAAAAENpDSvOymrnh6TwpTuPcZUlIqcVIHpql0RZdSqU6Fche0KeypFNcE8ob2lcFZSQLNw==", "aa2e6375-caeb-4abd-8f54-8465bff31db8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c64af0f1-3716-4e30-b5f7-b0c5153e2b01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecd2c165-4371-41a8-9b6c-91a8f83eebc5", "AQAAAAIAAYagAAAAEEn2JUQhpurhJQ0uZNRKARRrGUpMWS7I4PPthvrj3l5xuIkWiu3g/pnzVmcTzOojsw==", "06cc80d3-d991-413b-93cc-1b98cb95c4a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cab3584a-da3f-4858-a65a-3f7bde9e553f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8953fd7f-a19e-45f7-a6a0-976cd285a531", "AQAAAAIAAYagAAAAEMpFzSK6mS8iP3mQrze6n3I8NY1R3sydRze9FtK6pHguZrunHHnunBNKORQMGiOZCg==", "0886a17b-8d90-45f5-924d-330941849c2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0e396e6-53f2-40e9-8013-664b8a8dbd46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20b39438-bf16-4dbb-85a0-fa347616f587", "AQAAAAIAAYagAAAAECeuCeTNOQ9LAyUsqINe0WW62XkjRnx4lY9WdfPla7IzdQIbw51LhRDH0cenB0oX0g==", "6c43b6a8-4e57-44ef-af4d-9e351e919be8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8264a26-ea76-44c4-a013-12759599a081",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7a6f687-94fc-4228-8dea-082e8323fd3d", "AQAAAAIAAYagAAAAECBcFjIw6UGgKZw6H+D5P6z6OVXMlKPV/56N6kQxy52LcbdZ58w4K1xhSQ78FEyBbw==", "aebb12ae-8808-4ef3-8aa6-9cfa88d0e141" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2875100-0cf1-4b1d-ba91-1dfa38690f84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aca86de4-c0a3-4e88-b0ae-b9463cb1adda", "AQAAAAIAAYagAAAAEMmll7qNQqZtdl/qAD9dpejPMV4MUDrHmi+Jwk3K5xKzbf5YTVXMQVsJ4ZCjF3oqWQ==", "8e7e8d3b-48b7-409c-9147-3338f9797f4a" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2008, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2008, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2009, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2006, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2005, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2004, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2003, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2002, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2005, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2004, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2006, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2005, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2003, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2004, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2009, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2006, 7, 15, 21, 45, 27, 121, DateTimeKind.Utc).AddTicks(6766));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "51065229-23b9-402f-a54d-00bb813d6b1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01185cf1-525d-478a-ad05-b9629573333a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d8e540b-e695-47eb-8d03-ccd76c01d6c5", "AQAAAAIAAYagAAAAEBe28CpWskIb34Z1SpNI6ly3J0LUnSidMwdSbSdmeSK3MCh+b//y8+NQwmKjpmxA7A==", "5c4d270d-fc0c-4af7-af5e-759a2fd0c8cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "030ddabd-7dcb-46ca-bab6-3feeae3492a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68865dae-2dce-429d-8ef8-9359345c4501", "AQAAAAIAAYagAAAAEEL8qdVlTDoUoGjojUuLo3u4va+cUHzw6oKSW/Y75znmLgL3lCVrz74osPAzN7ekRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04b6c6b1-5f9b-4c7a-9f42-86193c03d327",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a47271a-a634-4119-948a-522f2a415d89", "AQAAAAIAAYagAAAAEHvZQvy5+rEGvTPSi7nZE7lRwkgL3NgJJf9sHh/aDC9CQ1EMbnHDCs8lROK1DFdQEw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4b8988-22f2-4ed5-8486-85e757a97e41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17c98ba2-f614-437d-8352-1fc990ce84f2", "AQAAAAIAAYagAAAAEHyo4a7M/o2AYdOioaMmggT23SYPBLofF72+O2r5mV6UQPtzbrY/5UCu7dMFHFJ34g==", "b62dc699-1061-4463-b88f-08f618e97739" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a688e82-f609-47af-a359-d8bcdd62b5e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b0efcd2-2830-40e1-ae24-12c10f134092", "AQAAAAIAAYagAAAAEIVLF2y91cY896s868vD0G8Hzea2bXuCVyCeJGp/9vFCMMxjeXnBvKdPoo8aiDMH3w==", "5daa12cb-3b75-4ded-bbb0-cfec49f18626" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "217e3e65-026d-4a8e-97af-a4fb30dfab30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38435cad-36d1-425c-a263-7c0639c9601d", "AQAAAAIAAYagAAAAEPfGOSaGmLa2na+KrtPmtRj2XcvEHx4ScaQhV7vB9iTpNyr8lgNGifxEyDfMNujzJg==", "a9da873f-3ea1-4fbe-b69a-348530721d0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291cc1a8-8f2c-4f48-a919-ff4d9692a859",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6494d34-0ebe-44de-ab48-c61e0e022b8a", "AQAAAAIAAYagAAAAEOnTS3R+W0bajQAIzmMIJ63smCgQKx2zmNfcFbuMf1561u1MV/ZXtUOPEBbBzrJkhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e0dbc31-9e66-4bc0-8ad1-70082674fe92", "AQAAAAIAAYagAAAAENk+fG5We5ldY6tl4OroWFD9+BBlqSAgl8T/bqftdwo3CLm+7SwR4kT18lMdPJ4fDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e830c43-2ce2-462d-9880-be8aa1e71696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d348ac1-570a-4288-a297-61b11b636837", "AQAAAAIAAYagAAAAEAxBEbOka07tSbvXNR7ponE+T6mL51tQCAN1oqNjjYauovV4B1X9rbEMjDoHbHyBfg==", "7dded76b-acf8-4864-9d07-fcf593d0eb66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3034c6c5-e1f5-4655-9baf-079f41605550",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "091cec20-5bd3-40f7-9377-24ceb6002bbc", "AQAAAAIAAYagAAAAENpDbfJZ3/jnwzQQnn/uWkwwm68cya76uEzdXAhV7H4bRg4Gu0LyB3YRDg2t4maMjQ==", "e170cc65-85d7-4eea-811f-32a5358344a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "325092c7-9882-40d9-854b-32326c2bd43b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6dadca4-d154-4739-a4bd-0c69ad93210d", "AQAAAAIAAYagAAAAEGIWShLMTcwITYvB4jOE7vowW0OYJk8K8DAKDDbxrjJ0ju8iDCrSG5dfS7o7BxFZmQ==", "58993309-dac5-4462-9dd8-5a7d6c1ef34f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32739a60-8250-4178-a19c-96d90444ebd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc464257-a3bd-494a-b36c-822ab77c204d", "AQAAAAIAAYagAAAAEPlnJtfwbYxSOosGJ+exQGtnRsvFy00ci/0NX0DZDyJoRr9fTrhhXW1jQfNgtBT5gw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331d08d0-d407-4d61-af6e-1bb134ae7998",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80f32fe6-6385-443f-bf7c-28e75301c1a2", "AQAAAAIAAYagAAAAEGhzCFH0Q6f9bemRZHvPyB1AR7rOv3TFwoai74iDun8gHplQohOLsE8lPCN4BxjoVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad8f7fbc-95a4-443a-b4bd-d3a180a1d395", "AQAAAAIAAYagAAAAENaX8QAxS3HLrv6SVq0jB8Xiqu8a4YpMd/v66T7ZqKkwJ1TGkMRhffyC36bZvZaCfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a76fd9d-a1bb-48f2-9626-1122ecf2d797",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc6bbc06-362e-4f7b-9204-0a5856765f5d", "AQAAAAIAAYagAAAAECLx1kdn9qsQra0VhQv5loYBaViOe31R411GF7sU7ltDCNiOomqq+NeeLWWV5Rkf3g==", "f4ff81ef-6457-4db8-9750-62f44063bf43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51065229-23b9-402f-a54d-00bb813d6b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d0de898-3dd9-49be-b248-d02b1bcd4488", "AQAAAAIAAYagAAAAEAKFsJCzJ5BhoiC4J50kPIedsI5qNF7X5LI/hokuTeFHEy2KF1p3TfBl3j09wYcysg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b6433a7-3564-4cba-ace2-4a44afca4177",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a99c8fb-2fcd-41d5-bee0-254821cef9a5", "AQAAAAIAAYagAAAAEL4FelnJ3vuChNCFXq3eNymWiSrjhLKjQWrl5JGKh/C0YdpkiPI1C1N29YmoAWWplA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8eb86d7d-02f7-477d-8e6f-539d7c155930",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60d66118-bcdd-4c00-8f0a-83852a9ed1ef", "AQAAAAIAAYagAAAAEAGhQVIgkATzcM7WDeaUzJ/MOKQ6H7mwGuNlXOPKKifrHkhD4tFM6MDYzXh9K0dwrQ==", "2c03180e-b210-45ca-8e04-8af9ada9864c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f7bca8f-059f-4750-8bfe-7def13ef37e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0126e565-a43f-4f24-b77b-d787b7b20a2b", "AQAAAAIAAYagAAAAEBY0RRn0ZpsybV8YyP7MzTkSXBJDGKveQPJUJugT8P3yBR5QOa3kvGRCKHqefHsUCA==", "9d49e9d8-7b96-478d-b4fe-590f25596585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab8c775-88c0-4dc3-b11d-178c3ca2129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4b74d9c-3ed1-4457-bfbe-1cfa457e7414", "AQAAAAIAAYagAAAAENBM9ZCL29qm9tucsLWI4iOsbQEtxA0a6279bjIH07DHb0xa/bGVuO2W80105PQvSA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edfaabe5-b851-4d0f-bd5c-bdf82efcf5e7", "AQAAAAIAAYagAAAAEKedaiP97T1rd6pCx7yWwx6fIL0HStltj8gVVH1JNQWSQlBIbtLlXcim1bCoo5W/oQ==", "f53aea71-83a2-44a4-99aa-3ee03e854057" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab696b9f-f5d2-45a0-8495-96e2d2a01acc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b81fb25f-1e03-4b31-8e65-c966dd4c0d59", "AQAAAAIAAYagAAAAEPGfnH/LHft9DjFOe/BPEE6Q0etd507j82RKVtAo1sZ+6VGidBhDFyOmgxgRFvvd6A==", "a60e0db7-1dbc-4971-8e9b-b347777af179" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b65e6163-1454-4164-9869-2ff822f9da98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f35deec8-afe0-43b7-bb94-90e147351e4e", "AQAAAAIAAYagAAAAEOiemBUmbe8peu6wDzXpcGWC3uJucz7FhW+sfqe7UJQUx4IJDz6extsC45w5E7lo4g==", "18ddfb08-6944-498c-b9dc-2919e5277a1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0775799d-ea4a-45f7-8c2d-ec663c3273f3", "AQAAAAIAAYagAAAAEIZmBaS8Vg7p633yJAoF+6QesqwfjEbu+kOyG4rptw2E+UDHIDXOPx3jFq3Wf9ZP9Q==", "26dd13f2-4717-4753-a8fb-088e14d72ac0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49ddda0f-2805-42a9-9233-4200a2d4765e", "AQAAAAIAAYagAAAAEAclnlGMCEgkD+FJ8GVE0BZdjRgdazd21U7etc2QArPQ49AznEKxfaVxeQ5r53Ieng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5d7d80f-08d5-41ec-892c-30833098c047",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3abc5d04-2b8c-4946-9d78-13e7f80ffb61", "AQAAAAIAAYagAAAAEDLk4odp961B1rLU5fzWzmaigMCkYRw5x/+xkZnotnB877wqYptVPf9x+syAfu8khw==", "91ceb9cb-936a-4681-9915-70e2b8d0659d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c64af0f1-3716-4e30-b5f7-b0c5153e2b01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "995d0474-69a7-4253-b9cd-cb11a9511d29", "AQAAAAIAAYagAAAAECLwkfZNCtRdwO/mFnJEClWxFsJm16r2bzwuNJuEiN6Oz4+EkvryLm8ENkQRzK7u0A==", "92f3af56-a1b7-434b-aaaa-fd1e2de301a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cab3584a-da3f-4858-a65a-3f7bde9e553f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "beda4cce-be65-43d1-a70a-ac5e5c83cb14", "AQAAAAIAAYagAAAAEItI81q2mQm4uu7tuOGyXYZSFrhy6pxljLxHQ+5NMOm4uW74V9kNGVeLzlZDl1A1Tw==", "ce281b32-cb02-4c51-b862-516f30b9a672" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0e396e6-53f2-40e9-8013-664b8a8dbd46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32870412-f3af-4f89-97ac-409ca2804118", "AQAAAAIAAYagAAAAECB7gcFAfR9hQJHts0Lenuqq11ueiksyzqfeaqqeF2R3YiRAgy2LJoFafPv2T6duDQ==", "9bbe1aaf-6be0-4aa9-8539-a9f5bdf0d364" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8264a26-ea76-44c4-a013-12759599a081",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6698b063-1ac4-4926-b981-b09683200f43", "AQAAAAIAAYagAAAAEPx7HZkgZLOC5nbn3smRExHZOtGGdiC8Pd2x2ouzO1ZbdJ3I+A/9zhpiOK2FpeWEtw==", "d5c9e228-4c56-4888-9766-c591ced0d159" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2875100-0cf1-4b1d-ba91-1dfa38690f84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9ff4b3c-14b6-4193-82f8-bc222c0362ec", "AQAAAAIAAYagAAAAEKI0Q1KgSu6eUfq7omTYIhPOIJphZQc5UALd096kE1g05MKbP0jLMLDpz2VrEgc7Lw==", "4498593b-dc16-45d2-bcca-b4701e5e49ba" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2008, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2008, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2009, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2006, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2005, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2004, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2003, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2002, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2005, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2004, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2006, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2005, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2003, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2004, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2009, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2006, 7, 15, 21, 37, 6, 209, DateTimeKind.Utc).AddTicks(8763));
        }
    }
}
