using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Contact : BaseEntity
    {
        public Guid contactId { get; set; }
        public string title { get; set; }
        public string jobPosition { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string addStreet1 { get; set; }
        public string addStreet2 { get; set; }
        public Guid cityId { get; set; }
        public City city { get; set; }
        public string postalCode { get; set; }
        public string internalNote { get; set; }
        public int Id { get; set; }
        public ContactType contactType { get; set; }
        public Guid companyId { get; set; }
        public Company company { get; set; }

    }
}
