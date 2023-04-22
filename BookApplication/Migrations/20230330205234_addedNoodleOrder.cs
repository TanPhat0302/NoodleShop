using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookApplication.Migrations
{
    /// <inheritdoc />
    public partial class addedNoodleOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BastPrice",
                table: "PhoOrders",
                newName: "BasePrice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BasePrice",
                table: "PhoOrders",
                newName: "BastPrice");
        }
    }
}
