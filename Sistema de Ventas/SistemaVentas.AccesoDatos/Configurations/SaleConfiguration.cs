using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Entities;

namespace SistemaVentas.DataAccess.Configurations;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.Property(p => p.InvoiceNumber)
            .HasMaxLength(20)
            .IsUnicode(false);

        builder.Property(p => p.TotalSale)
            .HasPrecision(11, 2);
        
        builder.Property(p => p.Taxes)
            .HasPrecision(11, 2);
        
        builder.Property(p => p.GrandTotal)
            .HasPrecision(11, 2);

        builder.HasIndex(p => p.InvoiceNumber);

        builder.ToTable("Sales");
    }
}