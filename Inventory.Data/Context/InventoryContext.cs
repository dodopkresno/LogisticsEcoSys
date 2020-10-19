using Inventory.Data.Configuration;
using Inventory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Context
{
    public class InventoryContext : DbContext
    {
        //public const string DEFAULT_SCHEMA = "inventory";
        public InventoryContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UoMCategeryConfig());
            modelBuilder.ApplyConfiguration(new UoMConfig());
        }
        public DbSet<UomCategory> UoMCategories { get; set; }
        public DbSet<UoM> Uoms { get; set; }
    }
}
