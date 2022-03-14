using Microsoft.EntityFrameworkCore.Migrations;

namespace Bills_System_API.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaidUp",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "TotalBills",
                table: "Clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PaidUp",
                table: "Clients",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalBills",
                table: "Clients",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
