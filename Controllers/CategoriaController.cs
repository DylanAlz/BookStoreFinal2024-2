using ApilibrosFinal2024_2.Dal.Entities;
using ApilibrosFinal2024_2.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApilibrosFinal2024_2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }
        [HttpGet, ActionName("Get")]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategoriaAsync()
        {
            var categorias = await _categoriaService.GetCategoriasAsync();
            if (categorias == null || !categorias.Any()) return NotFound();
            return Ok(categorias);
        }
        [HttpGet, ActionName("Get")]
        [Route("GetById/{Id}")]
        public async Task<ActionResult<Categoria>> GetCategoriaByIdAsync(Guid Id)
        {
            var categoria = await _categoriaService.GetCategoriaByIdAsync(Id);
            if (categoria == null) return NotFound();
            return Ok(categoria);
        }
        [HttpPost, ActionName("Create")]
        [Route("Create")]
        public async Task<ActionResult<Libro>> CreateCategoriaAsync(Categoria categoria)
        {
            try
            {
                var nuevaCategoria = await _categoriaService.CreateCategoriaAsync(categoria);
                if (nuevaCategoria == null) return NotFound();
                return Ok(nuevaCategoria);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("duplicate")) return Conflict(String.Format("{0} ya existe", categoria.Nombre_cat));

                return Conflict(ex.Message);
            }
        }

        [HttpPut, ActionName("Edit")]
        [Route("Edit")]
        public async Task<ActionResult<Libro>> EditLibroAsync(Categoria categoria)
        {
            try
            {
                var categoriaEditada = await _categoriaService.EditCategoriaAsync(categoria);
                if (categoriaEditada == null) return NotFound();
                return Ok(categoriaEditada);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("duplicate")) return Conflict(String.Format("{0} ya existe", categoria.Nombre_cat));

                return Conflict(ex.Message);
            }
        }
        [HttpDelete, ActionName("Delete")]
        [Route("Delete")]
        public async Task<ActionResult<Libro>> DeleteLibroAsync(Guid id)
        {
            if (id == null) return BadRequest();
            var categoria = await _categoriaService.DeleteCategoriaAsync(id);
            if (categoria == null) return NotFound();
            return Ok(categoria);
        }
    }
}
