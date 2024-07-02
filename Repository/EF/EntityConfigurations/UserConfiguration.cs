using AutoRepairShop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoRepairShop.Repository.EF.EntityConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    private const int _baseLength = 256;

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(id => id.UUID);
        builder.Property(id => id.UUID).ValueGeneratedOnAdd();

        builder.Property(b => b.Login)
            .HasMaxLength(_baseLength);

        builder.Property(b => b.PasswordHash)
            .HasMaxLength(_baseLength);

        builder.Property(b => b.Role)
            .HasMaxLength(_baseLength);
    }
}
