using ComunidadeLivros.Shared.Data.Models;

namespace ComunidadeLivros.Shared.Services
{
    public interface IMidiaService
    {
        Task<IList<Midia>> GetAllMidia();
        Task<Midia?> GetMidiaById(Guid id);
        Task UpdateMidia(Midia midia);
        Task AddMidia(Midia newMidia);
        Task DeleteMidia(Midia midia);
    }
}
