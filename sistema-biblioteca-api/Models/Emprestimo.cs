using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBibliotecaAPI.Models;

public partial class Emprestimo
{
    [Key]
    public int Id { get; set; }

    public DateTime DataEmprestimo { get; set; }

    public DateTime PrevisaoEntrega { get; set; }

    [ForeignKey(nameof(Usuario))]
    public int UsuarioId { get; set; }

    [ForeignKey(nameof(Livro))]
    public int LivroId { get; set; }

    public virtual Livro Livro { get; set; } 

    public virtual Usuario Usuario { get; set; }
}
