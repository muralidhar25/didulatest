using Microsoft.EntityFrameworkCore.Migrations;

namespace DiduFurniture.DAL.Migrations
{
    public partial class Update_Material_ONE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetail_Material_Id",
                table: "ProductDetail");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductDetail",
                newName: "MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductDetail_Id",
                table: "ProductDetail",
                newName: "IX_ProductDetail_MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetail_Material_MaterialId",
                table: "ProductDetail",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetail_Material_MaterialId",
                table: "ProductDetail");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "ProductDetail",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductDetail_MaterialId",
                table: "ProductDetail",
                newName: "IX_ProductDetail_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetail_Material_Id",
                table: "ProductDetail",
                column: "Id",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
