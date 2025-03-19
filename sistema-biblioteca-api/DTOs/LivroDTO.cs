using SistemaBibliotecaAPI.Models;

namespace SistemaBibliotecaAPI.DTOs
{
    public class LivroDTO
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Categoria { get; set; }

        public string AnoPublicacao { get; set; }
        public List<Autor> Autores { get; set; } = new List<Autor>();
    }
}
