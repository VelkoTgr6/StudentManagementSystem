using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedFieldsToUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                comment: "First name of the user.");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                comment: "Last name of the user.");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e1a0f9c-4e7e-44c6-a389-fac59d6b02ad", "AQAAAAIAAYagAAAAEByHHtS2dE3p6atge5hALtB1b54tbDpIO8RYQ50GDJWZAP4cwvK47WYw/wkr0kIQvA==", "b27b9cf5-3b28-4782-ab30-b0ec913ab519" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dd58e5f-2211-43b3-b043-21d0e80d30a0", "AQAAAAIAAYagAAAAEPDZzwTGMchYRBSIEOv2SzPJv9H65R7ZkWNOhL8Qvycd5d+420FA8a2PnzQ99vBudw==", "e5786674-6e05-4fd7-9f11-e4c8d4017ede" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c4ece1d-3bc1-4e07-af24-7e480b9af08e", "AQAAAAIAAYagAAAAENiH7Utx8345dg0PWGuZQll+obrQu9D442nLIXSy9nZxVbodkpGE55kpIWgQNOJw2Q==", "e97eabaa-e2bf-4e8c-b232-0c76ef4bfabb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02ce09a2-c981-4b7c-9f41-08d57a9283a8", "AQAAAAIAAYagAAAAEIS4wAao/YqqD9SS9G0PHg9f63WRnTdxc377kr4siWd/qMwO8ip7IIBUUfwAJwq9rg==", "cdb9bc9d-b0e4-4507-bc81-7da2d8ba410d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4417f05f-34b8-4065-880d-ad903dfaa171", "AQAAAAIAAYagAAAAEGAtWJmQZpvkKU1Wfw2Otld4WUWB1/7Njrx/yWdyit1CSPnWbc2LAgCJxYY+Z1J7hQ==", "54ed0a34-673b-4344-870c-01aea27423c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7a2751c-53e9-4616-8b90-0acc1c6ffcd2", "AQAAAAIAAYagAAAAEDb4WV1ozbVmul5QSeuSrDghlzkh2c3Ma8kNBRVBiFUVMRShZHYR+loOFIiwcbpNyw==", "01c2f744-55d5-4835-a4c1-b99c1580a715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9ed677e-7348-42af-8cc6-890a23380b78", "AQAAAAIAAYagAAAAEJ5tc9a/UNFzo+js0Umak+UQWTHNQN7UWVZ219M/5vwJjmVlb8YmUGAbnv/ZAqABfw==", "7cc31547-ffe9-43ce-8815-90136fd395b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f39f62d7-9a86-4a91-9be2-60ccf263a997", "AQAAAAIAAYagAAAAEPxBTj8LIJiusm0f7P12akJLZp5Pv56rIPXp8ktvOyyO48K/w6+qp0FfzmYfz8APRQ==", "de532ca1-9e95-444b-918a-e5de4c2f4e52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db629645-09c3-4a03-940f-cd06ad956be9", "AQAAAAIAAYagAAAAEDJgojitJGvJ6VyMYKYfLVG7MwIjjyxXsm7ZQJdkuesWSWcQvF6ceOm5X430R5SMuA==", "3be15642-bcc0-4fc0-ad35-a2fef0ab8c7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44f29ca9-d489-44df-af78-914e8d872611", "AQAAAAIAAYagAAAAEL7AW7M+pqMYVy2suzEhnnAmqQfKdYsL8Ml7IXuJdrRissrVHjDj5eLtZnn8YhUVoQ==", "1af667ee-33ac-43cd-9e8b-4a8a08a1b408" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ec7a2c5-ae8f-4f7d-95f0-3715f6cf46b3", "AQAAAAIAAYagAAAAEMlOqi4ePymllW08YQ9BrzA2hfD1WZEJsGOvZC3dDlQmNtRshMKHO5VzJxtPWOKXkg==", "5eec226f-547f-4572-9db1-9eec14538bfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcd9c396-ccda-4409-95b6-a9dcbadf2115", "AQAAAAIAAYagAAAAEMS/mrWLV5APj/o/lkrVN9JUAbDTDAwqZ8vRYfYr+RvhASKBNKBl5LnkH8dKlR2O9A==", "4ecabace-8934-4af1-9466-8f77392f5259" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abbf1fb8-605d-4b6e-b55e-3842d4e1f599", "AQAAAAIAAYagAAAAEKLd9wACpdE+txUv8GvjmgnKUO+2i+l03eL5EL33qLyUK+v2Kg0IlwLAk32IE7OoUw==", "2bc44e1a-89c0-47cc-b424-3ac4f2ade164" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b65ec754-8c61-423e-aba7-088e1a232edd", "AQAAAAIAAYagAAAAEKmdNrMTtFcrqOcAeTVUWtJa/WNVq3fW6a5/t1jxwWd0oAZ9FajN8+03BAoI7oGi/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ce95202-4322-4372-bb08-0472f2e824a6", "AQAAAAIAAYagAAAAEC8HxOTdfLAr+8iM2NClnNlxZ8XmKK2BIbTzhvhJ59IFkGfLoX2tDf075TQFSsnoug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5b7fb55-d44e-45bf-bf8c-3c0edf7e2d12", "AQAAAAIAAYagAAAAEAXHOZDO4gARXxsAnXdDS8+gKymjLBwgLAEzVobCG3objT92gd4FP/a6VW1rERylOg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21fefdc5-17ba-41bb-87a9-6e75336d15bf", "AQAAAAIAAYagAAAAEJHLcZ6mDs8cQL70cYaJu5t1Bh8PZWRuuXFAa9RgM1fRxi2UDj7I4faVO+ExCinTZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a59eacf-7596-4990-8614-62debdb19ba8", "AQAAAAIAAYagAAAAECuMu0Me1ttY9HQEoDpgwCRxRLh6T4DSowMlcNB6fLYH1xyCZsMeDQTEuYz5aY+QzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7226da57-3bb6-4a91-9057-bb6faf3d92f7", "AQAAAAIAAYagAAAAEBHiQHaTfrNJITLz6zfX3/WDXa9sKrnOn2jwxKtL9pez2fyhiTjGstl6d40oB4NtTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0470eea5-6f87-44fb-a0bd-b85ebac7b799", "AQAAAAIAAYagAAAAENmQEYM2olx8yPjxiPxfVysRTxMvfE7PusTEfv7wv+PMNnTe3u7EW0FR+Lt9AdqHQA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8a4b81c-a924-4fb1-a64e-dd5c63e812fd", "AQAAAAIAAYagAAAAEFNp06nLXrCzIEKiOgFjkOgOO9tLCaLc2xfclxMBJ6GBdCU4kr9B+ZlmXhL2yifp1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e14c9d7-f739-4144-b439-5dca3e23873f", "AQAAAAIAAYagAAAAEPyXjwxKglaRMgcmasDU3vyTEozqR4PrfLhrM+UVTdJ1ink/qMw6A4t9ssCB0rQSmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35853a92-9ebb-43d0-8c3d-9917db929b8d", "AQAAAAIAAYagAAAAEByTnZzBlMKNri6KlLMt66yICkfEByKaPMXPcIKcOL+CO0+eKaJnp90CbbUKoWlF5A==", "bf3e53a2-74d3-4611-894d-c7d11555a98b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fb64afd-5f3a-4952-a322-aa9c4dc09aaf", "AQAAAAIAAYagAAAAEIC+L3GgUPB8w7BnjkAa7I8eYsc6ks53UNxfV0tUzg5tDpZGqqG0he/AXJFIlYDKPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d89aae3f-492c-43ea-bd9a-4d33af0a4903", "AQAAAAIAAYagAAAAEKNmD4byl6vz/f07FWu7y+VYF9Va9fwHgdTqEB6iZD0xOHJhtbbXD9ACnAb8bFb6gw==", "48be7937-01a6-4817-9c6e-5ee205590a3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92a7680c-5583-4ed0-9735-d742c833c626", "AQAAAAIAAYagAAAAECQlm2O6z3p/Vg7pGJ2rEgXBpUO1Zop20HWsMbqfTdrXdlLfXXSA2W4byXoWuiNLDw==", "8c3a3e07-42d7-46ec-802e-3f3bb01e289a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b5d55e8-38ff-4e3a-904c-33da7ec473cc", "AQAAAAIAAYagAAAAEDUIiljyA90tGm2/YQkJc1nXLx/vteXW7HTjPc1M6RE9USw92jN//atGvn5esMaWyg==", "baea3d89-1e4e-4591-995c-3c5865065e05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0fb0e6b-39a9-44e4-bb9d-d8d5ef3849b4", "AQAAAAIAAYagAAAAEHW0IvWYaFLMCEPiUhvJfzvgSX7o5fk8lx0Q5gkgeuO+qAX9VL8OJT81DOZK5clbZg==", "181468d6-7020-4956-bed2-e0cde68181a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65555330-9db1-4131-a303-9fcd97d7532e", "AQAAAAIAAYagAAAAEA9rQeUCCCqIyUl97shbQ9lCxLpF0xYOogkIn0SWq0qUrjady4zD/a8pUEm5OXUbbQ==", "0bd59aee-ff55-40c9-b635-7e2769f35b15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37e26e29-1b7f-4957-b72e-c922ac260d6b", "AQAAAAIAAYagAAAAEA5NTQewI25a3ufkvsSEmQb8xslOA/7bRx93hDF+tCVJogpiQ9dg5AO2P+8z9Z/Vdg==", "9d55ee0e-5de4-4aa9-8c54-575453fad119" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2007, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(2001, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(2004, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(2006, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(2002, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(2008, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(2005, 11, 23, 18, 27, 49, 209, DateTimeKind.Local).AddTicks(2794));
        }
    }
}
