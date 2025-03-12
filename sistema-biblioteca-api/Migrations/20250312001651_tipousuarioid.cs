using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBibliotecaAPI.Migrations
{
    /// <inheritdoc />
    public partial class tipousuarioid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_TipoUsuario_TipoUsuarioNavigationTipoUsuarioId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "TipoUsuario",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "TipoUsuarioNavigationTipoUsuarioId",
                table: "Usuario",
                newName: "TipoUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_TipoUsuarioNavigationTipoUsuarioId",
                table: "Usuario",
                newName: "IX_Usuario_TipoUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_TipoUsuario_TipoUsuarioId",
                table: "Usuario",
                column: "TipoUsuarioId",
                principalTable: "TipoUsuario",
                principalColumn: "TipoUsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_TipoUsuario_TipoUsuarioId",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "TipoUsuarioId",
                table: "Usuario",
                newName: "TipoUsuarioNavigationTipoUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_TipoUsuarioId",
                table: "Usuario",
                newName: "IX_Usuario_TipoUsuarioNavigationTipoUsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "TipoUsuario",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_TipoUsuario_TipoUsuarioNavigationTipoUsuarioId",
                table: "Usuario",
                column: "TipoUsuarioNavigationTipoUsuarioId",
                principalTable: "TipoUsuario",
                principalColumn: "TipoUsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
