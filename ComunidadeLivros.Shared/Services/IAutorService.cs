using ComunidadeLivros.Shared.Data.Models;

namespace ComunidadeLivros.Shared.Services
{
    public interface IAutorService
    {
        Task<IList<Autor>> GetAllAutor();
        Task<Autor?> GetAutorById(Guid id);
        Task UpdateAutor(Autor autor);
        Task AddAutor(Autor newAutor);
        Task DeleteAutor(Autor autor);
        Task<IList<Autor>> GetAutoresByGeneroId(Guid generoId);
    }
}
