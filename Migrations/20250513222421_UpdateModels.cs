using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriEnergyConnectApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Farmers_FarmerId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Farmers",
                table: "Farmers");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Farmers",
                newName: "Farmer");

            migrationBuilder.RenameIndex(
                name: "IX_Products_FarmerId",
                table: "Product",
                newName: "IX_Product_FarmerId");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Farmer",
                table: "Farmer",
                column: "FarmerId");

            migrationBuilder.InsertData(
                table: "Farmer",
                columns: new[] { "FarmerId", "Address", "Email", "Name", "Phone" },
                values: new object[] { 1, "Western Cape", "adrian.f@gmail.com", "Adrian Finnis", "0811234567" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "FarmerId", "Name", "ProductionDate", "Quantity" },
                values: new object[] { 1, "Grain", 1, "Maize", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Farmer_FarmerId",
                table: "Product",
                column: "FarmerId",
                principalTable: "Farmer",
                principalColumn: "FarmerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Farmer_FarmerId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Farmer",
                table: "Farmer");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Farmer",
                keyColumn: "FarmerId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Farmer",
                newName: "Farmers");

            migrationBuilder.RenameIndex(
                name: "IX_Product_FarmerId",
                table: "Products",
                newName: "IX_Products_FarmerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Farmers",
                table: "Farmers",
                column: "FarmerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Farmers_FarmerId",
                table: "Products",
                column: "FarmerId",
                principalTable: "Farmers",
                principalColumn: "FarmerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
