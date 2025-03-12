using ACBaseAPI.Controllers.Base;
using ACBaseAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using SistemaBibliotecaAPI.Models;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController(UnitOfWork context) : EFControllerBaseController<Emprestimo>(context)
    {
    }
}
