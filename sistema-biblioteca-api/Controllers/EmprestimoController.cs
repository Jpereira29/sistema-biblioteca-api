using ACBaseAPI.Controllers.Base;
using ACBaseAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaBibliotecaAPI.Models;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController(UnitOfWork context) : EFBaseController<Emprestimo>(context)
    {
        public override IActionResult Get()
        {
            var emprestimos = _context.Get().Include(x => x.Livro).Include(x => x.Cliente).Select(x => new
            {
                x.Id,
                x.DataEmprestimo,
                x.PrevisaoEntrega,
                Livro = new
                {
                    x.Livro.Id,
                    x.Livro.Titulo
                },
                Cliente = new
                {
                    x.Cliente.Id,
                    x.Cliente.Nome
                }
            }).ToList();

            return Ok(emprestimos);
        }

        public override async Task<IActionResult> Post(Emprestimo entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
