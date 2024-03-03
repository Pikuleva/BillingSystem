using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InternetProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Internet product identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Name of internet service"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Price of internet service")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetProducts", x => x.Id);
                },
                comment: "Internet product");

            migrationBuilder.CreateTable(
                name: "IPTVProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "IPTV identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Name of the service"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Price of television service")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPTVProducts", x => x.Id);
                },
                comment: "IPTV product");

            migrationBuilder.CreateTable(
                name: "SatelliteTVProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "IPTV identificator")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Name of packet"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Price of television service")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatelliteTVProducts", x => x.Id);
                },
                comment: "SatelliteTV packet");

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
                    IsComplited = table.Column<bool>(type: "bit", nullable: false, comment: "Is complited ticket")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
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
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "The service is paid/unpaid"),
                    ActiveUntilDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Until which date the service is active")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternetServices_InternetProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "InternetProducts",
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
                    PacketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPTVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPTVs_IPTVProducts_PacketId",
                        column: x => x.PacketId,
                        principalTable: "IPTVProducts",
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
                        name: "FK_SatelliteTVs_SatelliteTVProducts_PacketId",
                        column: x => x.PacketId,
                        principalTable: "SatelliteTVProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Satellite televiision");

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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client Email address"),
                    InternetServiceId = table.Column<int>(type: "int", nullable: false, comment: "Internet service identificator"),
                    IPTVId = table.Column<int>(type: "int", nullable: false, comment: "Interactive television identificator"),
                    SatelliteTvId = table.Column<int>(type: "int", nullable: false, comment: "SatelliteTV identificator"),
                    TicketId = table.Column<int>(type: "int", nullable: false, comment: "Ticket identificator")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsContracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientsContracts_InternetServices_InternetServiceId",
                        column: x => x.InternetServiceId,
                        principalTable: "InternetServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientsContracts_IPTVs_IPTVId",
                        column: x => x.IPTVId,
                        principalTable: "IPTVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientsContracts_SatelliteTVs_SatelliteTvId",
                        column: x => x.SatelliteTvId,
                        principalTable: "SatelliteTVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientsContracts_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Client contract");

            migrationBuilder.CreateTable(
                name: "ClientsServices",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false, comment: "Client identificator"),
                    InternetServiceId = table.Column<int>(type: "int", nullable: false, comment: "Internet service identificator"),
                    IPTVId = table.Column<int>(type: "int", nullable: false, comment: "IPTV identificator"),
                    TicketId = table.Column<int>(type: "int", nullable: false, comment: "Ticket identificator"),
                    SatelliteTVId = table.Column<int>(type: "int", nullable: false, comment: "SatelliteTV identificator")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsServices", x => new { x.ClientId, x.IPTVId, x.TicketId, x.InternetServiceId });
                    table.ForeignKey(
                        name: "FK_ClientsServices_ClientsContracts_ClientId",
                        column: x => x.ClientId,
                        principalTable: "ClientsContracts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientsServices_InternetServices_InternetServiceId",
                        column: x => x.InternetServiceId,
                        principalTable: "InternetServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientsServices_IPTVs_IPTVId",
                        column: x => x.IPTVId,
                        principalTable: "IPTVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientsServices_SatelliteTVs_SatelliteTVId",
                        column: x => x.SatelliteTVId,
                        principalTable: "SatelliteTVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientsServices_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Services used by the client");

            migrationBuilder.CreateIndex(
                name: "IX_ClientsContracts_InternetServiceId",
                table: "ClientsContracts",
                column: "InternetServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientsContracts_IPTVId",
                table: "ClientsContracts",
                column: "IPTVId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientsContracts_SatelliteTvId",
                table: "ClientsContracts",
                column: "SatelliteTvId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientsContracts_TicketId",
                table: "ClientsContracts",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientsServices_InternetServiceId",
                table: "ClientsServices",
                column: "InternetServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientsServices_IPTVId",
                table: "ClientsServices",
                column: "IPTVId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientsServices_SatelliteTVId",
                table: "ClientsServices",
                column: "SatelliteTVId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientsServices_TicketId",
                table: "ClientsServices",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_InternetServices_ProductId",
                table: "InternetServices",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_IPTVs_PacketId",
                table: "IPTVs",
                column: "PacketId");

            migrationBuilder.CreateIndex(
                name: "IX_SatelliteTVs_PacketId",
                table: "SatelliteTVs",
                column: "PacketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientsServices");

            migrationBuilder.DropTable(
                name: "ClientsContracts");

            migrationBuilder.DropTable(
                name: "InternetServices");

            migrationBuilder.DropTable(
                name: "IPTVs");

            migrationBuilder.DropTable(
                name: "SatelliteTVs");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "InternetProducts");

            migrationBuilder.DropTable(
                name: "IPTVProducts");

            migrationBuilder.DropTable(
                name: "SatelliteTVProducts");
        }
    }
}
