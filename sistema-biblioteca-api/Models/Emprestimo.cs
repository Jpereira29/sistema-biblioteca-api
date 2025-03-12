namespace SistemaBibliotecaAPI.Models;

public partial class Emprestimo
{
    public int EmprestimoId { get; set; }

    public DateTime DataEmprestimo { get; set; }

    public DateTime PrevisaoEntrega { get; set; }

    public int? UsuarioId { get; set; }

    public int? LivroId { get; set; }

    public virtual Livro? Livro { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
