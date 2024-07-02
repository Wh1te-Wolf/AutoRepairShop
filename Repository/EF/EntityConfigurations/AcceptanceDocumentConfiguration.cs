using AutoRepairShop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoRepairShop.Repository.EF.EntityConfigurations;

public class AcceptanceDocumentConfiguration : IEntityTypeConfiguration<AcceptanceDocument>
{
    public void Configure(EntityTypeBuilder<AcceptanceDocument> builder)
    {
        builder.HasKey(id => id.UUID);
        builder.Property(id => id.UUID).ValueGeneratedOnAdd();

        builder.HasOne(x => x.Car)
            .WithOne()
            .HasForeignKey<AcceptanceDocument>(ad => ad.CarUUID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.Customer)
            .WithOne()
            .HasForeignKey<AcceptanceDocument>(ad => ad.CustomerUUID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(com => com.Comment)
            .HasMaxLength(128);

        builder.HasMany(doc => doc.DocumentLines)
            .WithOne(dl => dl.AcceptanceDocument)
            .HasForeignKey(dl => dl.AcceptanceDocumentUUID);
    }
}
