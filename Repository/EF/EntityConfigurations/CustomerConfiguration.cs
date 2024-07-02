using AutoRepairShop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoRepairShop.Repository.EF.EntityConfigurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(id => id.UUID);
        builder.Property(id => id.UUID).ValueGeneratedOnAdd();

        builder.Property(n => n.Name)
            .HasMaxLength(128);

        builder.Property(s => s.Surname)
            .HasMaxLength(128);

        builder.HasMany(cust => cust.Cars)
            .WithOne(car => car.Customer)
            .HasForeignKey(car => car.CustomerUUID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(pn => pn.PhoneNumber)
            .HasMaxLength(128);
    }
}
