using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Company : BaseEntity
    {
        public Guid CompanyId { get; set; }
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
        public int Id { get; set; }
        public CompanyType companyType { get; set; }
        public ICollection<Contact> contactIds { get; set; }
        public ICollection<CompanyTag> companyTagIds { get; set; }
    }
}
