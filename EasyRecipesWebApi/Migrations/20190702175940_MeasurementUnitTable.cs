using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyRecipesWebApi.Migrations
{
    public partial class MeasurementUnitTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Ingredients");

            migrationBuilder.AddColumn<int>(
                name: "MeasurementUnitId",
                table: "Ingredients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MeasurementUnit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Unit = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementUnit", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MeasurementUnitId",
                table: "Ingredients",
                column: "MeasurementUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_MeasurementUnit_MeasurementUnitId",
                table: "Ingredients",
                column: "MeasurementUnitId",
                principalTable: "MeasurementUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_MeasurementUnit_MeasurementUnitId",
                table: "Ingredients");

            migrationBuilder.DropTable(
                name: "MeasurementUnit");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_MeasurementUnitId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "MeasurementUnitId",
                table: "Ingredients");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Ingredients",
                nullable: false,
                defaultValue: "");
        }
    }
}
