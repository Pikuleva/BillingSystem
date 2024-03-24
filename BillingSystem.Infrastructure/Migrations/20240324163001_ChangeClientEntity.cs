using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class ChangeClientEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3d6d67fa-6480-498a-8851-1771d0a11830", "AQAAAAEAACcQAAAAED4fFyG+6E6CyZ2Cc2l4v9Nfa6f+QY6Xf0tb3GJbOAuh+85cc799ey/s0/xElUHtpw==", "8506731c-46cc-449d-85f6-9ce5ff670b50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2949a64-40c3-466b-929e-18f3969d9cfd", "AQAAAAEAACcQAAAAEAS1H8Gb/RLQ3+UEeHqlx+h/DiEbw8tDsbFyowyu+pvSngaQLR+88ZjPXVTMLiHKSQ==", "8154ce96-cc71-42b3-825e-cf35ba16b697" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "137422a8-0b75-41ca-834c-dfabbd3fd08b", "AQAAAAEAACcQAAAAEDpfmNvab1Ka5/ZgfYmC+26V1Lc4MpDkzASV67Dk9lrziqUY35f/yJmAljUZY6Me4w==", "14f7a63f-6878-41ac-a6de-a0743e119634" });

            migrationBuilder.UpdateData(
                table: "IPTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 4, 24, 18, 30, 0, 766, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 4, 24, 18, 30, 0, 762, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 4, 24, 18, 30, 0, 769, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.CreateIndex(
                name: "IX_SatelliteTVs_ClientId",
                table: "SatelliteTVs",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_IPTVs_ClientId",
                table: "IPTVs",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_InternetServices_ClientId",
                table: "InternetServices",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternetServices_Clients_ClientId",
                table: "InternetServices",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IPTVs_Clients_ClientId",
                table: "IPTVs",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SatelliteTVs_Clients_ClientId",
                table: "SatelliteTVs",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternetServices_Clients_ClientId",
                table: "InternetServices");

            migrationBuilder.DropForeignKey(
                name: "FK_IPTVs_Clients_ClientId",
                table: "IPTVs");

            migrationBuilder.DropForeignKey(
                name: "FK_SatelliteTVs_Clients_ClientId",
                table: "SatelliteTVs");

            migrationBuilder.DropIndex(
                name: "IX_SatelliteTVs_ClientId",
                table: "SatelliteTVs");

            migrationBuilder.DropIndex(
                name: "IX_IPTVs_ClientId",
                table: "IPTVs");

            migrationBuilder.DropIndex(
                name: "IX_InternetServices_ClientId",
                table: "InternetServices");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "SatelliteTVs");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "IPTVs");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "InternetServices");

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
        }
    }
}
