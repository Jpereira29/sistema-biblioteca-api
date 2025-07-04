﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBibliotecaAPI.Models;

public partial class Cliente
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Telefone1 { get; set; } = null!;

    public string Telefone2 { get; set; }

    public string Email { get; set; } = null!;

    [ForeignKey(nameof(TipoCliente))]
    public int TipoClienteId { get; set; }

    public virtual ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();

    public virtual TipoCliente TipoCliente { get; set; }
}
