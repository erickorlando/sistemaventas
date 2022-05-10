using System.Reflection;
using Microsoft.EntityFrameworkCore;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new CustomerConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        // Esto ya no es necesario
        //public DbSet<Customer> Customers { get; set; }
    }
}