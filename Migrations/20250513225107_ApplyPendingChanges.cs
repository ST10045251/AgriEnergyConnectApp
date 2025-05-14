using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriEnergyConnectApp.Migrations
{
    /// <inheritdoc />
    public partial class ApplyPendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Farmer",
                keyColumn: "FarmerId",
                keyValue: 1,
                column: "Address",
                value: "Farm 1, Valley Road, Western Cape");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Farmer",
                keyColumn: "FarmerId",
                keyValue: 1,
                column: "Address",
                value: "Western Cape");
        }
    }
}
