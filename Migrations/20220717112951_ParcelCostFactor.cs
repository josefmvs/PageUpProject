using Microsoft.EntityFrameworkCore.Migrations;

namespace PageUpProject.Migrations
{
    public partial class ParcelCostFactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CostFactor",
                table: "Rules",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Depth",
                table: "Parcels",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Parcels",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostFactor",
                table: "Rules");

            migrationBuilder.DropColumn(
                name: "Depth",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Parcels");
        }
    }
}
