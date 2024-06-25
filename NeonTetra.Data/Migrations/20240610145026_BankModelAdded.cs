using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonTetra.Data.Migrations
{
    /// <inheritdoc />
    public partial class BankModelAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Access Bank" },
                    { 2, "Citibank" },
                    { 3, "Diamond Bank" },
                    { 4, "Ecobank" },
                    { 5, "Fidelity Bank" },
                    { 6, "First Bank of Nigeria" },
                    { 7, "First City Monument Bank" },
                    { 8, "Guaranty Trust Bank" },
                    { 9, "Heritage Bank" },
                    { 10, "Keystone Bank" },
                    { 11, "Polaris Bank" },
                    { 12, "Providus Bank" },
                    { 13, "Stanbic IBTC Bank" },
                    { 14, "Standard Chartered Bank" },
                    { 15, "Sterling Bank" },
                    { 16, "Suntrust Bank" },
                    { 17, "Union Bank" },
                    { 18, "United Bank for Africa" },
                    { 19, "Unity Bank" },
                    { 20, "Wema Bank" },
                    { 21, "Zenith Bank" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banks");
        }
    }
}
