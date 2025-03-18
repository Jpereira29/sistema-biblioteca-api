using Microsoft.AspNetCore.Mvc;
using ACBaseAPI.Controllers.Base;
using SistemaBibliotecaAPI.Models;
using ACBaseAPI.Repositories;
using Microsoft.EntityFrameworkCore;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController(UnitOfWork context) : EFControllerBaseController<Livro>(context)
    {
        public override IActionResult Get()
        {
            var livros = _context.Get().Include(x => x.LivroAutores);
            return Ok(livros);
        }

        public override async Task<IActionResult> Post(Livro entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            foreach (var autor in entity.LivroAutores)
            {
                _unitOfWork.Repository<LivroAutor>().Add(new LivroAutor
                {
                    LivroId = entity.Id,
                    AutorId = autor.Id
                });
            }

            await _unitOfWork.SaveChangesAsync();
            return Ok(entity);
        }
    }
}
