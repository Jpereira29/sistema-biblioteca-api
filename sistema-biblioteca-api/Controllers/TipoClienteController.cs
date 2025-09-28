using ACBaseAPI.Controllers.Base;
using ACBaseAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using SistemaBibliotecaAPI.Models;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoClienteController(IUnitOfWork context, IRepository<TipoCliente> repository) : EFBaseController<TipoCliente, int>(context, repository)
    {
    }
}
