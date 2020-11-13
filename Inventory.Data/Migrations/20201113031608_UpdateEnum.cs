using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Data.Migrations
{
    public partial class UpdateEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uom_UomType_UomTypeId",
                schema: "Inventory",
                table: "Uom");

            migrationBuilder.DropIndex(
                name: "IX_Uom_UomTypeId",
                schema: "Inventory",
                table: "Uom");

            migrationBuilder.DropColumn(
                name: "UomTypeId",
                schema: "Inventory",
                table: "Uom");

            migrationBuilder.CreateIndex(
                name: "IX_Uom_Id",
                schema: "Inventory",
                table: "Uom",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Uom_UomType_Id",
                schema: "Inventory",
                table: "Uom",
                column: "Id",
                principalSchema: "Inventory",
                principalTable: "UomType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uom_UomType_Id",
                schema: "Inventory",
                table: "Uom");

            migrationBuilder.DropIndex(
                name: "IX_Uom_Id",
                schema: "Inventory",
                table: "Uom");

            migrationBuilder.AddColumn<int>(
                name: "UomTypeId",
                schema: "Inventory",
                table: "Uom",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uom_UomTypeId",
                schema: "Inventory",
                table: "Uom",
                column: "UomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Uom_UomType_UomTypeId",
                schema: "Inventory",
                table: "Uom",
                column: "UomTypeId",
                principalSchema: "Inventory",
                principalTable: "UomType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
