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
                name: "ClientsContracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Client identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<int>(type: "int", nullable: false, comment: "Contract number"),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Client first name"),
                    MiddleName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Client middle name"),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Client last name"),
                    CivilNumber = table.Column<int>(type: "int", nullable: false, comment: "Client persanal number"),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "City where customer uses the service"),
                    StreetName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "Street where customer uses the service"),
                    StreetNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "StreetNumber where customer uses the service"),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false, comment: "Client phone number"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client Email address")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsContracts", x => x.Id);
                },
                comment: "Client contract");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Name of the service"),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Price of  service")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                },
                comment: "IPTV product");

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
                        name: "FK_Tickets_ClientsContracts_ClientId",
                        column: x => x.ClientId,
                        principalTable: "ClientsContracts",
                        principalColumn: "Id");
                },
                comment: "Service tickets");

            migrationBuilder.CreateTable(
                name: "InternetServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Internet service identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Name of service. Include internet speed"),
                    RouterMACAdress = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false, comment: "MAC address client device"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Internet product Identificator"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "The service is paid/unpaid"),
                    ActiveUntilDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Until which date the service is active"),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternetServices_ClientsContracts_ClientId",
                        column: x => x.ClientId,
                        principalTable: "ClientsContracts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InternetServices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Television product Identificator"),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPTVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPTVs_ClientsContracts_ClientId",
                        column: x => x.ClientId,
                        principalTable: "ClientsContracts",
                        principalColumn: "Id");
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
                    PacketId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatelliteTVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatelliteTVs_ClientsContracts_ClientId",
                        column: x => x.ClientId,
                        principalTable: "ClientsContracts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SatelliteTVs_Products_PacketId",
                        column: x => x.PacketId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Satellite televiision");

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
                name: "IX_InternetServices_ClientId",
                table: "InternetServices",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_InternetServices_ProductId",
                table: "InternetServices",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_IPTVs_ClientId",
                table: "IPTVs",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_IPTVs_ProductId",
                table: "IPTVs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SatelliteTVs_ClientId",
                table: "SatelliteTVs",
                column: "ClientId");

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
                name: "InternetServices");

            migrationBuilder.DropTable(
                name: "IPTVs");

            migrationBuilder.DropTable(
                name: "SatelliteTVs");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ClientsContracts");
        }
    }
}
