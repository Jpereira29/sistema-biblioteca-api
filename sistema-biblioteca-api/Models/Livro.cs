using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecaAPI.Models;

public partial class Livro
{
    [Key]
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string AnoPublicacao { get; set; } = null!;

    public virtual ICollection<LivroAutor> LivroAutores { get; set; } = new List<LivroAutor>();
    public virtual ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
}
