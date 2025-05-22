using EjemploAPI01.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemploAPI01.Data
{
    public class SampleDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SampleDbContext(DbContextOptions<SampleDbContext> options)
            : base(options)
        {
            
        }
    }
}
