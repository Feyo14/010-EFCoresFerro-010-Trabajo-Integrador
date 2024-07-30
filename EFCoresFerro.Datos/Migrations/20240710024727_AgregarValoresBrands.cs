using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoresFerro.Datos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarValoresBrands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Brands 
                    VALUES ('Vans')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandName",
                keyValue: "Vans");
        }
    }
}
