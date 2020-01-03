using Microsoft.EntityFrameworkCore.Migrations;

namespace DiduFurniture.DAL.Migrations
{
    public partial class Update_Material : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "ProductDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeavingId",
                table: "ProductDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_Id",
                table: "ProductDetail",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_WeavingId",
                table: "ProductDetail",
                column: "WeavingId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetail_Material_Id",
                table: "ProductDetail",
                column: "Id",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetail_MaterialWeaving_WeavingId",
                table: "ProductDetail",
                column: "WeavingId",
                principalTable: "MaterialWeaving",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetail_Material_Id",
                table: "ProductDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetail_MaterialWeaving_WeavingId",
                table: "ProductDetail");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetail_Id",
                table: "ProductDetail");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetail_WeavingId",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "WeavingId",
                table: "ProductDetail");
        }
    }
}
