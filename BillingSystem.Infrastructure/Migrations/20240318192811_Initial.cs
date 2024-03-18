using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Name of the service"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Price of  service")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_TypeOfService_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeOfService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "IPTV product");

            migrationBuilder.CreateTable(
                name: "InternetServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Internet service identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Name of service. Include internet speed"),
                    RouterMACAdress = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false, comment: "MAC address client device"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Internet product Identificator"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "The service is paid/unpaid"),
                    ActiveUntilDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Until which date the service is active")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternetServices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Internet service");

            migrationBuilder.CreateTable(
                name: "IPTVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Interactive television identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<int>(type: "int", nullable: false, comment: "Serial number of device"),
                    ActiveUntilDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Until which date the service is active"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Device model name"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Television product Identificator")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPTVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPTVs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Interactive television");

            migrationBuilder.CreateTable(
                name: "SatelliteTVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Satellite television identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<int>(type: "int", nullable: false, comment: "Satellite device serial number"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Model of satelite device"),
                    ActiveUntilDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Until which date the service is active"),
                    PacketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatelliteTVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatelliteTVs_Products_PacketId",
                        column: x => x.PacketId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Satellite televiision");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Client identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Client first name"),
                    MiddleName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Client middle name"),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Client last name"),
                    CivilNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Client persanal number"),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "City where customer uses the service"),
                    StreetName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "Street where customer uses the service"),
                    StreetNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "StreetNumber where customer uses the service"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Client phone number"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client Email address"),
                    InternetServiceId = table.Column<int>(type: "int", nullable: true),
                    IPTVId = table.Column<int>(type: "int", nullable: true),
                    SatelliteTvId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_InternetServices_InternetServiceId",
                        column: x => x.InternetServiceId,
                        principalTable: "InternetServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_IPTVs_IPTVId",
                        column: x => x.IPTVId,
                        principalTable: "IPTVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_SatelliteTVs_SatelliteTvId",
                        column: x => x.SatelliteTvId,
                        principalTable: "SatelliteTVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Client contract");

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Ticket identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientContractNumber = table.Column<int>(type: "int", nullable: false, comment: "Client contract number"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of created ticket"),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false, comment: "Problem description"),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "City"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Street"),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "StreetNumber"),
                    IsComplited = table.Column<bool>(type: "bit", nullable: false, comment: "Is complited ticket"),
                    ClientId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5610ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "c1b7fd93-683b-45c7-af1e-6c603d0f675f", "support@mail.com", false, false, null, "support@mail.com", "support@mail.com", "AQAAAAEAACcQAAAAEMaAtLdorjIed430mODMgTvdFvF1wXTuRGfkCoepcwvd48j0J+MmaPoEjOuf5OwV6Q==", null, false, "33bcf0aa-ebf6-4899-bc15-791ff76fda9e", false, "support@mail.com" },
                    { "6d5800ce-d826-4fc8-83d9-d6b3ac1f591e", 0, "8caf04d1-6208-4902-a7c3-99ed5a998c53", "cashier@mail.com", false, false, null, "cashier@mail.com", "cashier@mail.com", "AQAAAAEAACcQAAAAEAsdSAycf7qFwOfeytutixtUBzkiFh/kbeenxmmZbwmAucIqH7+z8YE+sGz5NjOnmg==", null, false, "bcc83e24-bc3c-4ad5-92c0-8c1a2295742b", false, "cashier@mail.com" },
                    { "dea12896-c198-4129-b3f3-b893d8395082", 0, "18eab486-6281-4367-aabe-1c46553e66f6", "client@mail.com", false, false, null, "client@mail.com", "client@mail.com", "AQAAAAEAACcQAAAAEAYtZLTqGqBPN8TQvQKXrTyLnSD67WCQBBGJaLRA3UAVNZIMJz3Jws90Fm1+pdNGgw==", null, false, "5a147b58-c120-40e1-b746-9ff65bef451a", false, "client@mail.com" }
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
                    { 11, "Start", 9.99m, 3 },
                    { 12, "Films", 5.99m, 3 },
                    { 13, "Sport", 11.99m, 3 },
                    { 14, "Popularsciene", 8.99m, 3 },
                    { 15, "Kids", 3.99m, 3 },
                    { 16, "Erotic", 7.99m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "IX_InternetServices_ProductId",
                table: "InternetServices",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_IPTVs_ProductId",
                table: "IPTVs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeId",
                table: "Products",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SatelliteTVs_PacketId",
                table: "SatelliteTVs",
                column: "PacketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClientId",
                table: "Tickets",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "InternetServices");

            migrationBuilder.DropTable(
                name: "IPTVs");

            migrationBuilder.DropTable(
                name: "SatelliteTVs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "TypeOfService");
        }
    }
}
