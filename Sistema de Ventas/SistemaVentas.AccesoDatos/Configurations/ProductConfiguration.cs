using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Entidades;

namespace SistemaVentas.AccesoDatos.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Name)
            .HasMaxLength(200);

        builder.Property(p => p.SkuCode)
            .HasMaxLength(20)
            .IsUnicode(false);

        builder.Property(p => p.RegisterDate)
            .HasColumnType("DATE");
            //.HasDefaultValueSql("getdate()");
        
        builder.Property(p => p.Notes)
            .HasMaxLength(200);

        // Esto solo si la relacion no cumple la convencion
        //builder.HasOne(p => p.UnitOfMeasure)
        //    .WithMany()
        //    .HasForeignKey(p => p.UnitOfMeasureId)
        //    .OnDelete(DeleteBehavior.Restrict);

        builder.ToTable("Products");

        builder.HasData(new List<Product>
        {
            new Product { Id = 1, Name = "Leche Gloria", SkuCode = "00013", UnitOfMeasureId = 2},
            new Product { Id = 2, Name = "Leche Laive", SkuCode = "00014", UnitOfMeasureId = 2},
            new Product { Id = 3, Name = "Barra de Halls Azul", SkuCode = "45666", UnitOfMeasureId = 1},
            new Product { Id = 4, Name = "Barra de Halls Negro", SkuCode = "35533", UnitOfMeasureId = 1}
        });
    }
}