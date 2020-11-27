using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class State : BaseEntity
    {
        public Guid stateId { get; set; }
        public string description { get; set; }
        public Guid countryId { get; set; }
        public Country country { get; set; }
    }
}
