using AutoRepairShop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoRepairShop.Repository.EF.EntityConfigurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    private const int _baseLength = 128;

    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(id => id.UUID);
        builder.Property(id => id.UUID).ValueGeneratedOnAdd();

        builder.Property(b => b.Brand)
            .HasMaxLength(_baseLength);

        builder.Property(b => b.Model)
            .HasMaxLength(_baseLength);

        builder.Property(b => b.LicensePlate)
            .HasMaxLength(_baseLength);
    }
}
