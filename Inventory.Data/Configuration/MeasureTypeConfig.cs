using Inventory.Data.Context;
using Inventory.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Configuration
{
    public class MeasureTypeConfig : IEntityTypeConfiguration<MeasureType>
    {
        public void Configure(EntityTypeBuilder<MeasureType> builder)
        {
            builder.ToTable("MeasureType", InventoryContext.DEFAULT_SCHEMA);
           
            //builder.Ignore(b => b.UomType);

            builder.HasKey(mt => mt.Id);

            builder.Property(mt => mt.Id)
                .HasDefaultValue(1)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(mt => mt.Name)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
