using Colegio.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Colegio.Infra
{
    public class ColegioContext: DbContext
    {
        public ColegioContext(DbContextOptions<ColegioContext> options): base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Grado> Grado { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
    }
}