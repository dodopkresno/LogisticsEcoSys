using Inventory.Data.Context;
using Inventory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Configuration
{
    public class UoMConfig : IEntityTypeConfiguration<UoM>
    {
        public void Configure(EntityTypeBuilder<UoM> builder)
        {
            builder.ToTable("Uom", InventoryContext.DEFAULT_SCHEMA);

            builder.HasKey(k => k.UoMId);

            builder.Property(p => p.UoMId);

            builder.Property(p => p.name)
                .IsRequired()
                .HasMaxLength(15);
            builder.HasIndex(s => s.name)
                .IsUnique();

            builder.Property(p => p.description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.UoMCategoryId)
                .IsRequired();

            builder.HasOne(r => r.UomCategory)
                .WithMany()
                .HasForeignKey(r => r.UoMCategoryId);

            builder.Property(p => p.Id)
                .IsRequired();

            builder.Ignore(b => b.UomType);
            builder.Ignore(b => b.Events);
        }
    }
}
