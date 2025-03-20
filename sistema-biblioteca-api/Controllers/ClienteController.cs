using ACBaseAPI.Controllers.Base;
using ACBaseAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaBibliotecaAPI.Models;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController(UnitOfWork context) : EFControllerBaseController<Cliente>(context)
    {
        public override IActionResult Get()
        {
            var usuarios = _context.Get().Include(x => x.TipoCliente);
            return Ok(usuarios);
        }   
    }
}
