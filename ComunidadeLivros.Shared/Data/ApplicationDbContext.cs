using ComunidadeLivros.Shared.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ComunidadeLivros.Shared.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Livro> Livros => Set<Livro>();
        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Autor> Autores => Set<Autor>();
        public DbSet<Midia> Midias => Set<Midia>();
    }
}
