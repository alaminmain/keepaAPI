using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keepaAPI.Migrations
{
    /// <inheritdoc />
    public partial class add_two_field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalesRankOnMainCategory",
                table: "Products",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SalesRankOnMainCategory",
                table: "Products");
        }
    }
}
