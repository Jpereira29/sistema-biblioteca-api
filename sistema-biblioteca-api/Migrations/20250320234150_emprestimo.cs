using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBibliotecaAPI.Migrations
{
    /// <inheritdoc />
    public partial class emprestimo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Usuario_UsuarioId",
                table: "Emprestimo");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Emprestimo",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Emprestimo_UsuarioId",
                table: "Emprestimo",
                newName: "IX_Emprestimo_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Usuario_ClienteId",
                table: "Emprestimo",
                column: "ClienteId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Usuario_ClienteId",
                table: "Emprestimo");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Emprestimo",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Emprestimo_ClienteId",
                table: "Emprestimo",
                newName: "IX_Emprestimo_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Usuario_UsuarioId",
                table: "Emprestimo",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
