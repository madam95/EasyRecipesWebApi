using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyRecipesWebApi.Migrations
{
    public partial class IngerdientModelWithMeasurementUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Amount",
                table: "Ingredients",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Ingredients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Ingredients",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Ingredients");
        }
    }
}
