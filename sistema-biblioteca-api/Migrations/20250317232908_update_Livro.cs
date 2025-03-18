using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBibliotecaAPI.Migrations
{
    /// <inheritdoc />
    public partial class update_Livro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivro_Autor_AutorsId",
                table: "AutorLivro");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Livro");

            migrationBuilder.RenameColumn(
                name: "AutorsId",
                table: "AutorLivro",
                newName: "AutoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivro_Autor_AutoresId",
                table: "AutorLivro",
                column: "AutoresId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivro_Autor_AutoresId",
                table: "AutorLivro");

            migrationBuilder.RenameColumn(
                name: "AutoresId",
                table: "AutorLivro",
                newName: "AutorsId");

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Livro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivro_Autor_AutorsId",
                table: "AutorLivro",
                column: "AutorsId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
