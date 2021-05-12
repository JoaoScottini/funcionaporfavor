using Microsoft.EntityFrameworkCore;
using funcionaporfavor.Data.Entities;

namespace funcionaporfavor.Data
{
    public class HobbyDbContext : DbContext
    {
        public HobbyDbContext(DbContextOptions<HobbyDbContext> options)
      : base(options) { }
        public DbSet<Hobby> Hobbies { get; set; }

    }
}
