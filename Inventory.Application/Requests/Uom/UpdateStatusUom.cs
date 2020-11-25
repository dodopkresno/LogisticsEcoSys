using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Requests.Uom
{
    public class UpdateStatusUom
    {
        public Guid uid { get; set; }
        public string userBy { get; set; }
        public bool isActive { get; set; }
    }
}
