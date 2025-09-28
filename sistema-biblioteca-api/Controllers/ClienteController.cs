using ACBaseAPI.Controllers.Base;
using ACBaseAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaBibliotecaAPI.Models;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController(IUnitOfWork context, IRepository<Cliente> repository) : EFBaseController<Cliente, int>(context, repository)
    {
        public override IActionResult Get()
        {
            var usuarios = _repository.Get().Include(x => x.TipoCliente);
            return Ok(usuarios);
        }
    }
}
