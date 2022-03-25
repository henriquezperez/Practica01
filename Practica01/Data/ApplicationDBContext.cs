using Microsoft.EntityFrameworkCore;
using Practica01.Models;

namespace Practica01.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }

        public DbSet<Estudiante> estudiante { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
