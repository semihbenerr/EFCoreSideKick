using EFCoreSideKick.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EFCoreSideKick.Api
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Category)
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .HasPrecision(10, 0);

            builder
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsUnicode(true);

            builder
                .Property(x => x.Price)
                .HasColumnName("Price")
                .HasPrecision(18, 2);

            builder
                .Property(x => x.Stock)
                .HasColumnName("Stock")
                .HasPrecision(10, 0);

            builder
                .Property(x => x.Status)
                .HasColumnName("Status");

            builder
                .ToTable("Product", "dbo");
        }
    }
}
