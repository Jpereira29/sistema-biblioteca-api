using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecaAPI.Models
{
    public class LivroAutor
    {
        [Key]
        public int Id { get; set; }

        public int LivroId { get; set; }
        public int AutorId { get; set; }

        public virtual Autor Autor { get; set; }
        public virtual Livro Livro { get; set; }
    }
}
