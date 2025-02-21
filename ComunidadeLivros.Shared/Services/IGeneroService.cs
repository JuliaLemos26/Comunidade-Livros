using ComunidadeLivros.Shared.Data.Models;

namespace ComunidadeLivros.Shared.Services
{
    public interface IGeneroService
    {
        Task<IList<Genero>> GetAllGeneros();
        Task<Genero?> GetGeneroById(Guid id);
        Task UpdateGenero(Genero genero);
        Task AddGenero(Genero newGenero);
        Task DeleteGenero(Genero genero);
    }
}
