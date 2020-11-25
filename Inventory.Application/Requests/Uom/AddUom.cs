using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Requests.Uom
{
    public class AddUom
    {
        public string name { get; set; }
        public string description { get; set; }
        public double ratio { get; set; }
        public Guid UomCategoryId { get; set; }
        public int Id { get; set; }
        public string createdBy { get; set; }
        public DateTime created { get; private set; }
        public bool isActive { get; private set; }

        protected AddUom()
        {
            isActive = true;
            created = DateTime.Now;
        }
    }
}
