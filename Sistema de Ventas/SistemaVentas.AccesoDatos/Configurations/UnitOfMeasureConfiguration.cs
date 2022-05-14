using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Entities;

namespace SistemaVentas.DataAccess.Configurations;

public class UnitOfMeasureConfiguration : IEntityTypeConfiguration<UnitOfMeasure>
{
    public void Configure(EntityTypeBuilder<UnitOfMeasure> builder)
    {
        builder.Property(p => p.Code)
            .HasMaxLength(10)
            .IsUnicode(false);
        
        builder.Property(p => p.Description)
            .HasMaxLength(100);

        builder.ToTable("UnitOfMeasures");

        builder.HasData(new List<UnitOfMeasure>
        {
            new UnitOfMeasure { Id = 1, Code = "UND", Description = "Unidad" },
            new UnitOfMeasure { Id = 2, Code = "LAT", Description = "Lata" },
            new UnitOfMeasure { Id = 3, Code = "BOL", Description = "Bolsa" },
            new UnitOfMeasure { Id = 4, Code = "CAJ", Description = "Caja" },
        });
    }
}