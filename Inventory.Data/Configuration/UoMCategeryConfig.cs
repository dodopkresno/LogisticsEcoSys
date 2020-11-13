using Inventory.Data.Context;
using Inventory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Configuration
{
    public class UoMCategeryConfig : IEntityTypeConfiguration<UomCategory>
    {
        public void Configure(EntityTypeBuilder<UomCategory> builder) 
        {
            builder.ToTable("UomCategories", InventoryContext.DEFAULT_SCHEMA);

            builder.HasKey(k => k.UoMCategoryId);

            builder.Property(p => p.UoMCategoryId);

            builder.Property(p => p.name)
                .IsRequired()
                .HasMaxLength(15);

            builder.HasIndex(s => s.name)
                .IsUnique();

            builder.Property(p => p.description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Id)
                .IsRequired();

            builder.Ignore(b => b.MeasureType);
            //builder.HasOne(r => r.MeasureType)
            //    .WithMany()
            //    .HasForeignKey(r => r.Id);
        }
    }
}
