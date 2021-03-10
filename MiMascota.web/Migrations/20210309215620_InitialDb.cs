using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiMascota.web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<string>(maxLength: 12, nullable: false),
                    PrimerNombre = table.Column<string>(maxLength: 50, nullable: false),
                    SegundoNombre = table.Column<string>(maxLength: 50, nullable: true),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    TelefonoFijo = table.Column<string>(maxLength: 20, nullable: true),
                    TelefonoCelular = table.Column<string>(maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
