using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[,]
                {
                    { "1", "Administrator", "ADMINISTRATOR", "a1b2c3d4-e5f6-7890-abcd-ef1234567890" },
                    { "2", "Teacher", "TEACHER", "b2c3d4e5-f678-90ab-cdef-1234567890ab" },
                    { "3", "Student", "STUDENT", "c3d4e5f6-7890-abcd-ef12-34567890abcd" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "51065229-23b9-402f-a54d-00bb813d6b1c" },
                    { "3", "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c" },
                    { "1", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "51065229-23b9-402f-a54d-00bb813d6b1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01185cf1-525d-478a-ad05-b9629573333a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18e10bf4-2903-48fb-bf3b-b20b07a9f0ff", "AQAAAAIAAYagAAAAEIVEVLs9jtxodtCOetKpjpg2qf1bX3EvBjOdYpNySwXOxcmDJsPz0upAYnEdLdRjxw==", "ca40bcc6-c108-4e1c-95a9-aa9d4da1b8ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "030ddabd-7dcb-46ca-bab6-3feeae3492a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c146ae7b-5854-409f-93dd-6d9f4312b78f", "AQAAAAIAAYagAAAAEBVtuMBulRrNO8Q4mttGcbJoUxvACfRka1qwZ/jYq+yYSiEXlEFNBQqoB7Z2MyF7BQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04b6c6b1-5f9b-4c7a-9f42-86193c03d327",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21ce1668-e41e-4755-8e72-335246e14008", "AQAAAAIAAYagAAAAEPK5H7qGL9aGBJJGEbKLE7QKtgJJQERRJJqAJa1kmr6Vy9UzjrtzJ0crqL5QbEgQLA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4b8988-22f2-4ed5-8486-85e757a97e41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8258b9d3-9fa5-45bc-a902-38561e253f90", "AQAAAAIAAYagAAAAEJMpSn3Ae3mDLss7BEKs2XAuA8uOn5KYV0GUtkZW6zf0F1f1bgmbYCNBos+kUimkDg==", "ca7a7574-c3f7-42a0-bdd9-e4dada7355aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a688e82-f609-47af-a359-d8bcdd62b5e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23dc6944-d135-4716-bba0-378c3b5a3986", "AQAAAAIAAYagAAAAEM5Y6TC3GRGyluzrQMqy9O44fso4Qyvt8xyXQOcsA1fIpHRvDmP10TZm9TMcuTMOCg==", "1ba63c74-363e-4bba-b637-25d0117bfdd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "217e3e65-026d-4a8e-97af-a4fb30dfab30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57538733-9d42-4a23-80a9-9f79738c66ff", "AQAAAAIAAYagAAAAEBjEvPYpeuvbSHy0vDkvl7XujHpPU1iyBo7pw8Xc+1Czci2L/zJNueLCwzp2RsnEOA==", "c777ddc7-0ee9-4bb4-b220-b846508edd1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291cc1a8-8f2c-4f48-a919-ff4d9692a859",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b2d2bcb-c8c0-4357-a137-92ee18df498d", "AQAAAAIAAYagAAAAEBpagpXCTcBjDlnzOSU3qroBef/6xEEydtb8l5UyDay5vsKWzxTBxIFzU5ZSg2ZkqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03a1eb22-4739-4532-a2c3-e1b633785c6a", "AQAAAAIAAYagAAAAEOPqLjTyai5Ib1ykWldRr++0Ju1ZLrReLphUuBHZ/p0dBZGrTGHjihEwxudsmYzGzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e830c43-2ce2-462d-9880-be8aa1e71696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "147055f0-ec4b-4bd2-af25-a4fa7f903a6d", "AQAAAAIAAYagAAAAEH90cW3a74b6ozXZB0EBxTqMpTL+V5RhLz0uL2LhKp4nJZeuHjTt/YwYtdhoFZOBuA==", "8f1bc6d1-4ed6-49fa-9535-7d14aeed8fdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3034c6c5-e1f5-4655-9baf-079f41605550",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "975e8422-37da-4f40-9df3-008592754f8c", "AQAAAAIAAYagAAAAEE+qK7nb6eYgWWHV31hJ8VfWbfSXigRKxKS5H5gyaKRdDdNXO1ldivRSBtCo8T9T0A==", "d2220536-d1f1-4b47-8a0b-0929d49cbe8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "325092c7-9882-40d9-854b-32326c2bd43b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca4cea5b-c748-4fe5-bdc1-87774de9d5f4", "AQAAAAIAAYagAAAAEN5A4DhvMjqNkj7gN07rSozkYdHMAp8JGbO9nPg2bfFSjF/t8I84WAkUnW4ynNiVGg==", "ad27bd21-c809-44ee-a877-c4aa3ae7d45e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32739a60-8250-4178-a19c-96d90444ebd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2c04772-f6c2-4188-b699-6af66854cad4", "AQAAAAIAAYagAAAAEJXkiXy2b88+hrXXnBTOtiXW+nIdMKqxl7WsLgVg9YGYGyRBxoab6ckA0NeGccg5Bg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331d08d0-d407-4d61-af6e-1bb134ae7998",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f066c8db-ff0a-487e-9c31-3c8ba200c0c0", "AQAAAAIAAYagAAAAEOi8O8XveFggqxKfJ6Yh4XxPWeFONSzGZEocDF9CwrDgTVIRK1GOtKKk+IRG5ixFhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a093b88d-b511-4d34-9217-1d7ab51883d9", "AQAAAAIAAYagAAAAEM5WG82OQyWdxPoLPS0UKCrQurBU0uuQriv+ab+Ug7BNTc8+8LQCuAjWkTT77rv6jA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a76fd9d-a1bb-48f2-9626-1122ecf2d797",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed855d3e-dd3d-4af2-bf3d-afa797b3c988", "AQAAAAIAAYagAAAAELtH677YqCYDs/FhhA5SHkrp4RbLQsLkuPwdpZAWBYp0P2V0EEmNTfiq9bO4VX8LFQ==", "db36e8a4-c906-4b53-8a99-931042879caa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51065229-23b9-402f-a54d-00bb813d6b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b099ae8a-1b4c-45e5-a20d-36f43a54abff", "AQAAAAIAAYagAAAAEBMv5Wo/nluycNn90nEilbgWyPOFHcITm1TSQNgU13C89pp0zi/UcWOmSR+tvvT4Ww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b6433a7-3564-4cba-ace2-4a44afca4177",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5153322f-c92c-4e7e-baf0-ba11a71c0064", "AQAAAAIAAYagAAAAEGojZpKdlYxqKy5pzLiNvHwTYJHBnH6EoAvRQg9Jy/TqhHsqiY2FOSxb0qlwNYGO9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8eb86d7d-02f7-477d-8e6f-539d7c155930",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d7a8725-5706-4496-90a7-bd5a9117460c", "AQAAAAIAAYagAAAAEPMXLzdhJDOAGd1m6TLEngCozcADv2FMTa687rF5Lxl541lt5e4b7uCTpp9sCrHadA==", "c6a028c0-4aa3-45f7-8fb8-8cc95eb315b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f7bca8f-059f-4750-8bfe-7def13ef37e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bc6332f-8b45-4f71-b917-215975cd3226", "AQAAAAIAAYagAAAAEAcC9Laiq+L1M5ZW9MBquNPnTsevAq/YONDV9g6QDKzdybjuDd+idmOZ9rn6WHC48A==", "bac408c4-f6ff-46d9-90ef-673b58b6a48c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab8c775-88c0-4dc3-b11d-178c3ca2129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6f349f9-9bac-4eb5-9936-28aeca2c8c57", "AQAAAAIAAYagAAAAEOOJbrIDvZV12gigC/tnLvRT+kcq8NfDGJXcI6eyWIcpQ193DA2vJTOuQ35OBawZ9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c9c73ca-deea-4fd7-848f-389a2cded275", "AQAAAAIAAYagAAAAEDLSsQb5h95pGMIAKpLKEh+HJRrpuQuQarf0/gY8Ec7NWe2YVhmKwUOsKSqeRnrlRA==", "5fbfb1ff-8247-4948-8171-abac0cba2c65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab696b9f-f5d2-45a0-8495-96e2d2a01acc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eca0878-186b-44e0-9c1a-b71fee724994", "AQAAAAIAAYagAAAAECjC4YCKH82SbMoQuCGYIsvMg6/0xSYn//fVEDHUSBZ8lAuLsgoPCskJ5QKp6pezUw==", "ac141018-9f09-4e96-8739-3b710172859c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b65e6163-1454-4164-9869-2ff822f9da98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0ca5c7e-58de-49fd-935e-fd550162b1b7", "AQAAAAIAAYagAAAAEMdZOB0UrZ7/woEwg0q4DVNBqwmlKDX9hc2CyScKWI0OgqQZWpyUN106rXKElsq51w==", "249b7092-01ca-4c22-b7f0-513160250b56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "023ce682-199d-46cf-a705-2f1cba132dbe", "AQAAAAIAAYagAAAAEFeMMGOKnmpI2y3SgyTvf76zSdBCpIdSy/4GhBZMftzV7mRQLezObBx3q+f34ub7Xg==", "83e1289b-5346-4e68-ae68-965825ab8bc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "635bf612-1a20-4c9e-a9a6-cf8cffe7f6ee", "AQAAAAIAAYagAAAAEDibKH0bYBxdMxEl/aZFe4sDyL83LEDytqpQI9WR7b5zU3hqkGBYmSKplt6ss3/JOQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5d7d80f-08d5-41ec-892c-30833098c047",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "084dea89-73d5-40bc-9fd6-c01ec1228f1f", "AQAAAAIAAYagAAAAEJPORejjBwVz+sUFGl5sOAYrxjjhkA/+aCgfDmmZjm1+5NuOh7TC18TBCbR331bb4Q==", "e1f90d09-64a1-4ca3-9ce3-1b06ad1c392a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c64af0f1-3716-4e30-b5f7-b0c5153e2b01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1889e72a-a9ca-4c86-b024-209595bed942", "AQAAAAIAAYagAAAAEO095OSTCiM02BQyDnYcB9gUiN7atGaOyP47PODCG2O3Or9diJEZjJPilSAR4QeqpA==", "5cc31f0b-3657-427a-aee5-17060e15f91a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cab3584a-da3f-4858-a65a-3f7bde9e553f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb95564e-44e8-41ea-aa8a-92f0789afeff", "AQAAAAIAAYagAAAAEDJ+FdgGtRw8CyZ56yCp/2WlizssU07cavLzjDYnlFcwLsdNS+jhVJUCl+nR5d21lA==", "03eb8f0c-421a-48d9-b4f5-c1fba125b8c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0e396e6-53f2-40e9-8013-664b8a8dbd46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b0682da-a4fa-44c9-88ba-9526a03c6a89", "AQAAAAIAAYagAAAAEPMa/QAmmtr74+qm8BfTfc8v4o6jDQZc7EBCGooqSFlODwTXcwZb7URJU3dxPWN/Tw==", "36a7fa35-250c-4bae-8c21-4a5f97bda41e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8264a26-ea76-44c4-a013-12759599a081",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e80a736b-dbd9-4efc-99e3-d56367923e37", "AQAAAAIAAYagAAAAEPf6nOYCP6Oi67Bj/g0h1FWIvZlsZhCyjK2NrVN1+mg+gPgAPjCmAgsDp/ZzccPFRA==", "3063e2ff-46cf-40ce-a6d6-3675cbe2ff5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2875100-0cf1-4b1d-ba91-1dfa38690f84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38c81ea7-803a-488a-be3f-32d0ee6a9309", "AQAAAAIAAYagAAAAENSiyJxS9uHM2r6QfcvpCF0EM8gzMK4ak+3COc4VO1MiFeksIRLj7EauL4zKwMOdrg==", "bd044334-f1bb-43c1-9fd0-99c2d4cb61c7" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 12, 7, 0, 11, 15, 874, DateTimeKind.Local).AddTicks(5816));
        }
    }
}
