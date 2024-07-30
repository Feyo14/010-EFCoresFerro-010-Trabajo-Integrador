using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoresFerro.Datos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarValoresSports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Sports 
                    VALUES ('Fiesta')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Fiesta");
        }
    }
}
