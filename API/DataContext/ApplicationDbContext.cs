using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
