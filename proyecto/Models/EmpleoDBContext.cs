using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace proyecto.Models
{
    public class EmpleoDBContext : DbContext
    {
        public EmpleoDBContext(DbContextOptions options) : base(options) 
        { 

        }
        public DbSet<trabajo> trabajo { get; set; }
        public DbSet<recursos> recursos { get; set; }
    }
}
