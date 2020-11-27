using Inventory.Domain.Common;
using Inventory.Exception;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Domain.Enums
{
    public class ContactType : Enumeration
    {
        public static ContactType Contact = new ContactType(1, "Contact");
        public static ContactType AddInvoice = new ContactType(2, "Invoice Address");
        public static ContactType AddDelivery = new ContactType(3, "Delivery Address");
        public static ContactType AddOther = new ContactType(4, "Other Address");
        public static ContactType AddPrivate = new ContactType(5, "Private Address");
        public ContactType(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<ContactType> List() =>
           new[] { Contact, AddInvoice, AddDelivery, AddOther, AddPrivate };

        public static ContactType FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new InventoryException($"Possible values for MeasureType: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static ContactType From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new InventoryException($"Possible values for MeasureType: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}
