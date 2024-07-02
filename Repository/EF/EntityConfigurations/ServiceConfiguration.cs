using AutoRepairShop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoRepairShop.Repository.EF.EntityConfigurations;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.HasKey(id => id.UUID);
        builder.Property(id => id.UUID).ValueGeneratedOnAdd();

        builder.Property(n => n.Name)
            .HasMaxLength(128);
    }
}
