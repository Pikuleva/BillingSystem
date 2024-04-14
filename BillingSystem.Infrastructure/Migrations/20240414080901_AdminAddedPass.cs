using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class AdminAddedPass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d8-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59fa480e-6151-4c4b-b361-714712e06856", "70f66798-d44a-40a7-9525-decfe4e961e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31096906-8359-4d05-b195-33f2aec034da", "AQAAAAEAACcQAAAAEJhVe3cw2V+8qNVc4H+5w9d6fHdWuH8vqWWRR3VMc3DFuWzFgCkW13zAmToVcJDkag==", "a30ed54c-7503-4094-bb6f-589a88291604" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec1911d0-9d5e-47d5-9bbe-63eb0b9cb191", "AQAAAAEAACcQAAAAEMe77oXQPxFS+HHNu03bmnOjSalZZSC5S30S63VPSpPUN3D6Mkm2mARPFmrCP8Y/2g==", "df10eec2-54ed-4a4a-a704-e0e9548221a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12896-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1971604c-4c14-4092-904c-d4473f7cd814", "AQAAAAEAACcQAAAAECP9RJ5Jj7jMD9Sb6BFgIAxn9JFaonbb3sDmmm151Q0zHal36SrCM0aGhFecrWHgGA==", "50d7bf2d-11d2-48f0-a68c-51eb5cc78748" });

            migrationBuilder.UpdateData(
                table: "IPTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 9, 0, 745, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "InternetServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 9, 0, 741, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "SatelliteTVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActiveUntilDate",
                value: new DateTime(2024, 5, 14, 11, 9, 0, 750, DateTimeKind.Local).AddTicks(2742));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d8-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "681575af-ccf1-41c2-92c0-39e743f9ec2b", "a0752e5b-59b0-452b-870c-810abe5993a4" });

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
    }
}
