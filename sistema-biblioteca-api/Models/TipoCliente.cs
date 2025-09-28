using ACBaseAPI.Models;

namespace SistemaBibliotecaAPI.Models;

public partial class TipoCliente : BaseEntity<int>
{
    public string Tipo { get; set; } = null!;
}
