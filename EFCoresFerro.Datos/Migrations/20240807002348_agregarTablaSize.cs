using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoresFerro.Datos.Migrations
{
    /// <inheritdoc />
    public partial class agregarTablaSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Size",
               columns: table => new
               {
                   SizeId = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   SizeNumber = table.Column<decimal>(type: "Decimal(3,1)", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_SizeId", x => x.SizeId);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "Size");
        }
    }
}
