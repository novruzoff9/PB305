using CarManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarManagement.Data.Configurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Name).IsRequired().HasMaxLength(100);
        builder.Property(b => b.Country).IsRequired().HasMaxLength(100);
        builder.Property(b => b.CreatedAt).IsRequired();
        builder.HasMany(b => b.Models).WithOne(m => m.Brand).HasForeignKey(m => m.BrandId);
    }
}
