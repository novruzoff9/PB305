﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pb305OnionArc.Persistance.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Title)
               .IsRequired()
               .HasMaxLength(200);
        builder.Property(b => b.Status)
               .IsRequired();
        builder.Property(b => b.AuthorId)
               .IsRequired();
        builder.HasOne(b => b.Author)
               .WithMany(a => a.Books)
               .HasForeignKey(b => b.AuthorId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
