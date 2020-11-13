using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Inventory.Domain.Models
{
    public class UoM : BaseEntity
    {
        public Guid UoMId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double ratio { get; set; }
        public Guid UoMCategoryId { get; set; }
        public UomCategory UomCategory { get; set; }
        public int Id { get; set; }
        public UomType UomType { get; set; }
    }
}
