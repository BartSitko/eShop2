using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.Migrations
{
    public partial class InitialOfficial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "ProductTypes");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Types_ClothesId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "Product_Types");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTypes_ClothesId",
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
    }
}
