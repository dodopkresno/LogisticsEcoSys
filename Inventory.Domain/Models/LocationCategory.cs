using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class LocationCategory : BaseEntity
    {
        public Guid locationCtgId { get; set; }
        public string description { get; set; }
    }
}
