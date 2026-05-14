using Microsoft.EntityFrameworkCore;
using veterinaria.Models;

namespace veterinaria.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Mascota> Mascotas { get; set; }

        public DbSet<Veterinario> Veterinarios { get; set; }
    }
}
