using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroAeronaves.Migrations
{
    /// <inheritdoc />
    public partial class aeronaves : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aeronaves",
                columns: table => new
                {
                    AeronavesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoAeronave = table.Column<string>(type: "TEXT", nullable: false),
                    Identificador = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Aerolinea = table.Column<string>(type: "TEXT", nullable: false),
                    Matricula = table.Column<string>(type: "TEXT", nullable: false),
                    ruta = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronaves", x => x.AeronavesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aeronaves");
        }
    }
}
