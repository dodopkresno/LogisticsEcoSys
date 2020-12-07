using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Partner : BaseEntity
    {
        public Guid partnerId { get; set; }
        public string partnerPathName { get; set; }
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
        public Guid parentPartnertId { get; set; } //individu (company type individual) have parent company type = company
        public Partner partner { get; set; }
        public int Id { get; set; }
        public ContactType contactType { get; set; } //address type
        public int IdCompanyType { get; set; } //company or individual
        public CompanyType companyType { get; set; }
        public ICollection<CompanyTag> companyTagIds { get; set; }
    }
}
