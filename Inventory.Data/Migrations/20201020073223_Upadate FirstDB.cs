using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Data.Migrations
{
    public partial class UpadateFirstDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Inventory",
                table: "UomCategories");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Inventory",
                table: "Uom");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "Inventory",
                table: "UomCategories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "Inventory",
                table: "Uom",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
