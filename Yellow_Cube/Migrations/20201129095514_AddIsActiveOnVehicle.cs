using Microsoft.EntityFrameworkCore.Migrations;

namespace Yellow_Cube.Migrations
{
    public partial class AddIsActiveOnVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "VehicleCategories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RatePerKM",
                table: "VehicleCategories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RatePerMinute",
                table: "VehicleCategories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "VehicleCategories");

            migrationBuilder.DropColumn(
                name: "RatePerKM",
                table: "VehicleCategories");

            migrationBuilder.DropColumn(
                name: "RatePerMinute",
                table: "VehicleCategories");
        }
    }
}
