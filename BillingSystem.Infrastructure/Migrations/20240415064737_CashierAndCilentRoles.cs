using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class CashierAndCilentRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d8-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c935e0f0-2801-44a8-aa50-4a6af7de5a13", "AQAAAAEAACcQAAAAEGzAW+ec7xYgArNw88NYrO0x5PDRr9bfBWlg72MefzRVQm1Q39M+LxwAldxH2Paskg==", "9a920844-0900-4469-b429-45fe4c465c59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "509081e4-4f4b-4347-9518-42380789d1df", "AQAAAAEAACcQAAAAEPsSyH3z/cbB/GQ0za/ZGIyOavPHGyGs7JJ/1I9tf7eQCNF1/04f7p+JKlPh+ug3ng==", "f2e793fe-5626-47db-bd61-2c4487643171" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae90d36f-d362-4a37-bf97-bf4c4f6f78ee", "AQAAAAEAACcQAAAAEKCZFOT5a7FfVh1hqkcDyAA1/ublPbheo6H12jXYz8q+XbcEhV9HLwXXXBEuE7VZnA==", "3e7a2a9e-acbe-49bb-9de4-51c7716bc1ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a5416b8-9503-4298-ad49-79319ebedcc2", "AQAAAAEAACcQAAAAEETGqT7hP59FcXNbEEzMjbDGEr0RgFpU+JKUbDMR4vRYPkykywXzsmEOK33CFRJEEg==", "6613ddd9-04bf-4af7-b592-d618c099c254" });

            migrationBuilder.UpdateData(
                table: "IPTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 10, 17, 739, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 10, 17, 735, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 10, 17, 743, DateTimeKind.Local).AddTicks(4678));
        }
    }
}
