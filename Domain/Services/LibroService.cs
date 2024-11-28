using ApilibrosFinal2024_2.Dal;
using ApilibrosFinal2024_2.Dal.Entities;
using ApilibrosFinal2024_2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApilibrosFinal2024_2.Domain.Services
{
    public class LibroService : ILibroService
    {
        private readonly DataBaseContext _context;
        public LibroService(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<Libro> CreateLibroAsync(Libro libro)
        {
            try
            {
                libro.Id = Guid.NewGuid();
                libro.CreatedDate = DateTime.Now;
                _context.Libros.Add(libro);
                await _context.SaveChangesAsync();
                return libro;

            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Libro> DeleteLibroAsync(Guid Id)
        {
            try
            {
                var libro = await GetLibroByIdAsync(Id);
                if (libro == null)
                {
                    return null;
                }
                _context.Libros.Remove(libro);
                await _context.SaveChangesAsync();
                return libro;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Libro> EditLibroAsync(Libro libro)
        {
            try
            {
                libro.ModifyDate = DateTime.Now;
                _context.Libros.Update(libro);
                await _context.SaveChangesAsync();
                return libro;
            }
            catch (DbUpdateException dbUpdateException)
            {

                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<Libro> GetLibroByIdAsync(Guid id)
        {
            try
            {
                var libro = await _context.Libros.Include(o => o.categorias).FirstOrDefaultAsync(x => x.Id == id);
                return libro;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<IEnumerable<Libro>> GetLibrosAsync()
        {
            try
            {
                return await _context.Libros.Include(o => o.categorias).ToListAsync();
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }
    }
}
