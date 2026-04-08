using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trans.Migrations
{
    /// <inheritdoc />
    public partial class AddPersonaContraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDepto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadEmpleados = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Jornada = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CantMaterias = table.Column<int>(type: "int", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                    table.CheckConstraint("CK_Carrera_CantMaterias", "CantMaterias <= 20");
                    table.ForeignKey(
                        name: "FK_Carreras_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Apellio = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Salario = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    deptoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Departamentos_deptoId",
                        column: x => x.deptoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_DepartamentoId",
                table: "Carreras",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_deptoId",
                table: "Personas",
                column: "deptoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
