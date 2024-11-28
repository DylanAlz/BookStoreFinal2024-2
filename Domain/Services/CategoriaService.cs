using ApilibrosFinal2024_2.Dal;
using ApilibrosFinal2024_2.Dal.Entities;
using ApilibrosFinal2024_2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApilibrosFinal2024_2.Domain.Services
{
    public class CategoriaService : ICategoriaService
    {

        private readonly DataBaseContext _context;
        public CategoriaService(DataBaseContext context)
        {
            _context = context;
        }
        public async Task<Categoria> CreateCategoriaAsync(Categoria categoria)
        {
            try
            {
                categoria.CreatedDate = DateTime.Now;
                categoria.Id = Guid.NewGuid();
                _context.Categorias.Add(categoria);
                await _context.SaveChangesAsync();
                return categoria;

            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Categoria> DeleteCategoriaAsync(Guid Id)
        {
            try
            {
                var categoria = await GetCategoriaByIdAsync(Id);
                if (categoria != null)
                {
                    return null;
                }
                _context.Categorias.Remove(categoria);
                await _context.SaveChangesAsync();
                return categoria;
                        
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Categoria> EditCategoriaAsync(Categoria categoria)
        {
            try
            {
                categoria.ModifyDate = DateTime.Now;
                _context.Categorias.Update(categoria);
                await _context.SaveChangesAsync();
                return categoria;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Categoria> GetCategoriaByIdAsync(Guid id)
        {
            try
            {
                var categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.Id == id);
                return categoria;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<IEnumerable<Categoria>> GetCategoriasAsync()
        {
            try
            {
                return await _context.Categorias.ToListAsync();
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }
    }
}
