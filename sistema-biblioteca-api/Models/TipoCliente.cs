using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecaAPI.Models;

public partial class TipoCliente
{
    [Key]
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;
}
