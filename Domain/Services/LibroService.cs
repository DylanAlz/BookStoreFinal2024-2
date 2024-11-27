using ApilibrosFinal2024_2.Dal.Entities;
using ApilibrosFinal2024_2.Domain.Interfaces;

namespace ApilibrosFinal2024_2.Domain.Services
{
    public class LibroService : ILibroService
    {
        public Task<Libro> CreateLibroAsync(Libro libro)
        {
            throw new NotImplementedException();
        }

        public Task<Libro> DeleteLibroAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<Libro> EditLibroAsync(Libro libro)
        {
            throw new NotImplementedException();
        }

        public Task<Libro> GetLibroByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Libro>> GetLibrosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
