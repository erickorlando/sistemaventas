using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Entities;

namespace SistemaVentas.DataAccess.Configurations;

public class SaleDetailConfiguration : IEntityTypeConfiguration<SaleDetail>
{
    public void Configure(EntityTypeBuilder<SaleDetail> builder)
    {
        builder.Property(p => p.UnitPrice)
            .HasPrecision(11, 2);
        
        builder.Property(p => p.Taxes)
            .HasPrecision(11, 2);
        
        builder.Property(p => p.TotalSale)
            .HasPrecision(11, 2);
        
        builder.Property(p => p.Quantity)
            .HasPrecision(11, 2);
    }
}