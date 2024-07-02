using AutoRepairShop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoRepairShop.Repository.EF.EntityConfigurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(id => id.UUID);
        builder.Property(id => id.UUID).ValueGeneratedOnAdd();

        builder.Property(n => n.Name)
            .HasMaxLength(128);

        builder.Property(s => s.Surname)
            .HasMaxLength(128);

        builder.Property(p => p.Surname)
            .HasMaxLength(128);

        builder.HasOne(e => e.Shift)
            .WithOne()
            .HasForeignKey<Employee>(x => x.ShiftUUID);
    }
}
