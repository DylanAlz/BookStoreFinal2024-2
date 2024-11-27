using ApilibrosFinal2024_2.Dal.Entities;

namespace ApilibrosFinal2024_2.Domain.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetCategoriasAsync();
        Task<Categoria> GetCategoriaByIdAsync(Guid id);
        Task<Categoria> CreateCategoriaAsync(Categoria categoria);
        Task<Categoria> DeleteCategoriaAsync(Guid Id);
        Task<Categoria> EditCategoriaAsync(Categoria categoria);
    }
}
