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
        public string createdBy { get; set; }
        public DateTime created { get; private set; }
        
        public bool isActive { get; private set; }

        protected AddUoMCategory()
        {
            isActive = true;
            created = DateTime.Now;
        }
    }
}
