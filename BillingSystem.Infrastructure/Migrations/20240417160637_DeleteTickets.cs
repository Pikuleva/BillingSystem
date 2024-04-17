using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class DeleteTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.AlterTable(
                name: "TypeOfService",
                comment: "Type of service");

            migrationBuilder.AlterTable(
                name: "SatelliteTVs",
                comment: "Satellite television",
                oldComment: "Satellite televiision");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TypeOfService",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                comment: "Name of type",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "TypeOfService",
                type: "int",
                nullable: false,
                comment: "Type of service identificator",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "IPTVs",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Device model name",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Device model name");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d8-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02109f59-4fbd-456a-9f6d-97789dd40bc6", "AQAAAAEAACcQAAAAEDGndbKtZh2CZLNU4ewQo0KH/dqJB31H9Mm9yIlSkGDl48nKfgsmAusLFHAcUObx7A==", "6c0d550c-6b92-4340-a744-c02f41f341bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9dd3c2b-a703-49ea-9f1d-6e5ac36042ce", "AQAAAAEAACcQAAAAEH+6m2kgS09r0YWrTb1AQD99UDWVR3DAA0vBdcXm8uV9/EhkWDRqc5y5/vlGzXwq/A==", "fc582400-57a7-4d9a-81e3-d266870540cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9273c514-ad8e-43bd-81a7-cb9da2addcac", "AQAAAAEAACcQAAAAECX8K50AGuf8/63cr0jGXsUSF7fthMhrN7sPRnxikyGLDEHRTJTlftQoJKuuP18bzQ==", "06c7f3b0-7c5d-48f1-b464-b55e938621ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7780da76-ed53-432d-a892-fe70d8b13cf9", "AQAAAAEAACcQAAAAEEHE7unnYDmYvSm57cwgxAAd0WchxXIv0+L/wsMi7vI3GUl3hiPjw5xjOM17leGnMA==", "4b6cb622-13d7-4239-af23-d90e36a39626" });

            migrationBuilder.UpdateData(
                table: "IPTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 17, 19, 6, 36, 564, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 17, 19, 6, 36, 560, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 17, 19, 6, 36, 568, DateTimeKind.Local).AddTicks(8790));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "TypeOfService",
                oldComment: "Type of service");

            migrationBuilder.AlterTable(
                name: "SatelliteTVs",
                comment: "Satellite televiision",
                oldComment: "Satellite television");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TypeOfService",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldComment: "Name of type");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "TypeOfService",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Type of service identificator")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "IPTVs",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Device model name",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "Device model name");

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Ticket identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "City"),
                    ClientContractNumber = table.Column<int>(type: "int", nullable: false, comment: "Client contract number"),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of created ticket"),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false, comment: "Problem description"),
                    IsComplited = table.Column<bool>(type: "bit", nullable: false, comment: "Is complited ticket"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Street"),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "StreetNumber")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                },
                comment: "Service tickets");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d8-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ce495ee-b340-4e5a-aa1f-074f2e43f96c", "AQAAAAEAACcQAAAAEFiG7l2AyfVoc0Jjd3UMH7v6Sn1Tq2zoDykggs2x+8cufiIJsqtA8RA3S8n/pUUMfA==", "9f8249c8-3efa-4dcc-9a28-712c7474ceca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f4f93eb-3ef7-4d9d-a2b5-a1ae1621b282", "AQAAAAEAACcQAAAAEIqmKcdVZetQxKcdWV+rKDouy/ExBOSC5F/k7jFSqDGxOkh+3jNqHgmvxmgH7280yw==", "ad9b07d1-2b8e-4e38-8f73-5cba5b6ee6f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "775361f6-c4a7-4828-81ef-55bcd4ce452e", "AQAAAAEAACcQAAAAEFVeeFag3aaqxn5IErZ0PuAEnOZJUk/HUuQ5L8F4cajwqYEaHp9RksqK4US9H0z8gw==", "07250d63-32d5-4399-9a76-8ecbbe2f4ee9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cf98818-2e13-4c82-bc86-2e1b09b89b46", "AQAAAAEAACcQAAAAEJUVjCKxAhLpPIKH38jOh1wFEA1XFy/genoo3MLzuHzmEdOtTzeMyT7J8Mntci07Gw==", "024b3fee-0c4f-4193-8ecd-818d265a0df8" });

            migrationBuilder.UpdateData(
                table: "IPTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 15, 9, 47, 36, 531, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 15, 9, 47, 36, 527, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 15, 9, 47, 36, 536, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClientId",
                table: "Tickets",
                column: "ClientId");
        }
    }
}
