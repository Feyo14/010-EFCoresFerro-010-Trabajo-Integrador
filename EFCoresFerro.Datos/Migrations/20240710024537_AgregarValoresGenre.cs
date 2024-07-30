using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoresFerro.Datos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarValoresGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Genre 
                    VALUES ('Alien')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreName",
                keyValue: "Alien");
        }
    }
}
