namespace SistemaBibliotecaAPI.Models;

public partial class Autor
{
    public int AutorId { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Livro> Livros { get; set; } = new List<Livro>();
}
