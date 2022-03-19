using Microsoft.EntityFrameworkCore.Migrations;

namespace Bills_System_API.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecentageDiscount",
                table: "TotalBills",
                newName: "PercentageDiscount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PercentageDiscount",
                table: "TotalBills",
                newName: "PrecentageDiscount");
        }
    }
}
