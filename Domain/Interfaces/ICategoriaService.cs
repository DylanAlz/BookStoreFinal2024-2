using ApilibrosFinal2024_2.Dal.Entities;

namespace ApilibrosFinal2024_2.Domain.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetCategoriasAsync();
        Task<Categoria> GetCategoriaByIdAsync(Guid id);
        Task<Categoria> CreateCategoriaAsync(Libro libro);
        Task<Categoria> DeleteCategoriaAsync(Guid Id);
        Task<Categoria> EditCategoriaAsync(Libro libro);
    }
}
