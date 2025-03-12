using Microsoft.AspNetCore.Mvc;
using ACBaseAPI.Controllers.Base;
using SistemaBibliotecaAPI.Models;
using ACBaseAPI.Repositories;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController(UnitOfWork context) : EFControllerBaseController<Livro>(context)
    {
    }
}
