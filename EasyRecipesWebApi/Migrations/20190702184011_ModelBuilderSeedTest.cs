using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyRecipesWebApi.Migrations
{
    public partial class ModelBuilderSeedTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MeasurementUnit",
                columns: new[] { "Id", "Unit" },
                values: new object[,]
                {
                    { 1, "Gram" },
                    { 2, "Millilitre" },
                    { 3, "Piece" },
                    { 4, "Spoon" },
                    { 5, "Tablespoon" },
                    { 6, "Pinch" },
                    { 7, "Glass" },
                    { 8, "None" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MeasurementUnit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MeasurementUnit",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MeasurementUnit",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MeasurementUnit",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MeasurementUnit",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MeasurementUnit",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MeasurementUnit",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MeasurementUnit",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
