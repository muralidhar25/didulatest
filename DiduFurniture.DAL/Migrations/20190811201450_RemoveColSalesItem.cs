using Microsoft.EntityFrameworkCore.Migrations;

namespace DiduFurniture.DAL.Migrations
{
    public partial class RemoveColSalesItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlaesOrderNumber",
                table: "salesItems");

            migrationBuilder.AddColumn<int>(
                name: "SoId",
                table: "salesItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_salesItems_SoId",
                table: "salesItems",
                column: "SoId");

            migrationBuilder.AddForeignKey(
                name: "FK_salesItems_salesOrders_SoId",
                table: "salesItems",
                column: "SoId",
                principalTable: "salesOrders",
                principalColumn: "SoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salesItems_salesOrders_SoId",
                table: "salesItems");

            migrationBuilder.DropIndex(
                name: "IX_salesItems_SoId",
                table: "salesItems");

            migrationBuilder.DropColumn(
                name: "SoId",
                table: "salesItems");

            migrationBuilder.AddColumn<string>(
                name: "SlaesOrderNumber",
                table: "salesItems",
                nullable: false,
                defaultValue: "");
        }
    }
}
