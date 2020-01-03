using Microsoft.EntityFrameworkCore.Migrations;

namespace DiduFurniture.DAL.Migrations
{
    public partial class Removing_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_ProductCategory_CategoryId",
                table: "SubCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_ProductSubCategories_SubCategoryId",
                table: "SubCategory");

            migrationBuilder.DropIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory");

            migrationBuilder.DropIndex(
                name: "IX_SubCategory_SubCategoryId",
                table: "SubCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_SubCategoryId",
                table: "SubCategory",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_ProductCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId",
                principalTable: "ProductCategory",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_ProductSubCategories_SubCategoryId",
                table: "SubCategory",
                column: "SubCategoryId",
                principalTable: "ProductSubCategories",
                principalColumn: "SubCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
