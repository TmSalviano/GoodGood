using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodGood.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    UnidadeDeMedida = table.Column<string>(type: "TEXT", nullable: false),
                    CaloriasEmKcal = table.Column<float>(type: "REAL", nullable: false),
                    CarboidratosEmG = table.Column<float>(type: "REAL", nullable: false),
                    ProteinasEmG = table.Column<float>(type: "REAL", nullable: false),
                    GordurasEmG = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    ModeDePreparo = table.Column<string>(type: "TEXT", nullable: false),
                    Categoria1 = table.Column<string>(type: "TEXT", nullable: false),
                    Categoria2 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceitasIngrediente",
                columns: table => new
                {
                    ReceitaId = table.Column<int>(type: "INTEGER", nullable: false),
                    IngredienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitasIngrediente", x => new { x.ReceitaId, x.IngredienteId });
                    table.ForeignKey(
                        name: "FK_ReceitasIngrediente_Ingredientes_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceitasIngrediente_Receitas_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceitasIngrediente_IngredienteId",
                table: "ReceitasIngrediente",
                column: "IngredienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceitasIngrediente");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Receitas");
        }
    }
}
