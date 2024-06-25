using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeonTetra.Data.Migrations
{
    /// <inheritdoc />
    public partial class BankModelAdded3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankId",
                table: "BankDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BankDetails_BankId",
                table: "BankDetails",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankDetails_Banks_BankId",
                table: "BankDetails",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankDetails_Banks_BankId",
                table: "BankDetails");

            migrationBuilder.DropIndex(
                name: "IX_BankDetails_BankId",
                table: "BankDetails");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "BankDetails");
        }
    }
}
