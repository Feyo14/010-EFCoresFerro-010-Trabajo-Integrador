using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoresFerro.Datos.Migrations
{
    /// <inheritdoc />
    public partial class agregartalles28a50 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            double t = 28;
            migrationBuilder.Sql(@"INSERT INTO Size 
                    VALUES ('28')");
            for (int i = 0; i <= 43; i++)
            {
                t =t + 0.5;
                migrationBuilder.Sql($@"INSERT INTO Size 
                    VALUES ('{t}')");
            }
          
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
