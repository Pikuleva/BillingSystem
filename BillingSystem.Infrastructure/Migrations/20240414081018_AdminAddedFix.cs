using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class AdminAddedFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5610ce-d726-4fc8-83d8-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59fa480e-6151-4c4b-b361-714712e06856", null, "70f66798-d44a-40a7-9525-decfe4e961e1" });

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
    }
}
