using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.Migrations
{
    public partial class NameFixPT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Clothes_ClothesId",
                table: "ProductTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Products_ProductId",
                table: "ProductTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes");

            migrationBuilder.RenameTable(
                name: "ProductTypes",
                newName: "Product_Type");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTypes_ClothesId",
                table: "Product_Type",
                newName: "IX_Product_Type_ClothesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product_Type",
                table: "Product_Type",
                columns: new[] { "ProductId", "ClothesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Type_Clothes_ClothesId",
                table: "Product_Type",
                column: "ClothesId",
                principalTable: "Clothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Type_Products_ProductId",
                table: "Product_Type",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Type_Clothes_ClothesId",
                table: "Product_Type");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Type_Products_ProductId",
                table: "Product_Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product_Type",
                table: "Product_Type");

            migrationBuilder.RenameTable(
                name: "Product_Type",
                newName: "ProductTypes");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Type_ClothesId",
                table: "ProductTypes",
                newName: "IX_ProductTypes_ClothesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes",
                columns: new[] { "ProductId", "ClothesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Clothes_ClothesId",
                table: "ProductTypes",
                column: "ClothesId",
                principalTable: "Clothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Products_ProductId",
                table: "ProductTypes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
