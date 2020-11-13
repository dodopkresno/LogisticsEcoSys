using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Data.Migrations
{
    public partial class TestDropEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UomCategories_MeasureType_Id",
                schema: "Inventory",
                table: "UomCategories");

            migrationBuilder.DropTable(
                name: "MeasureType",
                schema: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_UomCategories_Id",
                schema: "Inventory",
                table: "UomCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeasureType",
                schema: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureType", x => x.Id);
                });

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
    }
}
