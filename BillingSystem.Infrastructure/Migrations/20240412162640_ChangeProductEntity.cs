using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class ChangeProductEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "SatelliteTVs",
                type: "int",
                nullable: false,
                comment: "Client Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "IPTVs",
                type: "int",
                nullable: false,
                comment: "Client Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "InternetServices",
                type: "int",
                nullable: false,
                comment: "Client Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SatelliteTvId",
                table: "Clients",
                type: "int",
                nullable: true,
                comment: "Satellite Id",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InternetServiceId",
                table: "Clients",
                type: "int",
                nullable: true,
                comment: "Internet Service Id",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IPTVId",
                table: "Clients",
                type: "int",
                nullable: true,
                comment: "IPTV Id",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95129156-30e4-4e7f-a9c1-1648c4c68ce8", "AQAAAAEAACcQAAAAEEECVM5+0PIYDdaQ74/t9bMHl3mJXpsG/vOsVR9dJIZpv18pntmf1QCzvIn5+ewx+g==", "8dbd2577-a7bc-48b3-887a-2b5873570fbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "723179d2-361d-4366-926a-9ad92eeb6db5", "AQAAAAEAACcQAAAAEA0aBEk64WRAKmciLY6KZJIpMeAqSLlnHLyI1utM4oTCB0TJJ7pf030Xhc37Aoof1Q==", "2d11dd91-61fe-475c-af14-0e8fa41055f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff374d89-6abf-4868-924f-bb8c8c3ab395", "AQAAAAEAACcQAAAAEJ4aeBA9dPPYdtGoGJHPQy3UE96owX09LPVb2zm35MufOxWx7hSeO4ohobxgq2qKzg==", "6a176f34-4628-4800-a9d2-c10a35e51b60" });

            migrationBuilder.UpdateData(
                table: "IPTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 12, 19, 26, 40, 111, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 12, 19, 26, 40, 107, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 12, 19, 26, 40, 114, DateTimeKind.Local).AddTicks(8748));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "SatelliteTVs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Client Id");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "IPTVs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Client Id");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "InternetServices",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Client Id");

            migrationBuilder.AlterColumn<int>(
                name: "SatelliteTvId",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Satellite Id");

            migrationBuilder.AlterColumn<int>(
                name: "InternetServiceId",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Internet Service Id");

            migrationBuilder.AlterColumn<int>(
                name: "IPTVId",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "IPTV Id");

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
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 12, 18, 2, 32, 235, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 12, 18, 2, 32, 232, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 12, 18, 2, 32, 238, DateTimeKind.Local).AddTicks(5917));
        }
    }
}
