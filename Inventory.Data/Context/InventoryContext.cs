using Inventory.Data.Configuration;
using Inventory.Domain.Enums;
using Inventory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Context
{
    public class InventoryContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "Inventory";
        public InventoryContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UoMCategeryConfig());
            modelBuilder.ApplyConfiguration(new UoMConfig());
            //modelBuilder.ApplyConfiguration(new MeasureTypeConfig());
            //modelBuilder.ApplyConfiguration(new UomTypeConfig());
        }
        public DbSet<UomCategory> UoMCategories { get; set; }
        public DbSet<UoM> Uoms { get; set; }
        //public DbSet<MeasureType> MeasureTypes { get; set; }
        //public DbSet<UomType> UomTypes { get; set; }
    }
}
