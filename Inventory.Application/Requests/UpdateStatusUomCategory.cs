using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Inventory.Application.Requests
{
    public class UpdateStatusUomCategory
    {
        public Guid ucid { get; set; }
        public string userBy { get; set; }
        public bool isActive { get; set; }
    }
}
