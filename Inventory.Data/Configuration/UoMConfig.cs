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
            builder.HasKey(k => k.UoMId);
            builder.Property(p => p.UoMId);
            builder.Property(p => p.name)
                .IsRequired()
                .HasMaxLength(15);
            builder.HasIndex(s => s.name)
                .IsUnique();
        }
    }
}
