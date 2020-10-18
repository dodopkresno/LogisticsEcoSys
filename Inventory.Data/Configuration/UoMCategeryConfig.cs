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
            builder.HasKey(k => k.UoMCategoryId);
            builder.Property(p => p.UoMCategoryId);
            builder.Property(p => p.name)
                .IsRequired()
                .HasMaxLength(15);
        }
    }
}
