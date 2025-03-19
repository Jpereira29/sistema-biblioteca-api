using ACBaseAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaBibliotecaAPI.DTOs;
using SistemaBibliotecaAPI.Models;
namespace SistemaBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController(UnitOfWork context) : ControllerBase
    {
        private readonly IRepository<LivroAutor> _livroAutorRepository = context.Repository<LivroAutor>();
        private readonly IRepository<Livro> _livroRepository = context.Repository<Livro>();
        private readonly UnitOfWork _unitOfWork = context;

        [HttpGet]
        public IActionResult Get()
        {
            var livros = _livroRepository.Get()
                            .Include(x => x.LivroAutores)
                            .ThenInclude(la => la.Autor)
                            .Select(x => new
                            {
                                x.Id,
                                x.Titulo,
                                x.Categoria,
                                x.AnoPublicacao,
                                Autores = x.LivroAutores.Select(la => new
                                {
                                    la.Autor.Id,
                                    la.Autor.Nome
                                })
                            }).ToList();

            return Ok(livros);
        }


        [HttpPost]
        public async Task<IActionResult> Post(LivroDTO entity)
        {
            var livro = new Livro
            {
                Titulo = entity.Titulo,
                Categoria = entity.Categoria,
                AnoPublicacao = entity.AnoPublicacao
            };

            _livroRepository.Add(livro);
            await _livroRepository.SaveChangesAsync();

            foreach (var autor in entity.Autores)
            {
                _livroAutorRepository.Add(new LivroAutor
                {
                    LivroId = livro.Id,
                    AutorId = autor.Id
                });
            }

            await _unitOfWork.SaveChangesAsync();
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(int id, LivroDTO entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }

            _livroRepository.Update(new Livro
            {
                Id = entity.Id,
                Titulo = entity.Titulo,
                Categoria = entity.Categoria,
                AnoPublicacao = entity.AnoPublicacao
            });
            await _livroRepository.SaveChangesAsync();

            var livroAutores = _livroAutorRepository.Get().Where(e => e.LivroId == id).ToList();
            foreach (var livroAutor in livroAutores)
            {
                var autor = entity.Autores.FirstOrDefault(e => e.Id == livroAutor.AutorId);
                if (autor == null)
                {
                    _livroAutorRepository.Delete(livroAutor);
                }
            }

            foreach (var autor in entity.Autores)
            {
                if (!livroAutores.Any(e => e.AutorId == autor.Id))
                {
                    _livroAutorRepository.Add(new LivroAutor
                    {
                        LivroId = id,
                        AutorId = autor.Id
                    });
                }
            }

            await _unitOfWork.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var livro = await _livroRepository.GetByCode((e) => e.Id == id);
            if (livro == null)
            {
                return NotFound();
            }

            _livroRepository.Delete(livro);
            await _livroRepository.SaveChangesAsync();
            return Ok();
        }
    }
}
