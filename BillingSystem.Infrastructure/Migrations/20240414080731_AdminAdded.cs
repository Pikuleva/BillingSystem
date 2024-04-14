using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2874ab46-ae06-4ae3-a556-e89fdfbfe342", "AQAAAAEAACcQAAAAEDEwWXLRBBHBRVLyRKPPuWwTIeQFBGIYxpiXkijFkagzY6iErV1U4/6RMp7P41FZug==", "9ca5b778-d0e9-4e07-a79b-7fad0f08720c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d52d9b2-58f4-4f50-b8e7-376208ceeba3", "AQAAAAEAACcQAAAAEHm/Cr21dFFpM/mCSqrBMvukSSnlK4fWmrGY6GwpJV0fzE7/xpZCDCqKVkSQNopB6g==", "543b86bb-f62e-46f1-86a8-61b45582c0ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ebfde98-8483-4c6d-abe4-cb39ea11681e", "AQAAAAEAACcQAAAAEEtkk4ncQGJKR78TvA/nET8YiqbiV1Cc/WZRBQV5JI1sjlIxeTVDRrhxcW6EgPTJAQ==", "de72cda8-6179-4d47-be0c-5d879f3e726b" });

            migrationBuilder.UpdateData(
                table: "IPTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 7, 30, 977, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 7, 30, 973, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 7, 30, 982, DateTimeKind.Local).AddTicks(341));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
