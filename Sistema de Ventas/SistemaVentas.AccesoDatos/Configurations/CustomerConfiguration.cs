using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Entities;

namespace SistemaVentas.DataAccess.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
       // Fluent API

       builder.Property(x => x.FullName)
           .HasMaxLength(100);

       builder.Property(x => x.DocumentNumber)
           .HasMaxLength(20);
       
       builder.Property(x => x.Email)
           .HasMaxLength(500)
           .IsUnicode(false);

       builder.ToTable("Customers");

       builder.HasQueryFilter(p => p.Status);
    }
}