using Microsoft.EntityFrameworkCore;

namespace Code_First.Models
{
    public class MiDbContext: DbContext
    {
        public MiDbContext(DbContextOptions<MiDbContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Empleado> empleados { get; set; }

    }
}
