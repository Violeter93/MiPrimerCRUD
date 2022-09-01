using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiPrimerCRUD.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        public long Id { get; set; }
        public string? Nombre { get; set; }
        public string? Lugar { get; set; }
        [Display(Name ="Fecha de Inicio")]
        public DateTime? FechaInicio { get; set; }
        public bool Activo { get; set; }
        // Relacionar con otra tabla
        public virtual ICollection<Asignatura>? Asignaturas { get; set; }
        public virtual ICollection<Alumno>? Alumnos { get; set; }
    }
}
