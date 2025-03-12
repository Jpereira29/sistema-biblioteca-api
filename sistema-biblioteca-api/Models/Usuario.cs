namespace SistemaBibliotecaAPI.Models;

public partial class Usuario 
{
    public int UsuarioId { get; set; }

    public string Nome { get; set; } = null!;

    public string Telefone1 { get; set; } = null!;

    public string? Telefone2 { get; set; }

    public string Email { get; set; } = null!;

    public int TipoUsuarioId { get; set; }

    public virtual ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();

    public virtual TipoUsuario? TipoUsuario { get; set; }
}
