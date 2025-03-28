using Microsoft.EntityFrameworkCore;
using L01P022022RS650.Models;
namespace L01P022022RS650.Models
{
    public class db_notasDbContext : DbContext
    {
        public db_notasDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<materias> materias { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<alumnos> alumnos { get; set; }

    }
    
}
