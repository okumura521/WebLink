using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLink.Migrations
{
    /// <inheritdoc />
    public partial class AddIsPurchasedColumnFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isPurchased",
                table: "Item",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isPurchased",
                table: "Item");
        }
    }
}
