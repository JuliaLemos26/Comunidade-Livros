using ComunidadeLivros.Shared.Data;
using ComunidadeLivros.Shared.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ComunidadeLivros.Shared.Services
{
    public class GeneroService : IGeneroService
    {
        private readonly ApplicationDbContext _context;

        public GeneroService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Genero>> GetAllGeneros()
        {
            return await _context.Generos.ToListAsync();
        }

        public async Task<Genero?> GetGeneroById(Guid id)
        {
            return await _context.Generos.FirstOrDefaultAsync(X => X.Id == id);
        }

        public async Task UpdateGenero(Genero genero)
        {
            _context.Update(genero);
            await _context.SaveChangesAsync();
        }
    }
}
