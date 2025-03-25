using ComunidadeLivros.Shared.Data;
using ComunidadeLivros.Shared.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ComunidadeLivros.Shared.Services
{
    public class LivroService : ILivroService
    {
        private readonly ApplicationDbContext _context;

        public LivroService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Livro>> GetAllLivro()
        {
            return await _context.Livros
                .Include(x => x.Autor)
                .Include(x => x.Genero)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<Livro?> GetLivroById(Guid id)
        {
            return await _context.Livros.FirstOrDefaultAsync(X => X.Id == id);
        }

        public async Task UpdateLivro(Livro livro)
        {
            _context.Update(livro);
            await _context.SaveChangesAsync();
        }

        public async Task AddLivro(Livro livro)
        {
            _context.Add(livro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLivro(Livro livro)
        {
            _context.Remove(livro);
            await _context.SaveChangesAsync();
        }

        public async Task AddLivroAsync(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Livro>> GetLivrosByGeneroId(Guid generoId)
        {
            return await _context.Livros.Where(x => x.Genero != null && x.Genero.Id == generoId).ToListAsync();
        }

        public async Task<IList<Livro>> GetLivrosFiltered(string searchText)
        {
            return await _context.Livros
                .Where(x => x.Name.Contains(searchText) || (x.Autor != null && x.Autor.Nome.Contains(searchText)))
                .Include(x => x.Autor)
                .Include(x => x.Genero)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        //public async Task<IList<Livro>> GetLivrosPaged(int pageNumber, int pageSize)
        //{
        //return await _context.Livros
        //.OrderBy(x => x.Name)
        //.Skip((pageNumber - 1) * pageSize) 
        //.Take(pageSize) 
        //.ToListAsync();
        //}

        //public async Task<int> GetTotalLivrosCount()
        //{
        //return await _context.Livros.CountAsync();
        //}

        public async Task<(IList<Livro>, int)> GetLivrosFilteredPaged(string searchText, int pageNumber, int pageSize)
        {
            var query = _context.Livros
                .Where(x => x.Name.Contains(searchText) || (x.Autor != null && x.Autor.Nome.Contains(searchText)))
                .OrderBy(x => x.Name);

            int totalLivros = await query.CountAsync(); 
            var livros = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            return (livros, totalLivros);
        }
    }
}
