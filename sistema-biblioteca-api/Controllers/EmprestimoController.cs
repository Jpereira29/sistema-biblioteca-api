using ACBaseAPI.Controllers.Base;
using ACBaseAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaBibliotecaAPI.Models;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController(IUnitOfWork context, IRepository<Emprestimo> repository) : EFBaseController<Emprestimo, int>(context, repository)
    {
        public override IActionResult Get()
        {
            var emprestimos = _repository.Get().Include(x => x.Livro).Include(x => x.Cliente).Select(x => new
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
            _repository.Add(entity);
            await _repository.SaveChangesAsync();
            return Ok();
        }
    }
}
