using System.ComponentModel.DataAnnotations.Schema;

namespace MiPrimerCRUD.Models
{
    [Table("Asignaturas")]
    public class Asignatura
    {
        public long Id { get; set; }
        public string Nombre { get; set; }

        //Relacionar con otra tabla
        public long? CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
