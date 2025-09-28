using ACBaseAPI.Models;

namespace SistemaBibliotecaAPI.Models;

public partial class Autor : BaseEntity<int>
{
    public string Nome { get; set; } = null!;

    public virtual ICollection<LivroAutor> LivroAutores { get; set; } = new List<LivroAutor>();
}
