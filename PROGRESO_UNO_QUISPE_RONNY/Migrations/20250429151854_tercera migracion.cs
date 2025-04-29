using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROGRESO_UNO_QUISPE_RONNY.Migrations
{
    /// <inheritdoc />
    public partial class terceramigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPagar",
                table: "Reservacs",
                type: "decimal(28,2)",
                maxLength: 20,
                precision: 28,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<decimal>(
                name: "Saldo",
                table: "Cliente",
                type: "decimal(28,2)",
                precision: 28,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPagar",
                table: "Reservacs",
                type: "decimal(18,2)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,2)",
                oldMaxLength: 20,
                oldPrecision: 28,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Saldo",
                table: "Cliente",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,2)",
                oldPrecision: 28,
                oldScale: 2);
        }
    }
}
