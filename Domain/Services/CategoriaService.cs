using ApilibrosFinal2024_2.Dal.Entities;
using ApilibrosFinal2024_2.Domain.Interfaces;

namespace ApilibrosFinal2024_2.Domain.Services
{
    public class CategoriaService : ICategoriaService
    {
        public Task<Categoria> CreateCategoriaAsync(Libro libro)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> DeleteCategoriaAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> EditCategoriaAsync(Libro libro)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> GetCategoriaByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> GetCategoriasAsync()
        {
            throw new NotImplementedException();
        }
    }
}
