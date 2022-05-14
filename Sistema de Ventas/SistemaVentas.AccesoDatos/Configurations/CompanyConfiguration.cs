using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Entities;

namespace SistemaVentas.DataAccess.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.Property(p => p.Name)
            .HasMaxLength(150);

        builder.Property(p => p.IdentificationNumber)
            .HasMaxLength(20)
            .IsUnicode(false);

        builder.HasIndex(p => p.IdentificationNumber);

        builder.HasData(new Company
        {
            Id = 1,
            Name = "Bodegas el Percheron",
            IdentificationNumber = "20549201527"
        });

        builder.ToTable("Companies");
    }
}