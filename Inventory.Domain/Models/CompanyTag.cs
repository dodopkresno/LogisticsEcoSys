using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class CompanyTag : BaseEntity
    {
        public Guid companyTagId { get; set; }
    }
}
