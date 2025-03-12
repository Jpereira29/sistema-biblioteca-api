namespace SistemaBibliotecaAPI.Models;

public partial class Livro
{
    public int LivroId { get; set; }

    public string Titulo { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string AnoPublicacao { get; set; } = null!;

    public int? AutorId { get; set; }

    public virtual Autor? Autor { get; set; }

    public virtual ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
}
