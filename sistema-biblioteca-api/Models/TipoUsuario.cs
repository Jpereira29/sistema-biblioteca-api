using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecaAPI.Models;

public partial class TipoUsuario
{
    [Key]
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;
}
