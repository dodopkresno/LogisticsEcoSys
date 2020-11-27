using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Country : BaseEntity
    {
        public Guid countryId { get; set; }
        public string initialCode { get; set; }
    }
}
