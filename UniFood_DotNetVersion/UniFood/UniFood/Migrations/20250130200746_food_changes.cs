using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniFood.Migrations
{
    /// <inheritdoc />
    public partial class food_changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Foods");
        }
    }
}
