using Microsoft.EntityFrameworkCore.Migrations;

namespace prs.Migrations
{
    public partial class addedvendorobjecttoproductsclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_PartNumber",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "PartNumber",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PartNumber",
                table: "Products",
                column: "PartNumber",
                unique: true,
                filter: "[PartNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VendorId",
                table: "Products",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PartNumber",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VendorId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "PartNumber",
                table: "Products",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PartNumber",
                table: "Products",
                column: "PartNumber",
                unique: true);
        }
    }
}
