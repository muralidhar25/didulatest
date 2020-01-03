using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiduFurniture.DAL.Migrations
{
    public partial class AddSalesOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "salesItems",
                columns: table => new
                {
                    SiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SlaesOrderNumber = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    SubCategoryId = table.Column<int>(nullable: false),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Anyam = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaterialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesItems", x => x.SiId);
                    table.ForeignKey(
                        name: "FK_salesItems_ProductCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_salesItems_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_salesItems_ProductSubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "ProductSubCategories",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "salesOrders",
                columns: table => new
                {
                    SoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SalOrdNumber = table.Column<string>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    ShippedBy = table.Column<string>(nullable: true),
                    DeliveryNotes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConfirmedBy = table.Column<string>(nullable: true),
                    SalesPerson = table.Column<string>(nullable: true),
                    SalesOrderStatus = table.Column<string>(nullable: true),
                    Paymentstatus = table.Column<string>(nullable: true),
                    ProductionStatus = table.Column<string>(nullable: true),
                    ShipmentStatus = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesOrders", x => x.SoId);
                    table.ForeignKey(
                        name: "FK_salesOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_salesItems_CategoryId",
                table: "salesItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_salesItems_MaterialId",
                table: "salesItems",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_salesItems_SubCategoryId",
                table: "salesItems",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_salesOrders_CustomerId",
                table: "salesOrders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "salesItems");

            migrationBuilder.DropTable(
                name: "salesOrders");
        }
    }
}
