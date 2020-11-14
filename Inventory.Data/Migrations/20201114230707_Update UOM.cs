using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Data.Migrations
{
    public partial class UpdateUOM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uom_UomType_Id",
                schema: "Inventory",
                table: "Uom");

            migrationBuilder.DropTable(
                name: "UomType",
                schema: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Uom_Id",
                schema: "Inventory",
                table: "Uom");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UomType",
                schema: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UomType", x => x.Id);
                });

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
    }
}
