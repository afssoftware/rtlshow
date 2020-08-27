using Microsoft.EntityFrameworkCore;
using TVMaze.Models;

namespace TVMaze.DataAccess
{
    public class RTLContext : DbContext
    {
        public RTLContext(DbContextOptions<RTLContext> options)
            : base(options)
        {
        }

        public DbSet<Cast> Casts { get; set; }
        public DbSet<RTLshow> RTLshows { get; set; }
    }
}
