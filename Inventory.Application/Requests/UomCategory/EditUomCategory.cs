using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Requests.UomCategory
{
    public class EditUomCategory
    {
        public Guid UCID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int Id { get; set; }
        public string updatedBy { get; set; }
    }
}
