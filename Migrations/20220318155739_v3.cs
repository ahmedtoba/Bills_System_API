using Microsoft.EntityFrameworkCore.Migrations;

namespace Bills_System_API.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "SellingPrice",
                table: "Invoices",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SellingPrice",
                table: "Invoices");
        }
    }
}
