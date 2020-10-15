using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Category : BaseEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double ratio { get; set; }

        private int _measureType;
        public UomCategory UomCategory { get; set; } //Many2One Comodel --> UoMCategory

        public Category(string name, double ratio = 1.0, )
        {
            this.name = name;
            this.ratio = ratio;
        }
    }
}
