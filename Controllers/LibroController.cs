using ApilibrosFinal2024_2.Dal.Entities;
using ApilibrosFinal2024_2.Domain.Interfaces;
using ApilibrosFinal2024_2.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace ApilibrosFinal2024_2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibroController : Controller
    {
        private readonly ILibroService _libroService;
        public LibroController(ILibroService libroService)
        {
            _libroService = libroService;
        }
        [HttpGet, ActionName("Get")]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Libro>>> GetLibrosAsync()
        {
            var libros= await _libroService.GetLibrosAsync();
            if (libros == null || !libros.Any()) return NotFound();
            return Ok(libros);  
        }
        [HttpGet, ActionName("Get")]
        [Route("GetById/{Id}")]
        public async Task<ActionResult<Libro>> GetLibroByIdAsync(Guid Id)
        {
            var libro=await _libroService.GetLibroByIdAsync(Id);
            if (libro==null) return NotFound();
            return Ok(libro);
        }
        [HttpPost, ActionName("Create")]
        [Route("Create")]
        public async Task<ActionResult<Libro>> CreateLibroAsync(Libro libro)
        {
            try
            {
                var nuevolibro=await _libroService.CreateLibroAsync(libro);
                if (nuevolibro==null) return NotFound();
                return Ok(nuevolibro);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("duplicate")) return Conflict(String.Format("{0} ya existe", libro.titulo));

                return Conflict(ex.Message);
            }
        }

        [HttpPut, ActionName("Edit")]
        [Route("Edit")]
        public async Task<ActionResult<Libro>> EditLibroAsync(Libro libro)
        {
            try
            {
                var libroEditado = await _libroService.EditLibroAsync(libro);
                if (libroEditado == null) return NotFound();
                return Ok(libroEditado);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("duplicate")) return Conflict(String.Format("{0} ya existe", libro.titulo));

                return Conflict(ex.Message);
            }
        }
        [HttpDelete, ActionName("Delete")]
        [Route("Delete")]
        public async Task<ActionResult<Libro>> DeleteLibroAsync(Guid id)
        {
            if (id==null) return BadRequest();
            var libro= await _libroService.DeleteLibroAsync(id);
            if (libro == null) return NotFound();
            return Ok(libro);
        }
    }
}
