using ACBaseAPI.Models;

namespace SistemaBibliotecaAPI.Models
{
    public class LivroAutor : BaseEntity<int>
    {
        public int LivroId { get; set; }
        public int AutorId { get; set; }

        public virtual Autor Autor { get; set; }
        public virtual Livro Livro { get; set; }
    }
}
