using ACBaseAPI.Interfaces;
using ACBaseAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaBibliotecaAPI.Models;
namespace SistemaBibliotecaAPI.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>(options), IAppDbContext
    {
        public DbSet<SystemLog> SystemLog { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Emprestimo> Emprestimo { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<TipoCliente> TipoCliente { get; set; }
        public DbSet<Cliente> Usuario { get; set; }
        public DbSet<LivroAutor> LivroAutor { get; set; }
    }
}
