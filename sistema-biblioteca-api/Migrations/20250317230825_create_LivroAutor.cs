using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBibliotecaAPI.Migrations
{
    /// <inheritdoc />
    public partial class create_LivroAutor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro");

            migrationBuilder.DropIndex(
                name: "IX_Livro_AutorId",
                table: "Livro");

            migrationBuilder.CreateTable(
                name: "AutorLivro",
                columns: table => new
                {
                    AutorsId = table.Column<int>(type: "int", nullable: false),
                    LivrosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorLivro", x => new { x.AutorsId, x.LivrosId });
                    table.ForeignKey(
                        name: "FK_AutorLivro_Autor_AutorsId",
                        column: x => x.AutorsId,
                        principalTable: "Autor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLivro_Livro_LivrosId",
                        column: x => x.LivrosId,
                        principalTable: "Livro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorLivro_LivrosId",
                table: "AutorLivro",
                column: "LivrosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLivro");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_AutorId",
                table: "Livro",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
