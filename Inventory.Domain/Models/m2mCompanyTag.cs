using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class m2mCompanyTag : BaseEntity
    {
        public Guid m2mCTId { get; set; }
        public Guid partnerId { get; set; }
        public Guid CompanyTagId { get; set; }
    }
}
