using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Data.Migrations
{
    public partial class CreationFirstDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Inventory");

            migrationBuilder.CreateTable(
                name: "MeasureType",
                schema: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, defaultValue: 1),
                    _name = table.Column<string>(nullable: true),
                    _id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UomType",
                schema: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, defaultValue: 1),
                    _name = table.Column<string>(nullable: true),
                    _id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UomType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UomCategories",
                schema: "Inventory",
                columns: table => new
                {
                    UoMCategoryId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    name = table.Column<string>(maxLength: 15, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: false),
                    Id = table.Column<int>(nullable: false),
                    MeasureTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UomCategories", x => x.UoMCategoryId);
                    table.ForeignKey(
                        name: "FK_UomCategories_MeasureType_MeasureTypeId",
                        column: x => x.MeasureTypeId,
                        principalSchema: "Inventory",
                        principalTable: "MeasureType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uom",
                schema: "Inventory",
                columns: table => new
                {
                    UoMId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    name = table.Column<string>(maxLength: 15, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: false),
                    ratio = table.Column<double>(nullable: false),
                    UoMCategoryId = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    UomTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uom", x => x.UoMId);
                    table.ForeignKey(
                        name: "FK_Uom_UomCategories_UoMCategoryId",
                        column: x => x.UoMCategoryId,
                        principalSchema: "Inventory",
                        principalTable: "UomCategories",
                        principalColumn: "UoMCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uom_UomType_UomTypeId",
                        column: x => x.UomTypeId,
                        principalSchema: "Inventory",
                        principalTable: "UomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uom_UoMCategoryId",
                schema: "Inventory",
                table: "Uom",
                column: "UoMCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Uom_UomTypeId",
                schema: "Inventory",
                table: "Uom",
                column: "UomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Uom_name",
                schema: "Inventory",
                table: "Uom",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UomCategories_MeasureTypeId",
                schema: "Inventory",
                table: "UomCategories",
                column: "MeasureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UomCategories_name",
                schema: "Inventory",
                table: "UomCategories",
                column: "name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uom",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "UomCategories",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "UomType",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "MeasureType",
                schema: "Inventory");
        }
    }
}
