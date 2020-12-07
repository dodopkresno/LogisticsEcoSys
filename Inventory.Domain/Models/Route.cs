using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Route : BaseEntity
    {
        public Guid routeId { get; set; }
        public string description { get; set; }
        public Guid companyId { get; set; }
        public Company company { get; set; }
        public ICollection<Rule> rules { get; set; }
    }
}
