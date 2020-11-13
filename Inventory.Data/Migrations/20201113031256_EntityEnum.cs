using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Data.Migrations
{
    public partial class EntityEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UomCategories_MeasureType_MeasureTypeId",
                schema: "Inventory",
                table: "UomCategories");

            migrationBuilder.DropIndex(
                name: "IX_UomCategories_MeasureTypeId",
                schema: "Inventory",
                table: "UomCategories");

            migrationBuilder.DropColumn(
                name: "MeasureTypeId",
                schema: "Inventory",
                table: "UomCategories");

            migrationBuilder.CreateIndex(
                name: "IX_UomCategories_Id",
                schema: "Inventory",
                table: "UomCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UomCategories_MeasureType_Id",
                schema: "Inventory",
                table: "UomCategories",
                column: "Id",
                principalSchema: "Inventory",
                principalTable: "MeasureType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UomCategories_MeasureType_Id",
                schema: "Inventory",
                table: "UomCategories");

            migrationBuilder.DropIndex(
                name: "IX_UomCategories_Id",
                schema: "Inventory",
                table: "UomCategories");

            migrationBuilder.AddColumn<int>(
                name: "MeasureTypeId",
                schema: "Inventory",
                table: "UomCategories",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UomCategories_MeasureTypeId",
                schema: "Inventory",
                table: "UomCategories",
                column: "MeasureTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_UomCategories_MeasureType_MeasureTypeId",
                schema: "Inventory",
                table: "UomCategories",
                column: "MeasureTypeId",
                principalSchema: "Inventory",
                principalTable: "MeasureType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
