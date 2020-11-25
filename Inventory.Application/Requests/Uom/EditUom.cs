using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Requests.Uom
{
    public class EditUom
    {
        public Guid UID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double ratio { get; set; }
        public Guid UomCategoryId { get; set; }
        public int Id { get; set; }
        public string updatedBy { get; set; }
    }
}
