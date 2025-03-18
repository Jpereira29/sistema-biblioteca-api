using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecaAPI.Models;

public partial class Autor
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<LivroAutor> LivroAutores { get; set; } = new List<LivroAutor>();
}
