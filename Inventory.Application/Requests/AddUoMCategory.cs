using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Requests
{
    public class AddUoMCategory
    {
        public string name { get; set; }
        public string description { get; set; }
        public int Id { get; set; }
    }
}
