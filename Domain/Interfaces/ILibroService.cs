using ApilibrosFinal2024_2.Dal.Entities;
using System.Diagnostics.Metrics;

namespace ApilibrosFinal2024_2.Domain.Interfaces
{
    public interface ILibroService
    {
        Task<IEnumerable<Libro>> GetLibrosAsync();
        Task<Libro> GetLibroByIdAsync(Guid id);
        Task<Libro> CreateLibroAsync(Libro libro);
        Task<Libro> DeleteLibroAsync(Guid Id);
        Task<Libro> EditLibroAsync(Libro libro);
    }
}
