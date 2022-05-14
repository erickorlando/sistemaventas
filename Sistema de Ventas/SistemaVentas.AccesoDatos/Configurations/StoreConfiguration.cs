using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Entities;

namespace SistemaVentas.DataAccess.Configurations;

public class StoreConfiguration : IEntityTypeConfiguration<Store>
{
    public void Configure(EntityTypeBuilder<Store> builder)
    {
        builder.Property(p => p.Code)
            .HasMaxLength(10)
            .IsUnicode(false);

        builder.Property(p => p.Name)
            .HasMaxLength(100);

        builder.Property(p => p.FullAddress)
            .HasMaxLength(250);

        builder.HasIndex(p => p.Code);

        builder.HasData(new List<Store>()
        {
            new Store()
            {
                Id = 1,
                CompanyId = 1,
                Code = "0001",
                Name = "Tienda Principal",
                FullAddress = "Av. Siempre viva 123",
            },
            new Store()
            {
                Id = 2,
                CompanyId = 1,
                Code = "0002",
                Name = "Tienda mas pequeña",
                FullAddress = "Jr. Las Palomas 456"
            }
        });
    }
}