using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoresFerro.Datos.Migrations
{
    /// <inheritdoc />
    public partial class agregarTablaShoeSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "ShoeSizes",
              columns: table => new
              {
                  ShoeSizeId = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  ShoeId = table.Column<int>(type: "int", nullable: false),
                  SizeId = table.Column<int>(type: "int", nullable: false),
                  QuantityInStock = table.Column<int>(type: "int", nullable: false),
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_ShoeSize", x => x.ShoeSizeId);
                  table.ForeignKey(
                      name: "FK_ShoeSize_ShoeId",
                      column: x => x.ShoeId,
                      principalTable: "Shoes",
                      principalColumn: "ShoeId",
                      onDelete: ReferentialAction.Cascade);
                  table.ForeignKey(
                      name: "FK_ShoeSize_Size_SizeId",
                      column: x => x.SizeId,
                      principalTable: "Size",
                      principalColumn: "SizeId",
                      onDelete: ReferentialAction.Cascade);
                
              });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "ShoeSize");
        }
    }
}
