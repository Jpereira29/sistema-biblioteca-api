using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBibliotecaAPI.Migrations
{
    /// <inheritdoc />
    public partial class update_pks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Livro_LivroId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Usuario_UsuarioId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Usuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TipoUsuarioId",
                table: "TipoUsuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LivroId",
                table: "Livro",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmprestimoId",
                table: "Emprestimo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "Autor",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "Livro",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Emprestimo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LivroId",
                table: "Emprestimo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Livro_LivroId",
                table: "Emprestimo",
                column: "LivroId",
                principalTable: "Livro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Usuario_UsuarioId",
                table: "Emprestimo",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Livro_LivroId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Usuario_UsuarioId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuario",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TipoUsuario",
                newName: "TipoUsuarioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Livro",
                newName: "LivroId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Emprestimo",
                newName: "EmprestimoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Autor",
                newName: "AutorId");

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "Livro",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Emprestimo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LivroId",
                table: "Emprestimo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Livro_LivroId",
                table: "Emprestimo",
                column: "LivroId",
                principalTable: "Livro",
                principalColumn: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Usuario_UsuarioId",
                table: "Emprestimo",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "AutorId");
        }
    }
}
