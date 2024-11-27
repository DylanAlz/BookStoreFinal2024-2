using System.ComponentModel.DataAnnotations;

namespace ApilibrosFinal2024_2.Dal.Entities
{
    public class Categoria : AuditBase
    {
        [Display(Name = "Categoría")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")] //Longitud max
        [Required(ErrorMessage = "Es campo {0} obligatorio")] //Campo obligatorio
        public int Nombre_cat { get; set; }
        public int descripcion { get; set; }

        //Relacion de las tablas Libro y Categoria

        [Display(Name = "Libro")]
        public Libro? Libro { get; set; }

        public Guid LibroId { get; set; } //FK
    }
}
