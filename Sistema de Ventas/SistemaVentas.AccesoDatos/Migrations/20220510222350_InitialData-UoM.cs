using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVentas.AccesoDatos.Migrations
{
    public partial class InitialDataUoM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UnitOfMeasures",
                columns: new[] { "Id", "Code", "Description", "Status" },
                values: new object[,]
                {
                    { 1, "UND", "Unidad", true },
                    { 2, "LAT", "Lata", true },
                    { 3, "BOL", "Bolsa", true },
                    { 4, "CAJ", "Caja", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UnitOfMeasures",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
