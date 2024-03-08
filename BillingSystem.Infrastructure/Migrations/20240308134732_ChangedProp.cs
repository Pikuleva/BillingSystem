using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillingSystem.Infrastructure.Migrations
{
    public partial class ChangedProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractNumber",
                table: "ClientsContracts");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "ClientsContracts",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Client phone number",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Client phone number");

            migrationBuilder.AlterColumn<string>(
                name: "CivilNumber",
                table: "ClientsContracts",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "Client persanal number",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Client persanal number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "ClientsContracts",
                type: "int",
                nullable: false,
                comment: "Client phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "Client phone number");

            migrationBuilder.AlterColumn<int>(
                name: "CivilNumber",
                table: "ClientsContracts",
                type: "int",
                nullable: false,
                comment: "Client persanal number",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "Client persanal number");

            migrationBuilder.AddColumn<int>(
                name: "ContractNumber",
                table: "ClientsContracts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Contract number");
        }
    }
}
