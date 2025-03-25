using ComunidadeLivros.Shared.Data.Models;

namespace ComunidadeLivros.Shared.Services
{
    public interface ILivroService
    {
        Task<IList<Livro>> GetAllLivro();
        Task<Livro?> GetLivroById(Guid id);
        Task UpdateLivro(Livro livro);
        Task AddLivro(Livro newLivro);
        Task DeleteLivro(Livro livro);
        Task<IList<Livro>> GetLivrosByGeneroId(Guid generoId);
        Task<IList<Livro>> GetLivrosFiltered(string searchText);
        Task<(IList<Livro>, int)> GetLivrosFilteredPaged(string searchText, int pageNumber, int pageSize);
    }
}
