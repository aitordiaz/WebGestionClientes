using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebGestionClientes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dni = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    PaisRes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FehcaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CuentaTwitter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.UniqueConstraint("UC_Cliente_DNI", x => x.Dni);
                    table.UniqueConstraint("UC_Cliente_Email", x => x.Email);
                    table.UniqueConstraint("UC_Cliente_Tfno", x => x.Telefono);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
