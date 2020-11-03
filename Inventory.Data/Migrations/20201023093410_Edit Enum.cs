using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Data.Migrations
{
    public partial class EditEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_id",
                schema: "Inventory",
                table: "UomType");

            migrationBuilder.DropColumn(
                name: "_name",
                schema: "Inventory",
                table: "UomType");

            migrationBuilder.DropColumn(
                name: "_id",
                schema: "Inventory",
                table: "MeasureType");

            migrationBuilder.DropColumn(
                name: "_name",
                schema: "Inventory",
                table: "MeasureType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "_id",
                schema: "Inventory",
                table: "UomType",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "_name",
                schema: "Inventory",
                table: "UomType",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_id",
                schema: "Inventory",
                table: "MeasureType",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "_name",
                schema: "Inventory",
                table: "MeasureType",
                type: "text",
                nullable: true);
        }
    }
}
