using Microsoft.EntityFrameworkCore;
using L01P022022RS650.Models;
namespace L01P022022RS650.Models
{
    public class db_notasDbContext : DbContext
    {
        public db_notasDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<L01P022022RS650.Models.facultades> facultades { get; set; } = default!;

    }
    
}
