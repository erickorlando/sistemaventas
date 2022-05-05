using Microsoft.EntityFrameworkCore;
using SistemaVentas.Entidades;

namespace SistemaVentas.AccesoDatos
{
    public class SistemaVentasDbContext : DbContext
    {
        public SistemaVentasDbContext()
        {
            
        }

        public SistemaVentasDbContext(DbContextOptions<SistemaVentasDbContext> options)
        : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=VentasDB;Trusted_Connection=True");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}