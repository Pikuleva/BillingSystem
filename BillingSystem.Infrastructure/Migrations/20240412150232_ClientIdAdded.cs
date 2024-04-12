using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class ClientIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_InternetServices_InternetServiceId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_IPTVs_IPTVId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_SatelliteTVs_SatelliteTvId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_InternetServiceId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_IPTVId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_SatelliteTvId",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SatelliteTVs",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                comment: "Model of satelite device",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Model of satelite device");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "SatelliteTVs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "IPTVs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "InternetServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adc5447d-aadc-4cf0-81b5-8b0a4ee56265", "AQAAAAEAACcQAAAAEHwN2JdbB0hq+C8ZCrQFBx2PzOMFnai0+LNyGOUf6rViqkemeKCwWVaX5lENHHWIsg==", "0a1efcbe-bb50-4213-bf8c-d739504251c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcdecdfa-1622-440a-8c0d-346e0ab96a69", "AQAAAAEAACcQAAAAEA5QxP23NEz1qeZx3193UbouyJfj1/mWvbm+lYUbTiSP1YjNkKyLTY2LghQN9SjX0w==", "fe3541ad-e8e3-41e0-b29d-7a99a5888322" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "075e6e4a-6627-4861-ba7b-ca52fdb19d3b", "AQAAAAEAACcQAAAAEJvdfFHEs4EJtDIp+06wjCyBsy5/oYTB6VEXCeO8Ny0WSxopYVvuyS7PaN/lccM79A==", "2acbe8c6-702b-412b-9311-197748377014" });

            migrationBuilder.UpdateData(
                table: "IPTVs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveUntilDate", "ClientId" },
                values: new object[] { new DateTime(2024, 5, 12, 18, 2, 32, 235, DateTimeKind.Local).AddTicks(3279), 9999 });

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveUntilDate", "ClientId" },
                values: new object[] { new DateTime(2024, 5, 12, 18, 2, 32, 232, DateTimeKind.Local).AddTicks(438), 9999 });

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveUntilDate", "ClientId" },
                values: new object[] { new DateTime(2024, 5, 12, 18, 2, 32, 238, DateTimeKind.Local).AddTicks(5917), 9999 });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_InternetServiceId",
                table: "Clients",
                column: "InternetServiceId",
                unique: true,
                filter: "[InternetServiceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_IPTVId",
                table: "Clients",
                column: "IPTVId",
                unique: true,
                filter: "[IPTVId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_SatelliteTvId",
                table: "Clients",
                column: "SatelliteTvId",
                unique: true,
                filter: "[SatelliteTvId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_InternetServices_InternetServiceId",
                table: "Clients",
                column: "InternetServiceId",
                principalTable: "InternetServices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_IPTVs_IPTVId",
                table: "Clients",
                column: "IPTVId",
                principalTable: "IPTVs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_SatelliteTVs_SatelliteTvId",
                table: "Clients",
                column: "SatelliteTvId",
                principalTable: "SatelliteTVs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_InternetServices_InternetServiceId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_IPTVs_IPTVId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_SatelliteTVs_SatelliteTvId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_InternetServiceId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_IPTVId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_SatelliteTvId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "SatelliteTVs");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "IPTVs");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "InternetServices");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SatelliteTVs",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Model of satelite device",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldComment: "Model of satelite device");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34e55581-3247-4ddb-94c5-ae429635eb56", "AQAAAAEAACcQAAAAEMewojEA6WI4mv+PUsH6x/Q10+kOpMBNOVRE3PI92GxB29l+mSaU1QI2fgN8ywuWxg==", "4b8d7de5-71c6-40e7-954f-1a7329c98065" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4229b881-3d0f-4b35-977d-3b14cdadb437", "AQAAAAEAACcQAAAAEKCkiYJXM5KvfavM/kl8D04Zh2YHw5Lpk4EcKlgJTw341Pdy4lIRWS4mI0KM4oVByA==", "b8972293-a31a-41ac-813e-84c401e4a49f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bd29ab0-7ad7-4aef-aa8e-30aab9b418b5", "AQAAAAEAACcQAAAAEJdL2paKtulR1ukmgcLfhkwg7bK2ve0a/7pOsSO2QeWuN1s/mcDSpfK8WwjfM0yIEg==", "4313920b-c447-491c-b747-95e3352d82a5" });

            migrationBuilder.UpdateData(
                table: "IPTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 4, 20, 10, 4, 3, 190, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 4, 20, 10, 4, 3, 186, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 4, 20, 10, 4, 3, 193, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.CreateIndex(
                name: "IX_Clients_InternetServiceId",
                table: "Clients",
                column: "InternetServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_IPTVId",
                table: "Clients",
                column: "IPTVId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_SatelliteTvId",
                table: "Clients",
                column: "SatelliteTvId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_InternetServices_InternetServiceId",
                table: "Clients",
                column: "InternetServiceId",
                principalTable: "InternetServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_IPTVs_IPTVId",
                table: "Clients",
                column: "IPTVId",
                principalTable: "IPTVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_SatelliteTVs_SatelliteTvId",
                table: "Clients",
                column: "SatelliteTvId",
                principalTable: "SatelliteTVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
