using WebAPI_UnitTests.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebAPI_UnitTests.Data.EntityConfigurations;

public class CatalogBrandEntityTypeConfiguration
    : IEntityTypeConfiguration<CatalogBrandEntity>
{
    public void Configure(EntityTypeBuilder<CatalogBrandEntity> builder)
    {
        builder.ToTable("CatalogBrand");

        builder.HasKey(ci => ci.Id);

        builder.Property(ci => ci.Id)
            .UseHiLo("catalog_brand_hilo")
            .IsRequired();

        builder.Property(cb => cb.Brand)
            .IsRequired()
            .HasMaxLength(100);
    }
}