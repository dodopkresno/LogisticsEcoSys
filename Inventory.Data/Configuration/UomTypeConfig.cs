using Inventory.Data.Context;
using Inventory.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Configuration
{
    public class UomTypeConfig : IEntityTypeConfiguration<UomType>
    {
        public void Configure(EntityTypeBuilder<UomType> builder)
        {
            builder.ToTable("UomType", InventoryContext.DEFAULT_SCHEMA);

            builder.HasKey(ut => ut.Id);

            builder.Property(ut => ut.Id)
                .HasDefaultValue(1)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(ut => ut.Name)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
