using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trans.Migrations
{
    /// <inheritdoc />
    public partial class FixApellido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apellio",
                table: "Personas",
                newName: "Apellido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Personas",
                newName: "Apellio");
        }
    }
}
