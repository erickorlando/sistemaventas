using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVentas.AccesoDatos.Migrations
{
    public partial class InitialDataProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Notes", "RegisterDate", "SkuCode", "Status", "UnitOfMeasureId" },
                values: new object[,]
                {
                    { 1, "Leche Gloria", null, null, "00013", true, 2 },
                    { 2, "Leche Laive", null, null, "00014", true, 2 },
                    { 3, "Barra de Halls Azul", null, null, "45666", true, 1 },
                    { 4, "Barra de Halls Negro", null, null, "35533", true, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
