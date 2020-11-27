using Inventory.Domain.Common;
using Inventory.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Domain.Enums
{
    public class CompanyType : Enumeration
    {
        public static CompanyType Individu = new CompanyType(1, "Individual");
        public static CompanyType Company = new CompanyType(2, "Company");
        public CompanyType(int id, string name) : base(id, name)
        { 
        }

        public static IEnumerable<CompanyType> List() =>
           new[] { Individu, Company };

        public static CompanyType FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new InventoryException($"Possible values for MeasureType: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static CompanyType From(int id)
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
