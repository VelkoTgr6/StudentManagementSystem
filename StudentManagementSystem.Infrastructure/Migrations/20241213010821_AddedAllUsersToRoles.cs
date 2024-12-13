using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllUsersToRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "01185cf1-525d-478a-ad05-b9629573333a" },
                    { "2", "030ddabd-7dcb-46ca-bab6-3feeae3492a8" },
                    { "2", "04b6c6b1-5f9b-4c7a-9f42-86193c03d327" },
                    { "3", "0c4b8988-22f2-4ed5-8486-85e757a97e41" },
                    { "3", "1a688e82-f609-47af-a359-d8bcdd62b5e9" },
                    { "3", "217e3e65-026d-4a8e-97af-a4fb30dfab30" },
                    { "2", "291cc1a8-8f2c-4f48-a919-ff4d9692a859" },
                    { "2", "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45" },
                    { "3", "2e830c43-2ce2-462d-9880-be8aa1e71696" },
                    { "3", "3034c6c5-e1f5-4655-9baf-079f41605550" },
                    { "3", "325092c7-9882-40d9-854b-32326c2bd43b" },
                    { "2", "32739a60-8250-4178-a19c-96d90444ebd3" },
                    { "2", "331d08d0-d407-4d61-af6e-1bb134ae7998" },
                    { "2", "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729" },
                    { "3", "3a76fd9d-a1bb-48f2-9626-1122ecf2d797" },
                    { "2", "6b6433a7-3564-4cba-ace2-4a44afca4177" },
                    { "3", "8eb86d7d-02f7-477d-8e6f-539d7c155930" },
                    { "3", "8f7bca8f-059f-4750-8bfe-7def13ef37e8" },
                    { "2", "9ab8c775-88c0-4dc3-b11d-178c3ca2129" },
                    { "3", "ab696b9f-f5d2-45a0-8495-96e2d2a01acc" },
                    { "3", "b65e6163-1454-4164-9869-2ff822f9da98" },
                    { "3", "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf" },
                    { "3", "c5d7d80f-08d5-41ec-892c-30833098c047" },
                    { "3", "c64af0f1-3716-4e30-b5f7-b0c5153e2b01" },
                    { "3", "cab3584a-da3f-4858-a65a-3f7bde9e553f" },
                    { "3", "e0e396e6-53f2-40e9-8013-664b8a8dbd46" },
                    { "3", "e8264a26-ea76-44c4-a013-12759599a081" },
                    { "3", "f2875100-0cf1-4b1d-ba91-1dfa38690f84" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01185cf1-525d-478a-ad05-b9629573333a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f808fb82-3223-457a-9bf6-d741b032a0ba", "AQAAAAIAAYagAAAAEPfN7cVrwiBk2XAUB0HKDutS6UlHxNThzhpTWCuEXO3XSLEbb9R4G5+njJJV1hkpcQ==", "5261b14e-86f4-40fc-93ad-f1ca0ce59940" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "030ddabd-7dcb-46ca-bab6-3feeae3492a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66d56365-8f79-4c42-a467-edab44ffe6db", "AQAAAAIAAYagAAAAEKdMIdtfAcpGYG5pJHjUfPKmZKYHi5sO5yXcYtmjF9SFk3YDq5xR5a09cgMgUnRVZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04b6c6b1-5f9b-4c7a-9f42-86193c03d327",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a96bf2c4-c7ff-401e-a085-fe27177ad45f", "AQAAAAIAAYagAAAAEJv3whSvgBFNKvNDI6R7rcRvlwasFbfLmv+qNnGcwfcPfe4mq3Jlb4SQazgDwAv4Tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4b8988-22f2-4ed5-8486-85e757a97e41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "192768b5-3b7c-4bd6-8952-34af0356a8f7", "AQAAAAIAAYagAAAAEH5TxruX/X1pwTUSMKZAXDOlpfW1Vp8PeJeto7fT8sU3zjMfROXGxI987rhj4M7eIA==", "a208b3fc-1313-422d-839c-de6257ac6980" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a688e82-f609-47af-a359-d8bcdd62b5e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f88b4b6-7735-4528-b401-ad094d4c9380", "AQAAAAIAAYagAAAAEICjM5lQuO1kg1r5rLaHKdUPlwRw8OfDfqTCluMVQywSVSa+kd/4kBaEJk7Iw2IiYg==", "ae03b779-09a9-4ee7-a34b-3c13c59a7e7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "217e3e65-026d-4a8e-97af-a4fb30dfab30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5509d13-214a-4fb4-8f2e-3b6fc444fcd8", "AQAAAAIAAYagAAAAEDoSU51I96tTVVJ/mGUw0M02uYNCjUQ3DeN46PvRLSBu3RYeTOtuVcKZK4kMoBV3tg==", "40dac1c7-2039-4b09-b3e0-9ba45c8d71b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291cc1a8-8f2c-4f48-a919-ff4d9692a859",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb7fe41c-3bad-4556-ba71-d72407f266b5", "AQAAAAIAAYagAAAAEEKasCUNZ02pENYjDf/0BPFyRNDoVwA1wS9+I4H8XqjcnhBpyVwXk6ntBmwjkJWv5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7b306d9-02df-4ba0-b448-0edeff00619d", "AQAAAAIAAYagAAAAEAYzd9YUWgaZC+MP8Fb4NAV0TUbLy0TRydeUMkIXbMVWdfa1W0pYHX6fKht0QF2aTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e830c43-2ce2-462d-9880-be8aa1e71696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ed77a03-4da4-48d6-9e77-9a526a6e8001", "AQAAAAIAAYagAAAAEH8TKoA75cEjD0Mcex3DDNWa99KrbzsosCcbOPC6+lcH/yo2RjTpC9QJbgr5CvlSew==", "34aa9694-07b7-4feb-a294-a42280bbdbc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3034c6c5-e1f5-4655-9baf-079f41605550",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a48c4078-5a9e-435a-af6d-b49586063b03", "AQAAAAIAAYagAAAAEKfioD3gtb4S858LKagBxTZS9ARx+8SbnypZXIyqRgEa3G+c6YcJ0Wn93xFUPSuLfw==", "154c550d-443c-4a9f-aa11-4045a5279371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "325092c7-9882-40d9-854b-32326c2bd43b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04c389df-8310-4c01-8105-5cc22e049889", "AQAAAAIAAYagAAAAEMQhj1UUhIfYR2eQ2MRPj3JcSHLGyXF3QXSz5i+hRhdSQNY8aJDPHwA4ryyJ2hMzMA==", "051fb213-b976-4d97-b75a-cdbce8c72861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32739a60-8250-4178-a19c-96d90444ebd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16890940-1932-46d7-b2d6-1633a6dece90", "AQAAAAIAAYagAAAAEOru8/hrUlFnB7vGSJt2g4xBzkI9G9UdBAxDYBMcldGkJCKC1SDOpZdJzWPANW1xSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331d08d0-d407-4d61-af6e-1bb134ae7998",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d097740d-2718-4a63-b451-2912cd75b001", "AQAAAAIAAYagAAAAEC+2YbwBuYgKsil95Ez7eKu8GoAs7tloPKb4TWKlbRK2oAMdjqaW2zNX+XnuaWHUWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2c99f66-56ae-4125-9dfb-77eeb1d6738d", "AQAAAAIAAYagAAAAEJFRA3GbpT0C7d+WvJMvK6+h9R9zpgAly4fgNi7eOKRdROCbeCXslLXJ9BB2Hn1Flg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a76fd9d-a1bb-48f2-9626-1122ecf2d797",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e7cc7da-23c3-4214-9783-f7330d657cb0", "AQAAAAIAAYagAAAAEDQk00RnB9yn1MSF1UmO/KudZ2iVy5PNrXALXsvkluhLq4TMLoKJ9Mt3aaqSVUmdlQ==", "dc2efb8d-7899-4e5c-87a4-4b567dc2c17e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51065229-23b9-402f-a54d-00bb813d6b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b577bda6-63d6-446c-b3bf-c358a103dc45", "AQAAAAIAAYagAAAAEKG4QOi5BU1x6hMiARWwbgu2k5XSWAMCivtBLorqAeBqPg+qzzymhQHgc5WB1JczVw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b6433a7-3564-4cba-ace2-4a44afca4177",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5153d92e-0c1e-4dbf-9cfb-094026e24dc3", "AQAAAAIAAYagAAAAEPGJher4Bgaa2BmP1xToQlKeWb4EUEPLBvmRLlHiFYw7+i4UEOalKloMTCNcS6jQnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8eb86d7d-02f7-477d-8e6f-539d7c155930",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84c7d331-8f0b-4235-9b9d-af813ae093e9", "AQAAAAIAAYagAAAAEIrPuGccfADT8fEo6Xb2Pqqf4VkzblLQXRN6K+Ebmgebh9/oB9gnSQsKDIaQbn4Bbg==", "ada8121f-a12d-426e-9633-cf4a0e34b77c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f7bca8f-059f-4750-8bfe-7def13ef37e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2feec87-721c-475a-9f0b-3d0cbc2c8f92", "AQAAAAIAAYagAAAAELapdXp4jY2/kNF92Cw6v35MCT73VaUpK9mj569JZXqyYv6D8O6ikACPAjK/A+PeYA==", "f33dca15-d29d-4931-8e1e-e35a048440d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab8c775-88c0-4dc3-b11d-178c3ca2129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49eb4218-4166-47a8-806a-feb23e7f4de5", "AQAAAAIAAYagAAAAEFwALQVfVtDhephlVvP+BGhaiokFN/arFzQRJrag3MRpequEvAaz/1Z7rGoGecbVQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e897b050-b02e-48c4-bd73-0646af9bef77", "AQAAAAIAAYagAAAAEC6NI5TtPwjz7/eSRJgrbnYpddAmT/2a518iqVeBsi5fsvs9Xin/YtxS1kRSdl1LUw==", "002094be-1705-4dc7-89b3-ff5bbd67ce3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab696b9f-f5d2-45a0-8495-96e2d2a01acc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a364784-1948-45c2-892e-1060d3f2164b", "AQAAAAIAAYagAAAAEDWlwD8MU5d0KsSuxQ9TZCRkoelFIiQsj1OrlHuFQF5AkpFKB3wZcCh28xH02WnIrA==", "2e05681c-385c-41ca-a31b-2772aa912272" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b65e6163-1454-4164-9869-2ff822f9da98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b84028d-e88b-44da-aa01-f553392d0740", "AQAAAAIAAYagAAAAEHVnxKn69HHEz+A1uBBiP4GaK4+vZYuOcmTVSIeTuC1y4HUr9fUQp8Scjw2m9rRAsA==", "d9fd8a82-0d98-48d2-b56d-bdfc6c862a92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "184a48c8-0597-4ded-8bcd-0cf304aafd46", "AQAAAAIAAYagAAAAENWkd5ofzuQNoTj7hZ5ZUZ2/DGMfZE45kZgTfsjFZvOjdHsN+AYR3mRYfw3SN9jo7A==", "71d42bce-9733-4e98-acaa-f02f82993746" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5048e86-d246-4b30-a551-cb0e164f6873", "AQAAAAIAAYagAAAAEJUdATb88aCB25zydjpGTh3hdFK7tHWcXSdVL0xy5o+xuReccaofs0iDIbPoEPEyqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5d7d80f-08d5-41ec-892c-30833098c047",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f041ee9f-0533-4888-be76-b234357b8361", "AQAAAAIAAYagAAAAEMTtk7l8tjz577MXc3XKRasBBEfGm5gJ+0swFSA7YA75NYjEAEuLJfokC5aP/RsWEA==", "ae11acf6-6796-483a-affc-539687a17ab1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c64af0f1-3716-4e30-b5f7-b0c5153e2b01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23836fad-34ff-4420-8a2f-a00b68b607e8", "AQAAAAIAAYagAAAAECJKkEdfJGght0eLaAnDRs5hng0W2gga/HZcFFoXfgyLdtRcePotsotvrlp18YFXcw==", "95c844c0-bc02-4e49-a165-fdb7113332fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cab3584a-da3f-4858-a65a-3f7bde9e553f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "befe0c14-db70-4119-8c3f-49580df44ac1", "AQAAAAIAAYagAAAAEJ0JJtVE6rERA/IgEjRdmFzfvVltjGPeYkHQIHoAMJiLXtk2NrcM4AX15Ozd4OrOcQ==", "869e5787-10dd-470d-820c-278df141a188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0e396e6-53f2-40e9-8013-664b8a8dbd46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "621e960f-770c-4a16-b231-a77314c8af35", "AQAAAAIAAYagAAAAEIIyrS+wHUC0ZEIKP/xfGlODSO5zlfmvU3Ynnx9wpj7LW3RLWE0+FwOa0J0CUudFjQ==", "9cc7f927-24f7-4d69-919a-85d735bf6ba0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8264a26-ea76-44c4-a013-12759599a081",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6261ca3e-286c-4323-8ae2-78be1d63db30", "AQAAAAIAAYagAAAAEKii4byiBjmE8zuF8hrPti2dJJB8f/uxwLI7Mkwh+ng/QdhMfEGpHgpi1ryDB3vA6Q==", "161a23f9-7c00-4098-ab99-bf84cc42b919" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2875100-0cf1-4b1d-ba91-1dfa38690f84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "851b7a93-4ab1-45c1-9a11-cad9da913a6b", "AQAAAAIAAYagAAAAEASu0NXJXF+FQ7tlQY51TCWoA5F49ETOInLU9RfF2hqjEHxzG1Vk/P098CIuEHxnqA==", "a2090034-4969-40e6-820e-c4b52b1a1ad9" });

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 5,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 6,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 7,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 8,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 10,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 11,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 12,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 13,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 14,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 15,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 18,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 19,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 20,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 21,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 22,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 23,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 24,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 25,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 27,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 28,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 29,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 30,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 31,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 32,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 33,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 34,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 36,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 38,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 39,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 40,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 41,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 42,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 43,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 44,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 45,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 46,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 47,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 48,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 49,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 50,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 51,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 52,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 53,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 54,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 55,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 57,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 58,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 59,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 60,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 61,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 62,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 63,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 64,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 65,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 66,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 67,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 68,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 71,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 72,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 73,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 75,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 76,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 77,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 78,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 79,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 80,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 81,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 82,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 83,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 84,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 85,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 86,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 87,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 88,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 89,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 90,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 91,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 92,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 93,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 94,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 95,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 96,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 97,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 98,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 99,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 100,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 101,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 102,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 103,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 104,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 105,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 106,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 107,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 108,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 109,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 110,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 111,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 112,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 113,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 114,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 115,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 116,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 117,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 118,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 119,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 120,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 121,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 122,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 123,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 124,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 125,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 126,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 127,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 128,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 130,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 131,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 132,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 133,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 135,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 136,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 137,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 138,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 140,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 141,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 142,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 143,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 144,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 145,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 146,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 147,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 148,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 149,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 150,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 151,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 152,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 153,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 154,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 155,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 156,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 157,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 158,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 159,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 160,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 161,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 162,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 163,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 165,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 166,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 167,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 169,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 170,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 171,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 172,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 173,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 174,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 175,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 176,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 177,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 178,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 179,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 180,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 181,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 182,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 184,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 185,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 186,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 187,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 188,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 189,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 190,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 191,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 192,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 193,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 194,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 195,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 196,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 197,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 198,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 199,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 200,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 201,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 203,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 204,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 206,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 207,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 208,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 209,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 210,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 211,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 212,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 213,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 214,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 215,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 216,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 217,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 218,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 219,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 220,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 222,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 223,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 224,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 225,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 226,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 227,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 228,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 229,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 230,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 231,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 232,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 233,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 234,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 236,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 237,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 238,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 239,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 240,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 241,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 242,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 243,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 244,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 246,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 247,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 249,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 250,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 251,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 252,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 253,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 255,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 256,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 257,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 259,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 260,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 261,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 262,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 263,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 265,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 266,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 268,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 269,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 270,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 271,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 272,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 275,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 276,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 277,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 278,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 279,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 280,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4117), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4163), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4170), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4179), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4193), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4198), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4206), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4244), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4445), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4454), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4466), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4479), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4484), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4491), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4496), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4504), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4509), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4516), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4529), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4534), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4541), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4546), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4559), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4571), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4648), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4653), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 44,
                column: "GradeAssignedDate",
                value: new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4681), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4689), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4695), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4702), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4714), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4720), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4727), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4732), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4745), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4752), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 57,
                column: "GradeAssignedDate",
                value: new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4764), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4787), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4804), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 74,
                column: "GradeAssignedDate",
                value: new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4823), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4828), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4841), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4848), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4863), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4884), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4889), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4902), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4909), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4914), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4991), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(4997), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5004), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5009), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5018), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5023), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5030), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5035), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5042), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5048), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5064), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5077), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5094), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5107), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5114), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5120), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5127), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5150), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5165), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5173), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5178), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5185), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5191), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5199), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5204), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5211), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5216), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5228), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5236), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5257), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5264), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5269), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5344), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5349), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5363), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5370), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5375), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5382), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 144,
                column: "GradeAssignedDate",
                value: new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5395), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5400), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5407), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5412), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5434), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5442), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 152,
                column: "GradeAssignedDate",
                value: new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5455), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5460), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5480), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5485), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5502), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5507), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5515), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5520), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5528), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5533), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5540), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5545), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5552), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5557), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5565), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5577), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5590), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5604), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5653), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5658), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5666), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5689), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5694), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5701), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5706), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5719), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5726), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5731), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5751), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5756), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5774), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5788), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5796), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5801), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5808), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5814), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5821), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5826), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5834), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5839), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5846), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5851), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5858), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5873), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5880), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5885), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5893), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5898), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5910), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5922), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 3, 8, 19, 870, DateTimeKind.Local).AddTicks(5980), 3.0 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 8, new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 6, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 6, new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 6, new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 4, new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 8, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 7, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 8, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 5, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 10, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 1, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 9, new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 1, new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 7, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 3, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 10, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 10, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 7, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 1, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 4, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 6, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 7, new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 10, new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 4, new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 6, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 8, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 8, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 8, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 8, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 10, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 6, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 8, new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 6, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 8, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 9, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 8, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 7, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 9, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 10, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 7, new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 13, 3, 8, 19, 869, DateTimeKind.Local).AddTicks(9198));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "01185cf1-525d-478a-ad05-b9629573333a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "030ddabd-7dcb-46ca-bab6-3feeae3492a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "04b6c6b1-5f9b-4c7a-9f42-86193c03d327" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "0c4b8988-22f2-4ed5-8486-85e757a97e41" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "1a688e82-f609-47af-a359-d8bcdd62b5e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "217e3e65-026d-4a8e-97af-a4fb30dfab30" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "291cc1a8-8f2c-4f48-a919-ff4d9692a859" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "2e830c43-2ce2-462d-9880-be8aa1e71696" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3034c6c5-e1f5-4655-9baf-079f41605550" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "325092c7-9882-40d9-854b-32326c2bd43b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "32739a60-8250-4178-a19c-96d90444ebd3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "331d08d0-d407-4d61-af6e-1bb134ae7998" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3a76fd9d-a1bb-48f2-9626-1122ecf2d797" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "6b6433a7-3564-4cba-ace2-4a44afca4177" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "8eb86d7d-02f7-477d-8e6f-539d7c155930" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "8f7bca8f-059f-4750-8bfe-7def13ef37e8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "9ab8c775-88c0-4dc3-b11d-178c3ca2129" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "ab696b9f-f5d2-45a0-8495-96e2d2a01acc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "b65e6163-1454-4164-9869-2ff822f9da98" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "c5d7d80f-08d5-41ec-892c-30833098c047" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "c64af0f1-3716-4e30-b5f7-b0c5153e2b01" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "cab3584a-da3f-4858-a65a-3f7bde9e553f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "e0e396e6-53f2-40e9-8013-664b8a8dbd46" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "e8264a26-ea76-44c4-a013-12759599a081" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "f2875100-0cf1-4b1d-ba91-1dfa38690f84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01185cf1-525d-478a-ad05-b9629573333a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e836dc17-f8a6-48d6-873c-cc41cf164d5a", "AQAAAAIAAYagAAAAEJJ/Z/6fMGaOT4zVB6EaO68V9nXVezHrIZrJzRtUqpTOp5nYMvkHcyLwGUQ7p6mI9g==", "1811e567-6036-43f5-82e6-7fb78f285ace" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "030ddabd-7dcb-46ca-bab6-3feeae3492a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6194740b-2b27-4b3b-8061-a67b58d495b4", "AQAAAAIAAYagAAAAEIkw5njYBB0XXLdsFT0V9Upeq95TEiyfHfAIPJvh6WUDG9sGiw15qPuoArMhfx3rRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04b6c6b1-5f9b-4c7a-9f42-86193c03d327",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88b3938a-0762-4c0f-82d3-3c4e40a49f8f", "AQAAAAIAAYagAAAAEFY+KOG+RH+IQY+AI97L1wN6bLg5ji+/3KeUhGs2eDMhfXirwSenWMpPck9nGG4hmw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4b8988-22f2-4ed5-8486-85e757a97e41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a47e778-4db1-40d5-9b80-bdd8c3d7375c", "AQAAAAIAAYagAAAAEL9+ACNatoSxC8P15jsozcBeaQis1mvpOI1ttpPlY2aDPDs3EE1n7T/WAc+2SvAsSw==", "90153888-f1a2-445a-a405-c38e03c4371d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a688e82-f609-47af-a359-d8bcdd62b5e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1887479-bad8-428a-82ab-1dd7bf525ca3", "AQAAAAIAAYagAAAAEIFHIWnqdIixik/II0EaAWDSIdz5w7XSR0023DgjqAMkRKMchU7s+l1s9ieE0ZTzKA==", "dde8cd67-fe88-4105-b221-cb8bd852e1ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "217e3e65-026d-4a8e-97af-a4fb30dfab30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "445d2304-9fd1-4517-9388-badd67b70a9b", "AQAAAAIAAYagAAAAECKSebDwS/LUUBIf54frh8RVoIRSzV5bHpq9zi3hdd7QrVmei6s0FUzEYr50Rl3aag==", "de395585-cef0-4345-bbef-4b44eca4ffdc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291cc1a8-8f2c-4f48-a919-ff4d9692a859",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "efce7386-a059-4efe-b890-4f56b576a86e", "AQAAAAIAAYagAAAAELv/1X7gVLI35BjWgSbIjGuQ+dVv4Sw0bO2eHeEdWangtZL8sMwwBOM8LLDBcqKUsQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75b6389f-1f52-482b-ae33-0b96bfb5b10a", "AQAAAAIAAYagAAAAEL6Omph1TATQ12TVEeNDqhZwwQsqdET12zGNgNVBHFYgFBBXKwj47G0hillklNuLLA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e830c43-2ce2-462d-9880-be8aa1e71696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41adb0f2-db38-45ab-a22b-caf38f3c62b2", "AQAAAAIAAYagAAAAEFuSgU62Uwc2Yog/Xw+V5QB7KXiHaMrPqgTpVvZ2HyGX1kZT3D9oCYnOjiQtz4luVg==", "c18e0cea-25d5-4d0d-a058-ff70d5c031cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3034c6c5-e1f5-4655-9baf-079f41605550",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe4c5c27-b705-4627-9add-6b4e0c117146", "AQAAAAIAAYagAAAAELulHn7qWhl+b76d1oKdhogKMmYXaA5JM8wtGR5ZZcycK3n8nbXUucy4BrJ83b8HdQ==", "cb6787fc-d87f-4897-aff4-7a0676211c1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "325092c7-9882-40d9-854b-32326c2bd43b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "016990c0-62c2-40ca-8706-d6bbde7b1bfc", "AQAAAAIAAYagAAAAEL4LNMxXciRWkcQga5puSPvwGu+cedtpzvCLe8sfQ4HmQDqXWe5Zbq7hsQClpdxoIg==", "2f01a7f6-a167-4b28-86fc-ae0ce9503c97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32739a60-8250-4178-a19c-96d90444ebd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecf4e685-d6fc-492b-875d-7a219a5c736f", "AQAAAAIAAYagAAAAEHDKtaIt7gpsdS6jzoDLUR52Mk4Am4M6D9ZeWrVhVIrd4U7+fC3bF/T0njSKgohJMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331d08d0-d407-4d61-af6e-1bb134ae7998",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0345eee3-dc2b-462f-a88a-19c5c769ccc1", "AQAAAAIAAYagAAAAEOzInmVjzhCAFMkT/vGSy7zBA/vY43njy68et0JRJcSooNgztrCLJ6OUmc9YeA9DZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ca966f7-1c11-4a56-b54c-f6fc91035886", "AQAAAAIAAYagAAAAEOpPfDVNvj11kfucnZx6a0nd3fa4nmJ/tsCBfWXCRKUE9kI0/A3imsMrr0/hq38zuQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a76fd9d-a1bb-48f2-9626-1122ecf2d797",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "670d95d6-2b56-4b10-8351-fd7f4c38faa1", "AQAAAAIAAYagAAAAEBJRwEl/hnGPsJKjaR+ooAYKkivUBVCacd6v15GU6lwpGgGDr9QvSHH5ButYDZi48w==", "b65f84dc-d257-458c-85d8-4d420cc01851" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51065229-23b9-402f-a54d-00bb813d6b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f47c29bf-1c89-4951-8522-9cf6ccf38a50", "AQAAAAIAAYagAAAAENAYL5gVjxvrYIfrpUPcotcYjGvUUz+dtFlU+RZjPa8Mp8A4G/Z4yhvNppZT8h+/+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b6433a7-3564-4cba-ace2-4a44afca4177",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e49c02a-59b2-40a9-bad6-84d166c6d55f", "AQAAAAIAAYagAAAAEGi6i8T/LQVgCcq7uqOLoPgHlXzHfLX9B85LzwOOpUyiZrlT9/esTz8siRVziMqIrg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8eb86d7d-02f7-477d-8e6f-539d7c155930",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64a8dc65-9d30-4b72-b451-2204ba760b2b", "AQAAAAIAAYagAAAAEBfy8yyshjLkZOYN5U5XiY35CpOvKvaxoBZP4cSFeO2oBIUihSpV3bYemdxvq7fKHQ==", "03094960-a168-4d7c-b197-4829c080f6a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f7bca8f-059f-4750-8bfe-7def13ef37e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "015a16db-4032-45d6-86fb-b9caf2f91b55", "AQAAAAIAAYagAAAAEKIs0N8n7lE/xF7r+1NDMFhbMQs/i1Y6hByOY+j5GgYJMrLt+tzHjBD87r1/EfNmnQ==", "4a66746c-d731-4bb5-91c0-494d8ff02df9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab8c775-88c0-4dc3-b11d-178c3ca2129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c08bc709-5ef8-48b6-991f-6f43cf969825", "AQAAAAIAAYagAAAAECbeREgEETbNUMsSYGupzoj5UK9srNuStYWATeViza4UnYG3pNijThYXOUvIY9pcmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b42a254-c80d-4380-812e-8ff46336f08b", "AQAAAAIAAYagAAAAEBdrCSjNg0OgFEikWzvtnnJzWo2cjBgXGw7zYdEmj/MnMpuSI29qWOV6oW6MB8OEvA==", "2c13b562-d7a4-420e-b69f-52e06dbce4a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab696b9f-f5d2-45a0-8495-96e2d2a01acc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e00cd349-6f71-4966-9c57-2dc79344ad49", "AQAAAAIAAYagAAAAEJHYm+xXC6RMnEdt09R8Ve4P/wsesoIEKyr1mNTfTVw6eSaTp3ECKb3z/MkvVHoPjg==", "d950711c-4313-47b3-89ef-9af4b81018eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b65e6163-1454-4164-9869-2ff822f9da98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b84e4906-b929-4ca8-9ae1-c6612848be50", "AQAAAAIAAYagAAAAEOtZGqSvJmKEQ3Fq4qqtr4wxTSE5wgGrDaR8/uG+yvF3Dn9P5ZCASIfcdZg6MA8HrA==", "d41e6f61-67f0-4bb4-b362-d48fccd31d27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9641e9eb-a218-4e06-8653-e6ec8865964f", "AQAAAAIAAYagAAAAEB+bYy8SuvyaM20lSMMrLo3deXW+ChtipgvcDBL/lDoi4TbXi+Dm3OBbZXGsohhM5w==", "80ba976e-0424-4f4c-9cfd-3276190275db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "137b1722-667e-4008-9888-7a861a0145a2", "AQAAAAIAAYagAAAAEBIfmh97tv6IB/19oB+bnIqQ9v/yaqq+8lF4qG1/xbU7NtKgG7UvFoDArhP8jJcmiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5d7d80f-08d5-41ec-892c-30833098c047",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb570d96-2b68-4496-a010-bc51d25b3ec1", "AQAAAAIAAYagAAAAEEs/YwZ0zMNzvyXn8L30zWIgPmInqDsq30Va3MJjszwvyopIyyZwjx+hcTam8cA77w==", "b48a0b7c-cb51-4373-9530-74c01e906d96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c64af0f1-3716-4e30-b5f7-b0c5153e2b01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afeb9b2e-e169-4bdc-be71-9215deb7e130", "AQAAAAIAAYagAAAAEF9g6HQOkalIcMPly8Ipj7buqQLqUHLxxYnSNgY+CjhA+pt/AbK7TsCabORi+Oh6wg==", "674f370e-ddc2-470f-9458-3948520a24cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cab3584a-da3f-4858-a65a-3f7bde9e553f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "863c960b-2d66-4867-81e2-7d1b7c6740ac", "AQAAAAIAAYagAAAAEKzDOCKSErIYcGf97i4tmfr6TF+hHvAIMIOE3Df6MTWi+Uu7QsgLAC+GNEJ4g2kFRQ==", "c88f94d3-8aeb-4799-9ff0-150ee82b1643" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0e396e6-53f2-40e9-8013-664b8a8dbd46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16109f65-d295-49cf-96e4-25e33f250c22", "AQAAAAIAAYagAAAAEETQj3l5c90Orxe7GrlDQs6arHr74yMjesJaniwLO4GlBJhYj2RIRj0dJtipcmrxJg==", "bfc5cf01-24fc-46b8-bea4-3b46dc29f208" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8264a26-ea76-44c4-a013-12759599a081",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71255b66-5cac-4d36-b31e-be845857843f", "AQAAAAIAAYagAAAAEAKtqXglfMrAoNTj2WUtPf/Q3sqhTVr/L6y58ti+DDhWWjG0Xye1qReAQhSloSHaVQ==", "800ec447-6f9e-4c91-800a-0cab86f103ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2875100-0cf1-4b1d-ba91-1dfa38690f84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1be232d9-229c-4cdb-b6db-943cf2891d65", "AQAAAAIAAYagAAAAEPxT4evzLuCz5n6PEUsSTTBuXX55xjViR//pkcBAg/UW/SomYLVbOPfXxOrhgCB5Rg==", "63ba19ed-10f6-4776-bd09-1f09520eeb7a" });

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 5,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 6,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 7,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 8,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 10,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 11,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 12,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 13,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 14,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 15,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 18,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 19,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 20,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 21,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 22,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 23,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 24,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 25,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 27,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 28,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 29,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 30,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 31,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 32,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 33,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 34,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 36,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 38,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 39,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 40,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 41,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 42,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 43,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 44,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 45,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 46,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 47,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 48,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 49,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 50,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 51,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 52,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 53,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 54,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 55,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 57,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 58,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 59,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 60,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 61,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 62,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 63,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 64,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 65,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 66,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 67,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 68,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 71,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 72,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 73,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 75,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 76,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 77,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 78,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 79,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 80,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 81,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 82,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 83,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 84,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 85,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 86,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 87,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 88,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 89,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 90,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 91,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 92,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 93,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 94,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 95,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 96,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 97,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 98,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 99,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 100,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 101,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 102,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 103,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 104,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 105,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 106,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 107,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 108,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 109,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 110,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 111,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 112,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 113,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 114,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 115,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 116,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 117,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 118,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 119,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 120,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 121,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 122,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 123,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 124,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 125,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 126,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 127,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 128,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 130,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 131,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 132,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 133,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 135,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 136,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 137,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 138,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 140,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 141,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 142,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 143,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 144,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 145,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 146,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 147,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 148,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 149,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 150,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 151,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 152,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 153,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 154,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 155,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 156,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 157,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 158,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 159,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 160,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 161,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 162,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 163,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 165,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 166,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 167,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 169,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 170,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 171,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 172,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 173,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 174,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 175,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 176,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 177,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 178,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 179,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 180,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 181,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 182,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 184,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 185,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 186,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 187,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 188,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 189,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 190,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 191,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 192,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 193,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 194,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 195,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 196,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 197,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 198,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 199,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 200,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 201,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 203,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 204,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 206,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 207,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 208,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 209,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 210,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 211,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 212,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 213,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 214,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 215,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 216,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 217,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 218,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 219,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 220,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 222,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 223,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 224,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 225,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 226,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 227,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 228,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 229,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 230,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 231,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 232,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 233,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 234,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 236,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 237,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 238,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 239,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 240,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 241,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 242,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 243,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 244,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 246,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 247,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 249,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 250,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 251,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 252,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 253,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 255,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 256,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 257,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 259,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 260,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 261,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 262,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 263,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 265,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 266,
                column: "CourseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 268,
                column: "CourseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 269,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 270,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 271,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 272,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 275,
                column: "CourseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 276,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 277,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 278,
                column: "CourseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 279,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 280,
                column: "CourseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3648), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3713), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3719), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3727), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3741), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3746), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3754), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3777), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3824), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3833), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3847), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3860), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3865), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3873), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3878), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3885), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3891), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3899), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3912), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3917), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3925), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3930), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3943), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4034), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4041), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4047), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 44,
                column: "GradeAssignedDate",
                value: new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4060), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4068), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4074), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4082), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4095), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4100), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4108), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4113), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4126), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4134), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 57,
                column: "GradeAssignedDate",
                value: new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4146), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4160), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4178), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 74,
                column: "GradeAssignedDate",
                value: new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4199), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4204), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4217), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4225), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4230), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4252), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4257), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4271), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4320), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4325), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4333), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4338), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4346), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4351), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4360), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4365), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4373), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4378), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4386), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4391), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4399), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4412), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4430), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4444), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4451), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4456), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4464), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4477), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4482), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4490), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4496), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4503), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4509), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4517), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4522), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4530), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4535), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4548), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4556), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4561), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4607), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4612), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4620), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4625), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4639), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4646), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4652), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4659), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 144,
                column: "GradeAssignedDate",
                value: new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4672), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4678), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4685), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4690), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4703), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4711), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 152,
                column: "GradeAssignedDate",
                value: new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4724), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4729), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4750), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4755), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4763), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4768), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4776), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4781), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4789), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4794), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4802), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4808), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4815), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4820), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4828), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4841), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4893), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4898), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4907), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4912), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4920), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4933), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4939), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4946), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4952), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4965), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4972), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4978), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4998), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "GradeAssignedDate", "GradeScore" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5004), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5012), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5017), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5042), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5047), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5055), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5060), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5068), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5074), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5082), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5087), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5095), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5100), 2.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5108), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5113), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5121), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5126), 1.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5134), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5139), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5209), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CourseId", "GradeAssignedDate" },
                values: new object[] { 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5224), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CourseId", "GradeAssignedDate", "GradeScore" },
                values: new object[] { 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5231), 5.0 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 9, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 2, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 6, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 7, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 9, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 8, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 10, new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 7, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 6, new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 7, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 1, new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 4, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 5, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 7, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 8, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 7, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 9, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 2, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 4, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 2, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 9, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 9, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 9, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 2, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 4, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 10, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 9, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 10, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Date" },
                values: new object[] { 5, new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 1, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 10, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 9, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "TeacherId" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 3, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 4, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 6, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Date", "TeacherId" },
                values: new object[] { 5, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 13, 2, 58, 25, 415, DateTimeKind.Local).AddTicks(9174));
        }
    }
}
