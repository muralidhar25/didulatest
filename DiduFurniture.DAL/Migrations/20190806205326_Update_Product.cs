using Microsoft.EntityFrameworkCore.Migrations;

namespace DiduFurniture.DAL.Migrations
{
    public partial class Update_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialWeaving_ProductCategory_CategoryId1",
                table: "MaterialWeaving");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialWeaving_ProductSubCategories_SubCategoryId1",
                table: "MaterialWeaving");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetail_ProductCategory_CategoryId",
                table: "ProductDetail");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetail_CategoryId",
                table: "ProductDetail");

            migrationBuilder.DropIndex(
                name: "IX_MaterialWeaving_CategoryId1",
                table: "MaterialWeaving");

            migrationBuilder.DropIndex(
                name: "IX_MaterialWeaving_SubCategoryId1",
                table: "MaterialWeaving");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "MaterialWeaving");

            migrationBuilder.DropColumn(
                name: "SubCategoryId1",
                table: "MaterialWeaving");

            migrationBuilder.RenameColumn(
                name: "MaterialName",
                table: "MaterialWeaving",
                newName: "WeavingType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeavingType",
                table: "MaterialWeaving",
                newName: "MaterialName");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ProductDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "MaterialWeaving",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId1",
                table: "MaterialWeaving",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_CategoryId",
                table: "ProductDetail",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialWeaving_CategoryId1",
                table: "MaterialWeaving",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialWeaving_SubCategoryId1",
                table: "MaterialWeaving",
                column: "SubCategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialWeaving_ProductCategory_CategoryId1",
                table: "MaterialWeaving",
                column: "CategoryId1",
                principalTable: "ProductCategory",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialWeaving_ProductSubCategories_SubCategoryId1",
                table: "MaterialWeaving",
                column: "SubCategoryId1",
                principalTable: "ProductSubCategories",
                principalColumn: "SubCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetail_ProductCategory_CategoryId",
                table: "ProductDetail",
                column: "CategoryId",
                principalTable: "ProductCategory",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
