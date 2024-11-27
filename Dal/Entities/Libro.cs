using System.ComponentModel.DataAnnotations;

namespace ApilibrosFinal2024_2.Dal.Entities
{
    public class Libro : AuditBase
    {
        [Display(Name = "Título")] //Para identificar el nombre de la propiedad mas fácil
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")] //Longitud max
        [Required(ErrorMessage = "Es campo {0} obligatorio")] //Campo obligatoria
        public string titulo { get; set; }
        public string autor { get; set; }

        [Display(Name = "Categoría")]
        public ICollection<Categoria>? categorias { get; set; }
    }
}
