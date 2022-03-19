using Microsoft.EntityFrameworkCore.Migrations;

namespace Bills_System_API.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TotalBills_Clients_ClientId",
                table: "TotalBills");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "TotalBills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TotalBills_Clients_ClientId",
                table: "TotalBills",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TotalBills_Clients_ClientId",
                table: "TotalBills");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "TotalBills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TotalBills_Clients_ClientId",
                table: "TotalBills",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
