using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                comment: "Name of the service",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Name of the service");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "InternetServices",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                comment: "Name of service. Include internet speed",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Name of service. Include internet speed");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "5acbc661-04c5-4bf3-85ae-f70e1b8c1f0e", "support@mail.com", false, false, null, "support@mail.com", "support@mail.com", "AQAAAAEAACcQAAAAENzF27tSZmTS6RBiFtrKo8IqcaIb3Ro2C76O7TRYhzevXlqGvrPAlfOkLn6OJvnkOw==", null, false, "00eb3b69-24ff-4091-8922-d43d36c33e93", false, "support@mail.com" },
                    { "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e", 0, "0361a448-dabd-416b-9e80-5945b1c47578", "cashier@mail.com", false, false, null, "cashier@mail.com", "cashier@mail.com", "AQAAAAEAACcQAAAAECWCGz7RLs0U/3QukN5dKr6IumjN1cqYVbU+3YrP+rDh9HLQmDZ3Q5j7YvWkooTqxQ==", null, false, "a8020dec-1635-4142-a94c-7ba6c8fe52d0", false, "cashier@mail.com" },
                    { "dea12896-c198-4129-b3f3-b893d8395082", 0, "2d511e23-0971-4e40-8992-e56d401bc851", "client@mail.com", false, false, null, "client@mail.com", "client@mail.com", "AQAAAAEAACcQAAAAEPSJA+JL+PRRyVmRJ2qNibISYAxJP53vt3SBnG2pB3jfQhGKEEUmbH1oPPEucqRJng==", null, false, "b8958224-f94e-4c3e-aba8-f6d409255ae9", false, "client@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "TypeOfService",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Internet" },
                    { 2, "SatelliteTv" },
                    { 3, "IPTV" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { 1, "InternetProduct25Mbps", 10.99m, 1 },
                    { 2, "InternetProduct50Mbps", 12.99m, 1 },
                    { 3, "InternetProduct75Mbps", 14.99m, 1 },
                    { 4, "InternetProduct100Mbps", 16.99m, 1 },
                    { 5, "Start", 9.99m, 2 },
                    { 6, "Films", 5.99m, 2 },
                    { 7, "Sport", 11.99m, 2 },
                    { 8, "Popularsciene", 8.99m, 2 },
                    { 9, "Kids", 3.99m, 2 },
                    { 10, "Erotic", 7.99m, 2 },
                    { 11, "Start", 9.99m, 3 },
                    { 12, "Films", 5.99m, 3 },
                    { 13, "Sport", 11.99m, 3 },
                    { 14, "Popularsciene", 8.99m, 3 },
                    { 15, "Kids", 3.99m, 3 },
                    { 16, "Erotic", 7.99m, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TypeOfService",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypeOfService",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypeOfService",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Name of the service",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldComment: "Name of the service");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "InternetServices",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Name of service. Include internet speed",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldComment: "Name of service. Include internet speed");
        }
    }
}
