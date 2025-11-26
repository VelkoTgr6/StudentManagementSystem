using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedMissingUsersWithRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01185cf1-525d-478a-ad05-b9629573333a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df0e74d7-0b62-4a08-81f3-b643d45a97b1", "AQAAAAIAAYagAAAAEPH1T2qZ7ziGWIlUBuCFg/V/dV/W5z2gT5VJWFWNV2boZNSDq95cCgXSwrWtpL8FVg==", "40c5cbda-8b12-44c9-a94f-28ce99e68481" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "030ddabd-7dcb-46ca-bab6-3feeae3492a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f590b3c8-a30a-4323-ac04-fcbca8612093", "AQAAAAIAAYagAAAAENTeOSV2o82QibJcVp13t/4oZ/rvfippfFLYXJKOfQn3KlSzR2qY+wISAKauIzN11w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04b6c6b1-5f9b-4c7a-9f42-86193c03d327",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f2f10c1-cb66-4186-a9af-88cc6f331eae", "AQAAAAIAAYagAAAAECbE/4GIL94bbuGN8Jdb0uDAAI06W+ZTWL9XUB5Ns+rmYCb6oS26Il9SG/xX4HJuTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4b8988-22f2-4ed5-8486-85e757a97e41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1bbc55d-f0d0-4a2c-8258-1076970fce30", "AQAAAAIAAYagAAAAEC3mEGslwyfsFtjI7wHNOhkjD/0EnDr1zfWZujZLGlRReehJSPOeRMGSCshiNpvN4Q==", "443cbe66-ae29-441f-a38c-55cf2e4eab75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a688e82-f609-47af-a359-d8bcdd62b5e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71189db9-124a-410c-ae77-7e19d2b30895", "AQAAAAIAAYagAAAAEBhmVfCZDBDlz3fS2168YC4IgvCfXho97KPeih49qVQO1ygw8em91p++Qq+bMxAeyQ==", "ee2c5045-1eee-4c31-9e7d-6ab1773fa073" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "217e3e65-026d-4a8e-97af-a4fb30dfab30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2dd638e-65a2-45f5-b0f1-29eacbfec90c", "AQAAAAIAAYagAAAAEPjjGozeeDIi+TdkxwFO6caS2PlsY19gBE+oLtNGZwZrGRGC7Gr1eacRZTOBN90mkA==", "c6ac8d1e-c00b-4eeb-b364-7bac3fc34c32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291cc1a8-8f2c-4f48-a919-ff4d9692a859",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6647d3de-920a-4c58-be72-f954bf6171bf", "AQAAAAIAAYagAAAAEGTF/BR7/c+yc2gFEF/TDRLE9uqVECw+OethFvMY7eGTIgPLlI4PGxgVoBS7TVdyOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ad410b1-c108-4b9c-99f1-0f68dbd6ad45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3951f506-6fd6-46bb-9932-5941494d7551", "AQAAAAIAAYagAAAAEK8PxWPvgFxI6f35Z/Qpl70hd9LU0cT3Vbj8jDFtj2k+n/WPfZR1NHii6MY5XJ4NsQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e830c43-2ce2-462d-9880-be8aa1e71696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "873cae83-4df9-4b32-a537-923dbcf66b9d", "AQAAAAIAAYagAAAAEDF+Kn6VZJRhaizEXZlOHZah7YONAbMeZXWYoMMeAFBTxkI4OB17h3Pqy224nTK5SA==", "a2023310-1341-4cb3-86f3-09fbd6a25718" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3034c6c5-e1f5-4655-9baf-079f41605550",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0303f8da-024c-45d7-8fa5-025b21af9c44", "AQAAAAIAAYagAAAAENFVxM1eCjM68BSpCkRYzGN2oB6CvaQy9E+8onqdYq/HOygPU0j4drULbItlCtxenQ==", "3a0b349e-f344-460d-af4c-786df3779582" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "325092c7-9882-40d9-854b-32326c2bd43b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db949950-1bfb-4853-b012-e682254b0799", "AQAAAAIAAYagAAAAEBXXjl2EHSfEEQ6hWGnxpeE6R6lZ3T53KpqU0zEi2XoOjwsLLk07ZkFUR8l1R9ENkQ==", "fe254ba5-3e32-4594-b1ca-33f0cdc0ae45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32739a60-8250-4178-a19c-96d90444ebd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b022ec7b-e64b-4134-ac8b-fca688192881", "AQAAAAIAAYagAAAAEEcrvNs5BCdXGrayoPhHjavPDN/wLjCfq8ZtjSSIlmVbXvXK9a5dsHmxfQwbFtxmHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331d08d0-d407-4d61-af6e-1bb134ae7998",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b346115-2453-447f-9f4b-3993b1015bab", "AQAAAAIAAYagAAAAEJXuBlbghyBe1lHMdcC5nGeCgsaFt9OKKrfWloGkq8bkMCOyi9cIn044JNg+L9RxCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3647bea5-9ce4-4d8b-bf0f-7a5fbd3ea729",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eed93848-bc01-48a4-8912-b1542461ee4e", "AQAAAAIAAYagAAAAEEg7o6wvRqokHRwp/x0lx44GPHbrDcNxigb6Map5Lw3hkN3i3snrs+1NJ0ziLt0C1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a76fd9d-a1bb-48f2-9626-1122ecf2d797",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f7bb89c-99df-4d3c-8882-da0de4d9e689", "AQAAAAIAAYagAAAAEIpt0ivcA+ysMqGpYENg4oF8Jm6tgx8D7h76w2DGk5JexKoUCcfEuBQaEySTPMbbSQ==", "62c11bb7-e921-40d1-8427-c250ab56be45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51065229-23b9-402f-a54d-00bb813d6b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76a52652-b8a6-422f-992d-e556c5bf105d", "AQAAAAIAAYagAAAAEJP+PGxk4dq807araEf7quIxpV1EAai4zqpuIOcoHDJL9n2Qv9djFWVoPBXrJb9QCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b6433a7-3564-4cba-ace2-4a44afca4177",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf2d253c-f4d7-4c61-99c1-8f448af377d3", "AQAAAAIAAYagAAAAEHY8HkDpiq5xSO1DlZyX5eMUQ+eLnlN4/6UVlVkTaOb4QnHqWABovJ2x/qdmYue03Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8eb86d7d-02f7-477d-8e6f-539d7c155930",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9127e24-7b0f-48ae-95f7-51c783abc60b", "AQAAAAIAAYagAAAAELTfaemjEid02t2giYULigIceiDaWFMPVw0Cv/E5pj/EDm7p19VBJe+XnnioWNMNkg==", "5b687fad-5487-43d6-bcb2-b508243f2813" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f7bca8f-059f-4750-8bfe-7def13ef37e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92f13702-1ca9-40d9-a297-f11efcea5b26", "AQAAAAIAAYagAAAAECegokdcNmQ3mZYLu9yiPGuauua8PGHV7MhZsukfuTFsKHy84d2So8fx/CUMPaFWSA==", "d215c7cc-ca31-49c7-bde8-6657cafae70f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab8c775-88c0-4dc3-b11d-178c3ca2129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8b2bf7d-4f85-4096-91bf-0c53c67929ba", "AQAAAAIAAYagAAAAEKjjB4MLa/3b13fIHqKgvYiA2A/4tE6KNFl3fMoXzDzlR7TYNOk/pR4Gyt321WuvDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e71ac5d-0158-4a29-8c13-a54108523c63", "AQAAAAIAAYagAAAAEI2l6w4rTYWaKLD8TyL4pGMB1P6UPVGmjYLcLq8rb2bLaP0vGDNbluBqNwoY6QV+Bw==", "18c180d9-e61d-49d4-9d83-2ef8ae54c6f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab696b9f-f5d2-45a0-8495-96e2d2a01acc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd5345c6-33df-4190-b372-692c47c5957d", "AQAAAAIAAYagAAAAELkjVFP23KiXFVkgH3l1B4YZVzDt8tWHfTcfuCIU5UcSF4sNcZE8wk5DBUZZ8PoFaA==", "7dd5423d-2ce9-4114-9ff7-0c5d11a8d8ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b65e6163-1454-4164-9869-2ff822f9da98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffc62994-d4d7-43bb-8d79-05f58b0f6d66", "AQAAAAIAAYagAAAAEA+BYX6FZmyGTOCiYkNe/ywTVpq6n40zKRXMvlOLE0v6xfAKY/o8m9vwyKArbT6/sw==", "ff9aa14c-7890-4cea-9e2a-f6f5188e1a10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8d81f44-f8a9-43e6-83fe-e62ab38f30cf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "baace7b3-09a6-459f-873b-be1637c92017", "AQAAAAIAAYagAAAAEEF5sjtFO2vwervt1RD3PgKKJQ4W/ZHxGR+9LWx6NyMxYUbCFWkwmwEsFh122o8Emg==", "a0143216-1b8b-43ef-a9f9-2afe3ff684e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8c0d8c-24e0-4e4f-b8a7-5c69e5895b9f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0b7cd56-21a5-4d99-81c4-17a35dcda084", "AQAAAAIAAYagAAAAEM6R7Qis7GfSB8fj9jB6DnqUyIWLOPoTSiZD9UXtmWPtxNCHRBwX9QfbALVR2ZDhEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5d7d80f-08d5-41ec-892c-30833098c047",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a00024d-215c-4196-910e-79fe69f21013", "AQAAAAIAAYagAAAAEEWmWX5c8cseA2C2OQfJyn4DF+GR3T6grbAyjfYFKZJJD9WlOPotidSzVY7j7rVP8w==", "b21333d3-9063-4d2f-844e-4b38326fe1f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c64af0f1-3716-4e30-b5f7-b0c5153e2b01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d80ae68-c33b-4aa5-a124-8d45a460755e", "AQAAAAIAAYagAAAAENWsAeI+xT2UVe1Ur44DjoXvPsp/mBN+MIKCr1AR2qADrveu8knlYvXygaGNz0JjlQ==", "65e18931-6cea-4d06-9da8-54679ba99234" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cab3584a-da3f-4858-a65a-3f7bde9e553f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22f0c7ab-5aab-4f95-a72c-a93badf9d19c", "AQAAAAIAAYagAAAAEFkJGejRFzo0PQ32zQrn29BfB0rh6x1oWP9mYGNyVvDUE9kiutLLOkiN8N+V4oWpRA==", "e6666873-ad78-4ca8-a26c-7c7addbe22c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0e396e6-53f2-40e9-8013-664b8a8dbd46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddcd2b7b-3875-4af4-827c-79ec34405d2c", "AQAAAAIAAYagAAAAEIsQvxXUtskWqS5hMjWkENSPkAKMgtzP3wCK1YV+ykpJ4WYZfAahdjcZ8uUfPktycw==", "004ea28f-bf23-4747-986f-e97229c1b018" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8264a26-ea76-44c4-a013-12759599a081",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d77ed91-48ea-4668-823e-f637fe2522e8", "AQAAAAIAAYagAAAAEDDpRinflj5Sn8zm9i43r+DWFbOw0hnBKD2bRIT5hSx9OMgtlxRO5NihGVogSzGhLQ==", "95d96594-a382-4a72-aad6-5497b617cc7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2875100-0cf1-4b1d-ba91-1dfa38690f84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4c4eee8-7604-4eb3-bd66-5dff70cd9014", "AQAAAAIAAYagAAAAEDzxg5DhpU6B5CMb4G12E11bCCSnajtwrCByOalz/5GCpo4YOUxeFiB4fZ2Eztfeng==", "134dfd6e-53bd-405d-ba78-eb8866f9ad2c" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2008, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2008, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2009, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2006, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2005, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2004, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2003, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2002, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2005, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2004, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2006, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2005, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2007, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2003, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2004, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2009, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2006, 7, 16, 21, 36, 13, 277, DateTimeKind.Utc).AddTicks(7891));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "aa7d01c6-9499-4ed4-a38e-3d0afa2b707c" });

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
    }
}
