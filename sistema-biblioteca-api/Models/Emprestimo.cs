using ACBaseAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBibliotecaAPI.Models;

public partial class Emprestimo : BaseEntity<int>
{
    public DateTime DataEmprestimo { get; set; }

    public DateTime PrevisaoEntrega { get; set; }

    [ForeignKey(nameof(Cliente))]
    public int ClienteId { get; set; }

    [ForeignKey(nameof(Livro))]
    public int LivroId { get; set; }

    public virtual Livro Livro { get; set; }

    public virtual Cliente Cliente { get; set; }
}
