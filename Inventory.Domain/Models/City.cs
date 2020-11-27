using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class City : BaseEntity
    {
        public Guid cityId { get; set; }
        public string description { get; set; }
        public Guid stateId { get; set; }
        public State state { get; set; }
    }
}
