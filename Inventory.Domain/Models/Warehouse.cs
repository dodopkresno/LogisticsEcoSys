using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Warehouse : BaseEntity
    {
        public Guid warehouseId { get; set; }
        public string description { get; set; }
        public Guid companyId { get; set; }
        public Company company { get; set; }
        public Guid whCompanyId { get; set; }
        public Company address { get; set; }
        public Guid contactId { get; set; }
        public Contact personInCharge { get; set; }
    }
}
