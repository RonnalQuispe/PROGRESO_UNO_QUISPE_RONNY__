using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROGRESO_UNO_QUISPE_RONNY.Migrations
{
    /// <inheritdoc />
    public partial class segundamigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecompensaCliente",
                columns: table => new
                {
                    RecompensaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PuntosAcumulados = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecompensaCliente", x => x.RecompensaId);
                    table.ForeignKey(
                        name: "FK_RecompensaCliente_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservacs",
                columns: table => new
                {
                    ReservaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    ValorPagar = table.Column<decimal>(type: "decimal(18,2)", maxLength: 20, nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservacs", x => x.ReservaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecompensaCliente_ClienteId",
                table: "RecompensaCliente",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecompensaCliente");

            migrationBuilder.DropTable(
                name: "Reservacs");
        }
    }
}
