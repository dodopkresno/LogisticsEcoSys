using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Requests.UomCategory
{
    public class AddUoMCategory
    {
        public string name { get; set; }
        public string description { get; set; }
        public int Id { get; set; }
        public string updatedBy { get; set; }
    }
}
