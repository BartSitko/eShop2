using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.Migrations
{
    public partial class NameFixPT2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "Product_Types");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Type_ClothesId",
                table: "Product_Types",
                newName: "IX_Product_Types_ClothesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product_Types",
                table: "Product_Types",
                columns: new[] { "ProductId", "ClothesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Types_Clothes_ClothesId",
                table: "Product_Types",
                column: "ClothesId",
                principalTable: "Clothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Types_Products_ProductId",
                table: "Product_Types",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Types_Clothes_ClothesId",
                table: "Product_Types");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Types_Products_ProductId",
                table: "Product_Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product_Types",
                table: "Product_Types");

            migrationBuilder.RenameTable(
                name: "Product_Types",
                newName: "Product_Type");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Types_ClothesId",
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
    }
}
