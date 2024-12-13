using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "Date", "IsDeleted", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 2, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 3, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 4, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 5, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 6, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 7, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4 },
                    { 8, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4 },
                    { 10, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5 },
                    { 11, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5 },
                    { 12, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6 },
                    { 13, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6 },
                    { 14, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 },
                    { 15, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7 },
                    { 16, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8 },
                    { 17, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8 },
                    { 18, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 },
                    { 20, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9 },
                    { 21, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10 },
                    { 22, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10 },
                    { 23, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 },
                    { 24, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11 },
                    { 25, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12 },
                    { 26, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 12 },
                    { 27, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 },
                    { 28, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13 },
                    { 29, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 14 },
                    { 30, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 14 },
                    { 31, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 15 },
                    { 32, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 15 },
                    { 33, 4, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 16 },
                    { 34, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 16 },
                    { 35, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 },
                    { 36, 5, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 17 },
                    { 37, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 18 },
                    { 38, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 18 },
                    { 39, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 },
                    { 40, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 19 },
                    { 41, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 20 },
                    { 42, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 20 }
                });

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

            migrationBuilder.InsertData(
                table: "ClassCourses",
                columns: new[] { "ClassId", "CourseId", "EnrollmentDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "10 B");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "9 A");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "11 C");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "12 A");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "8 B");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "7 A");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "6 C");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "10 A");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "9 B");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "11 A");

            migrationBuilder.InsertData(
                table: "CoursesSchedules",
                columns: new[] { "Id", "ClassId", "CourseId", "Day", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 3, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, 1, 8, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, 1, 10, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, 1, 6, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 5, 1, 9, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 6, 1, 1, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 7, 1, 2, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 8, 1, 7, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 9, 1, 2, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 10, 1, 9, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 11, 1, 2, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 12, 1, 4, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 13, 1, 5, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 14, 1, 9, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 15, 1, 6, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 16, 1, 5, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 17, 1, 3, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 18, 1, 9, 4, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 19, 1, 1, 4, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 20, 1, 2, 4, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 21, 1, 9, 4, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 22, 1, 9, 4, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 23, 1, 7, 4, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 24, 1, 8, 5, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 25, 1, 1, 5, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 26, 1, 2, 5, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 27, 1, 4, 5, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 28, 1, 3, 5, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 29, 1, 7, 5, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 30, 2, 5, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 31, 2, 4, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 32, 2, 8, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 33, 2, 2, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 34, 2, 6, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 35, 2, 1, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 36, 2, 2, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 37, 2, 1, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 38, 2, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 39, 2, 8, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 40, 2, 1, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 41, 2, 4, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 42, 2, 5, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 43, 2, 4, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 44, 2, 9, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 45, 2, 10, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 46, 2, 1, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 47, 2, 6, 4, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 48, 2, 2, 5, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 49, 2, 3, 5, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 50, 2, 10, 5, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 51, 2, 10, 5, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 52, 3, 6, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 53, 3, 8, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 54, 3, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 55, 3, 9, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 56, 3, 4, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 57, 3, 5, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 58, 3, 3, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 59, 3, 3, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 60, 3, 8, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 61, 3, 6, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 62, 3, 2, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 63, 3, 3, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 64, 3, 7, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 65, 3, 4, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 66, 3, 8, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 67, 3, 4, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 68, 3, 8, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 69, 3, 9, 4, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 70, 3, 1, 4, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 71, 3, 2, 4, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 72, 3, 3, 4, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 73, 3, 2, 4, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 74, 3, 5, 4, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 75, 3, 1, 5, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 76, 3, 4, 5, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 77, 3, 9, 5, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 78, 3, 2, 5, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 79, 3, 9, 5, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 80, 3, 6, 5, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 81, 4, 5, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 82, 4, 2, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 83, 4, 6, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 84, 4, 8, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 85, 4, 8, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 86, 4, 10, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 87, 4, 6, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 88, 4, 8, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 89, 4, 4, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 90, 4, 9, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 91, 4, 1, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 92, 4, 9, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 93, 4, 2, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 94, 4, 4, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 95, 4, 3, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 96, 4, 7, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 97, 4, 3, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 98, 4, 2, 4, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 99, 4, 8, 4, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 100, 4, 2, 4, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 101, 4, 1, 4, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 102, 4, 5, 4, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 103, 4, 2, 4, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 104, 4, 2, 5, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 105, 4, 7, 5, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 106, 4, 10, 5, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 107, 4, 2, 5, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 108, 4, 9, 5, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 109, 4, 6, 5, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 110, 5, 2, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 111, 5, 3, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 112, 5, 5, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 113, 5, 7, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 114, 5, 5, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 115, 5, 4, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 116, 5, 9, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 117, 5, 2, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 118, 5, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 119, 5, 7, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 120, 5, 4, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 121, 5, 5, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 122, 5, 9, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 123, 5, 3, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 124, 5, 3, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 125, 5, 4, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 126, 5, 7, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 127, 5, 2, 4, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 128, 5, 5, 4, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 129, 5, 10, 4, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 130, 5, 9, 4, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 131, 5, 10, 4, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 132, 5, 10, 4, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 133, 5, 1, 5, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 134, 5, 8, 5, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 135, 5, 6, 5, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 136, 5, 3, 5, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 137, 5, 6, 5, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 138, 5, 9, 5, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 140, 6, 4, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 141, 6, 7, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 142, 6, 1, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 143, 6, 3, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 144, 6, 4, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 145, 6, 7, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 146, 6, 1, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 147, 6, 9, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 148, 6, 3, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 149, 6, 4, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 150, 6, 8, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 151, 6, 8, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 152, 6, 4, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 153, 6, 6, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 154, 6, 9, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 155, 6, 6, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 156, 6, 10, 4, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 157, 6, 5, 4, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 158, 6, 5, 4, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 159, 6, 10, 4, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 160, 6, 1, 4, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 161, 6, 2, 4, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 162, 6, 2, 5, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 163, 6, 10, 5, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 164, 6, 2, 5, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 165, 6, 1, 5, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 166, 6, 4, 5, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 167, 6, 7, 5, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 168, 7, 8, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 169, 7, 10, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 170, 7, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 171, 7, 2, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 172, 7, 8, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 173, 7, 2, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 174, 7, 8, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 175, 7, 5, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 176, 7, 6, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 177, 7, 8, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 178, 7, 8, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 179, 7, 1, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 180, 7, 8, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 181, 7, 9, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 182, 7, 1, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 183, 7, 3, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 184, 7, 6, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 185, 7, 5, 4, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 186, 7, 1, 4, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 187, 7, 8, 4, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 188, 7, 8, 4, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 189, 7, 10, 4, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 190, 7, 6, 4, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 191, 7, 10, 5, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 192, 7, 10, 5, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 193, 7, 1, 5, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 194, 7, 7, 5, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 195, 7, 10, 5, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 196, 7, 3, 5, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 197, 8, 2, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 198, 8, 5, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 199, 8, 6, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 200, 8, 1, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 201, 8, 8, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 202, 8, 10, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 203, 8, 5, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 204, 8, 5, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 205, 8, 2, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 206, 8, 9, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 207, 8, 5, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 208, 8, 6, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 209, 8, 8, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 210, 8, 1, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 211, 8, 2, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 212, 8, 9, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 213, 8, 10, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 214, 8, 4, 4, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 215, 8, 6, 4, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 216, 8, 4, 4, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 217, 8, 7, 4, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 218, 8, 7, 4, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 219, 8, 6, 4, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 220, 8, 8, 5, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 221, 8, 5, 5, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 222, 8, 5, 5, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 223, 8, 10, 5, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 224, 8, 9, 5, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 225, 8, 5, 5, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 226, 9, 4, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 227, 9, 6, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 228, 9, 7, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 229, 9, 5, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 230, 9, 7, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 231, 9, 10, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 232, 9, 2, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 233, 9, 5, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 234, 9, 10, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 235, 9, 5, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 236, 9, 10, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 237, 9, 9, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 238, 9, 10, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 239, 9, 9, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 240, 9, 5, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 241, 9, 7, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 242, 9, 5, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 243, 9, 9, 4, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 244, 9, 2, 4, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 245, 9, 4, 4, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 246, 9, 10, 4, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 247, 9, 3, 4, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 248, 9, 7, 4, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 249, 9, 2, 5, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 250, 9, 4, 5, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 251, 9, 10, 5, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 252, 10, 6, 1, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 253, 10, 10, 1, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 254, 10, 3, 1, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 255, 10, 9, 1, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 256, 10, 3, 1, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 257, 10, 6, 1, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 258, 10, 1, 2, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 259, 10, 4, 2, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 260, 10, 2, 2, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 261, 10, 5, 2, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 262, 10, 9, 2, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 263, 10, 5, 3, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 264, 10, 3, 3, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 265, 10, 4, 3, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 266, 10, 3, 3, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 267, 10, 10, 3, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 268, 10, 6, 3, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 269, 10, 5, 4, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 270, 10, 5, 4, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 271, 10, 1, 4, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 272, 10, 9, 4, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 273, 10, 10, 4, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 274, 10, 5, 4, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) },
                    { 275, 10, 5, 5, new TimeSpan(0, 8, 45, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 276, 10, 7, 5, new TimeSpan(0, 9, 45, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 277, 10, 8, 5, new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 278, 10, 7, 5, new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 279, 10, 10, 5, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 15, 0, 0) },
                    { 280, 10, 4, 5, new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 13, 5, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseId", "GradeAssignedDate", "GradeScore", "GradeType", "IsDeleted", "StudentId" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3648), 4.0, "Final", false, 1 },
                    { 2, 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3713), 5.0, "Midterm", false, 1 },
                    { 3, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3719), 4.0, "Homework", false, 1 },
                    { 4, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3727), 4.0, "Quiz", false, 1 },
                    { 5, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3733), 5.0, "Project", false, 1 },
                    { 6, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3741), 4.0, "Second Term Assessment", false, 1 },
                    { 7, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3746), 6.0, "First Term Assessment", false, 1 },
                    { 8, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3754), 4.0, "Homework", false, 1 },
                    { 9, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3759), 5.0, "Quiz", false, 1 },
                    { 10, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3777), 3.0, "Project", false, 2 },
                    { 11, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3824), 2.0, "Final", false, 2 },
                    { 12, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3833), 6.0, "Midterm", false, 2 },
                    { 13, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3839), 2.0, "Homework", false, 2 },
                    { 14, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3847), 2.0, "Quiz", false, 2 },
                    { 15, 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3852), 5.0, "Project", false, 2 },
                    { 16, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3860), 3.0, "Second Term Assessment", false, 2 },
                    { 17, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3865), 2.0, "First Term Assessment", false, 2 },
                    { 18, 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3873), 1.0, "Homework", false, 2 },
                    { 19, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3878), 2.0, "Quiz", false, 2 },
                    { 20, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3885), 6.0, "Project", false, 2 },
                    { 31, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3891), 4.0, "Final", false, 3 },
                    { 32, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3899), 1.0, "Midterm", false, 3 },
                    { 33, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3904), 3.0, "Homework", false, 3 },
                    { 34, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3912), 6.0, "Quiz", false, 3 },
                    { 35, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3917), 4.0, "Project", false, 3 },
                    { 36, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3925), 5.0, "Second Term Assessment", false, 3 },
                    { 37, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3930), 1.0, "First Term Assessment", false, 3 },
                    { 38, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3938), 1.0, "Homework", false, 3 },
                    { 39, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(3943), 3.0, "Quiz", false, 3 },
                    { 40, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4028), 5.0, "Project", false, 3 },
                    { 41, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4034), 4.0, "Final", false, 4 },
                    { 42, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4041), 1.0, "Midterm", false, 4 },
                    { 43, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4047), 5.0, "Homework", false, 4 },
                    { 44, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4055), 6.0, "Quiz", false, 4 },
                    { 45, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4060), 4.0, "Project", false, 4 },
                    { 46, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4068), 3.0, "Second Term Assessment", false, 4 },
                    { 47, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4074), 4.0, "First Term Assessment", false, 4 },
                    { 48, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4082), 6.0, "Homework", false, 4 },
                    { 49, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4087), 5.0, "Quiz", false, 4 },
                    { 50, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4095), 2.0, "Project", false, 4 },
                    { 51, 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4100), 1.0, "Final", false, 5 },
                    { 52, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4108), 2.0, "Midterm", false, 5 },
                    { 53, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4113), 3.0, "Homework", false, 5 },
                    { 54, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4120), 3.0, "Quiz", false, 5 },
                    { 55, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4126), 5.0, "Project", false, 5 },
                    { 56, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4134), 4.0, "Second Term Assessment", false, 5 },
                    { 57, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4139), 5.0, "First Term Assessment", false, 5 },
                    { 58, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4146), 5.0, "Homework", false, 5 },
                    { 59, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4152), 4.0, "Quiz", false, 5 },
                    { 60, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4160), 6.0, "Project", false, 5 },
                    { 70, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4165), 6.0, "Project", false, 7 },
                    { 71, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4173), 5.0, "Final", false, 7 },
                    { 72, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4178), 5.0, "Midterm", false, 7 },
                    { 73, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4186), 3.0, "Homework", false, 7 },
                    { 74, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4191), 3.0, "Quiz", false, 7 },
                    { 75, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4199), 5.0, "Project", false, 7 },
                    { 76, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4204), 6.0, "Second Term Assessment", false, 7 },
                    { 77, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4212), 3.0, "First Term Assessment", false, 7 },
                    { 78, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4217), 5.0, "Homework", false, 7 },
                    { 79, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4225), 2.0, "Quiz", false, 7 },
                    { 80, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4230), 6.0, "Project", false, 7 },
                    { 91, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4239), 5.0, "Final", false, 8 },
                    { 92, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4244), 4.0, "Midterm", false, 8 },
                    { 93, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4252), 3.0, "Homework", false, 8 },
                    { 94, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4257), 4.0, "Quiz", false, 8 },
                    { 95, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4265), 1.0, "Project", false, 8 },
                    { 96, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4271), 2.0, "Second Term Assessment", false, 8 },
                    { 97, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4320), 3.0, "First Term Assessment", false, 8 },
                    { 98, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4325), 5.0, "Homework", false, 8 },
                    { 99, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4333), 6.0, "Quiz", false, 8 },
                    { 100, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4338), 2.0, "Project", false, 8 },
                    { 101, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4346), 1.0, "Final", false, 9 },
                    { 102, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4351), 3.0, "Midterm", false, 9 },
                    { 103, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4360), 1.0, "Homework", false, 9 },
                    { 104, 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4365), 1.0, "Quiz", false, 9 },
                    { 105, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4373), 3.0, "Project", false, 9 },
                    { 106, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4378), 1.0, "Second Term Assessment", false, 9 },
                    { 107, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4386), 2.0, "First Term Assessment", false, 9 },
                    { 108, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4391), 2.0, "Homework", false, 9 },
                    { 109, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4399), 5.0, "Quiz", false, 9 },
                    { 110, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4404), 4.0, "Project", false, 9 },
                    { 111, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4412), 1.0, "Final", false, 10 },
                    { 112, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4417), 2.0, "Midterm", false, 10 },
                    { 113, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4425), 6.0, "Homework", false, 10 },
                    { 114, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4430), 2.0, "Quiz", false, 10 },
                    { 115, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4438), 2.0, "Project", false, 10 },
                    { 116, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4444), 6.0, "Second Term Assessment", false, 10 },
                    { 117, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4451), 1.0, "First Term Assessment", false, 10 },
                    { 118, 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4456), 1.0, "Homework", false, 10 },
                    { 119, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4464), 6.0, "Quiz", false, 10 },
                    { 120, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4469), 6.0, "Project", false, 10 },
                    { 121, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4477), 6.0, "Final", false, 11 },
                    { 122, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4482), 3.0, "Midterm", false, 11 },
                    { 123, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4490), 5.0, "Homework", false, 11 },
                    { 124, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4496), 6.0, "Quiz", false, 11 },
                    { 125, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4503), 1.0, "Project", false, 11 },
                    { 126, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4509), 5.0, "Second Term Assessment", false, 11 },
                    { 127, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4517), 6.0, "First Term Assessment", false, 11 },
                    { 128, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4522), 2.0, "Homework", false, 11 },
                    { 129, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4530), 2.0, "Quiz", false, 11 },
                    { 130, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4535), 4.0, "Project", false, 12 },
                    { 131, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4543), 5.0, "Final", false, 12 },
                    { 132, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4548), 6.0, "Midterm", false, 12 },
                    { 133, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4556), 4.0, "Homework", false, 12 },
                    { 134, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4561), 1.0, "Quiz", false, 12 },
                    { 135, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4607), 4.0, "Project", false, 12 },
                    { 136, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4612), 5.0, "Second Term Assessment", false, 12 },
                    { 137, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4620), 1.0, "First Term Assessment", false, 12 },
                    { 138, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4625), 5.0, "Homework", false, 12 },
                    { 139, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4634), 5.0, "Quiz", false, 12 },
                    { 140, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4639), 2.0, "Project", false, 12 },
                    { 141, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4646), 2.0, "Final", false, 13 },
                    { 142, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4652), 5.0, "Midterm", false, 13 },
                    { 143, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4659), 2.0, "Homework", false, 13 },
                    { 144, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4665), 6.0, "Quiz", false, 13 },
                    { 145, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4672), 4.0, "Project", false, 13 },
                    { 146, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4678), 1.0, "Second Term Assessment", false, 13 },
                    { 147, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4685), 5.0, "First Term Assessment", false, 13 },
                    { 148, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4690), 4.0, "Homework", false, 13 },
                    { 149, 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4698), 5.0, "Quiz", false, 13 },
                    { 150, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4703), 6.0, "Project", false, 13 },
                    { 151, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4711), 2.0, "Final", false, 14 },
                    { 152, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4716), 1.0, "Midterm", false, 14 },
                    { 153, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4724), 4.0, "Homework", false, 14 },
                    { 154, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4729), 1.0, "Quiz", false, 14 },
                    { 155, 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4737), 4.0, "Project", false, 14 },
                    { 156, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4742), 4.0, "Second Term Assessment", false, 14 },
                    { 157, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4750), 4.0, "First Term Assessment", false, 14 },
                    { 158, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4755), 5.0, "Homework", false, 14 },
                    { 159, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4763), 1.0, "Quiz", false, 14 },
                    { 160, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4768), 5.0, "Project", false, 14 },
                    { 161, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4776), 5.0, "Final", false, 15 },
                    { 162, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4781), 6.0, "Midterm", false, 15 },
                    { 163, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4789), 1.0, "Homework", false, 15 },
                    { 164, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4794), 2.0, "Quiz", false, 15 },
                    { 165, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4802), 4.0, "Project", false, 15 },
                    { 166, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4808), 6.0, "Second Term Assessment", false, 15 },
                    { 167, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4815), 3.0, "First Term Assessment", false, 15 },
                    { 168, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4820), 2.0, "Homework", false, 15 },
                    { 169, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4828), 6.0, "Quiz", false, 15 },
                    { 170, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4834), 1.0, "Project", false, 15 },
                    { 171, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4841), 3.0, "Final", false, 16 },
                    { 172, 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4884), 5.0, "Midterm", false, 16 },
                    { 173, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4893), 3.0, "Homework", false, 16 },
                    { 174, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4898), 3.0, "Quiz", false, 16 },
                    { 175, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4907), 3.0, "Project", false, 16 },
                    { 176, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4912), 1.0, "Second Term Assessment", false, 16 },
                    { 177, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4920), 5.0, "First Term Assessment", false, 16 },
                    { 178, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4925), 1.0, "Homework", false, 16 },
                    { 179, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4933), 1.0, "Quiz", false, 16 },
                    { 180, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4939), 4.0, "Project", false, 16 },
                    { 181, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4946), 3.0, "Final", false, 17 },
                    { 182, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4952), 4.0, "Midterm", false, 17 },
                    { 183, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4959), 5.0, "Homework", false, 17 },
                    { 184, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4965), 5.0, "Quiz", false, 17 },
                    { 185, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4972), 6.0, "Project", false, 17 },
                    { 186, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4978), 3.0, "Second Term Assessment", false, 17 },
                    { 187, 5, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4985), 1.0, "First Term Assessment", false, 17 },
                    { 188, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4990), 6.0, "Homework", false, 17 },
                    { 189, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(4998), 5.0, "Quiz", false, 17 },
                    { 190, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5004), 2.0, "Project", false, 17 },
                    { 191, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5012), 6.0, "Final", false, 18 },
                    { 192, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5017), 3.0, "Midterm", false, 18 },
                    { 193, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5042), 3.0, "Homework", false, 18 },
                    { 194, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5047), 3.0, "Quiz", false, 18 },
                    { 195, 4, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5055), 2.0, "Project", false, 18 },
                    { 196, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5060), 4.0, "Second Term Assessment", false, 18 },
                    { 197, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5068), 2.0, "First Term Assessment", false, 18 },
                    { 198, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5074), 1.0, "Homework", false, 18 },
                    { 199, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5082), 1.0, "Quiz", false, 18 },
                    { 200, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5087), 4.0, "Project", false, 18 },
                    { 201, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5095), 1.0, "Final", false, 19 },
                    { 202, 2, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5100), 2.0, "Midterm", false, 19 },
                    { 203, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5108), 5.0, "Homework", false, 19 },
                    { 204, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5113), 4.0, "Quiz", false, 19 },
                    { 205, 1, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5121), 6.0, "Project", false, 19 },
                    { 206, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5126), 1.0, "Second Term Assessment", false, 19 },
                    { 207, 3, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5134), 4.0, "First Term Assessment", false, 19 },
                    { 208, 6, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5139), 4.0, "Homework", false, 19 },
                    { 209, 7, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5147), 6.0, "Quiz", false, 19 },
                    { 210, 8, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5209), 6.0, "Project", false, 19 },
                    { 211, 10, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5218), 4.0, "Final", false, 20 },
                    { 212, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5224), 3.0, "Midterm", false, 20 },
                    { 213, 9, new DateTime(2024, 12, 13, 2, 58, 25, 416, DateTimeKind.Local).AddTicks(5231), 5.0, "Homework", false, 20 }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Content", "Date", "IsDeleted", "PublisherId", "Title" },
                values: new object[,]
                {
                    { 1, "The new school year has officially begun. We are excited to welcome all students back to campus and look forward to a successful year ahead.", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "New School Year Begins" },
                    { 2, "The annual science fair will be held next month. Students are encouraged to participate and showcase their projects.", new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "Science Fair Announced" },
                    { 3, "Sports day is scheduled for the end of the semester. Students can participate in various sports activities.", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "Sports Day Scheduled" },
                    { 4, "An art exhibition will be held in the school auditorium. Students' artworks will be displayed.", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "Art Exhibition" },
                    { 5, "A parent-teacher meeting is scheduled for next week. Parents are encouraged to attend and discuss their child's progress.", new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "Parent-Teacher Meeting" },
                    { 6, "The school will be celebrating the upcoming holidays with various events and activities. Students are invited to participate.", new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "51065229-23b9-402f-a54d-00bb813d6b1c", "Holiday Celebration" }
                });

            migrationBuilder.InsertData(
                table: "Remarks",
                columns: new[] { "Id", "CourseId", "Date", "IsDeleted", "RemarkText", "StudentId", "TeacherId" },
                values: new object[,]
                {
                    { 3, 9, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 1, 25 },
                    { 4, 4, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 1, 30 },
                    { 5, 5, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 1, 24 },
                    { 6, 2, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 2, 27 },
                    { 7, 6, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 2, 28 },
                    { 8, 7, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 2, 21 },
                    { 9, 9, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 3, 28 },
                    { 10, 3, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 3, 27 },
                    { 11, 8, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 3, 23 },
                    { 12, 10, new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 4, 25 },
                    { 13, 7, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 4, 23 },
                    { 14, 6, new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 4, 30 },
                    { 15, 3, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 5, 27 },
                    { 16, 3, new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 5, 25 },
                    { 17, 7, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 5, 24 },
                    { 18, 1, new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 6, 21 },
                    { 19, 4, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 6, 27 },
                    { 20, 4, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 6, 24 },
                    { 21, 5, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 7, 26 },
                    { 22, 7, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 7, 30 },
                    { 23, 3, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 7, 29 },
                    { 24, 8, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 8, 30 },
                    { 25, 7, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 8, 25 },
                    { 26, 9, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 8, 23 },
                    { 27, 5, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 9, 21 },
                    { 28, 2, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 9, 29 },
                    { 29, 4, new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 9, 23 },
                    { 30, 2, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 10, 25 },
                    { 31, 9, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 10, 24 },
                    { 32, 9, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 10, 28 },
                    { 33, 9, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 11, 22 },
                    { 34, 3, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 11, 29 },
                    { 35, 2, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 11, 27 },
                    { 36, 2, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 12, 29 },
                    { 37, 3, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 12, 21 },
                    { 38, 5, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 12, 21 },
                    { 39, 6, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 13, 22 },
                    { 40, 5, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 13, 24 },
                    { 41, 2, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 13, 22 },
                    { 42, 3, new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 14, 30 },
                    { 43, 9, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 14, 22 },
                    { 44, 4, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 14, 23 },
                    { 45, 10, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 15, 22 },
                    { 46, 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 15, 26 },
                    { 47, 9, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 15, 22 },
                    { 48, 6, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 16, 23 },
                    { 49, 5, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 16, 28 },
                    { 50, 10, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 16, 30 },
                    { 51, 5, new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 17, 25 },
                    { 52, 1, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 17, 29 },
                    { 53, 10, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 17, 22 },
                    { 54, 9, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 18, 21 },
                    { 55, 5, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 18, 24 },
                    { 56, 7, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 18, 24 },
                    { 57, 5, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 19, 26 },
                    { 58, 3, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 19, 22 },
                    { 59, 4, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 19, 26 },
                    { 60, 6, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 20, 23 },
                    { 61, 5, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 20, 28 },
                    { 62, 5, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 20, 29 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "ClassCourses",
                keyColumns: new[] { "ClassId", "CourseId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "CoursesSchedules",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Remarks",
                keyColumn: "Id",
                keyValue: 62);

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
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "10b");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "9a");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "11c");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "12a");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "8b");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "7a");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "6c");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "10a");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "9b");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "11a");

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
        }
    }
}
