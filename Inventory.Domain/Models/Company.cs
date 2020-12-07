using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Company : BaseEntity
    {
        public Guid companyId { get; set; }
        public string companyPathName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string website { get; set; }
        public string addStreet1 { get; set; }
        public string addStreet2 { get; set; }
        public Guid cityId { get; set; }
        public City city { get; set; }
        public string postalCode { get; set; }
        public string internalNote { get; set; }
        public Guid parentCompanyId { get; set; }
        public Company company { get; set; }
        public Guid partnerId { get; set; }
        public Partner partner { get; set; }
    }
}
