using ACBaseAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecaAPI.Models;

public partial class Livro : BaseEntity<int>
{
    [Required]
    public string Titulo { get; set; }

    [Required]
    public string Categoria { get; set; }

    [Required]
    public string AnoPublicacao { get; set; }

    public virtual ICollection<LivroAutor> LivroAutores { get; set; } = new List<LivroAutor>();
    public virtual ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
}
