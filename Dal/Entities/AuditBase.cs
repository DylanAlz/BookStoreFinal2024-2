using System.ComponentModel.DataAnnotations;

namespace ApilibrosFinal2024_2.Dal.Entities
{
    public class AuditBase
    {
        [Key] //PK
        [Required] //Campo obligatorio
        public virtual Guid Id { get; set; } // este será Primary key

        public virtual DateTime? CreatedDate { get; set; } //Nuevo registro con su fecha 

        public virtual DateTime? ModifyDate { get; set; } // para guardar fecha de modificación 
    }
}
