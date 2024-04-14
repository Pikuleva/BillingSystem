using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class AdminAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccf61b75-c9e1-4758-bdd1-e10d7537dedc", "AQAAAAEAACcQAAAAECymI05hfeIYcA3SHIsaEXLEBsSEcQBBt963zeCvVK24k+avTtPjmWXh+hblsKZNAA==", "d22a3af0-eecf-4721-8944-5d7263764485" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8bd80b7-f9b8-4dd1-913b-edb28aeff4a2", "AQAAAAEAACcQAAAAEKl6gXAwWk7W2/9xT3BpCb4prsmrfynBj+MpBctp3kznkJlEKiA4hG92whwlaxTwrQ==", "7d98c6b0-ac03-4d68-9190-742c961b99e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2da59833-7199-445c-ab2b-462880770748", "AQAAAAEAACcQAAAAEFDRWtOZ3ywJJMCl7zG1Hjp/QJT5+z/fUUjT9gbChSTyaYJeEdSMWuGHhYaxl7Zn2Q==", "e485f185-81e1-4f16-b014-071f53f17181" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6d5610ce-d726-4fc8-83d8-d6b3ac1f591e", 0, "681575af-ccf1-41c2-92c0-39e743f9ec2b", "admin@mail.com", false, false, null, "admin@mail.com", "admin@mail.com", null, null, false, "a0752e5b-59b0-452b-870c-810abe5993a4", false, "admin@mail.com" });

            migrationBuilder.UpdateData(
                table: "IPTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 8, 11, 467, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 8, 11, 461, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 8, 11, 473, DateTimeKind.Local).AddTicks(1244));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d8-d6b3ac1f591e");

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
    }
}
