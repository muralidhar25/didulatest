using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiduFurniture.DAL.Migrations
{
    public partial class MaterialWeaving : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaterialWeaving",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaterialName = table.Column<string>(nullable: false),
                    CategoryId1 = table.Column<int>(nullable: false),
                    SubCategoryId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialWeaving", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialWeaving_ProductCategory_CategoryId1",
                        column: x => x.CategoryId1,
                        principalTable: "ProductCategory",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialWeaving_ProductSubCategories_SubCategoryId1",
                        column: x => x.SubCategoryId1,
                        principalTable: "ProductSubCategories",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialWeaving_CategoryId1",
                table: "MaterialWeaving",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialWeaving_SubCategoryId1",
                table: "MaterialWeaving",
                column: "SubCategoryId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialWeaving");
        }
    }
}
