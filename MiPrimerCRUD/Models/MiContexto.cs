using CapaInfraestructura.Entitys;
using Microsoft.EntityFrameworkCore;

namespace MiPrimerCRUD.Models
{
    public class MiContexto : DbContext
    {
        public MiContexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Centro> Centros { get; set; }

    }
}
