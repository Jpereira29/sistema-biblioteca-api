using SistemaBibliotecaAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace SistemaBibliotecaAPI.DTOs
{
    public class LivroDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do livro é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A categoria do livro é obrigatória.")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "O ano de publicação do livro é obrigatório.")]
        public string AnoPublicacao { get; set; }
        public List<Autor> Autores { get; set; } = new List<Autor>();
    }
}
