using Inventory.Domain.Common;
using Inventory.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Domain.Enums
{
    public class LocationType : Enumeration
    {
        public static LocationType Vendor = new LocationType(1, "Vendor Location");
        public static LocationType Customer = new LocationType(2, "Customer Location");
        public static LocationType Loss = new LocationType(3, "Inventory Loss Location");
        public static LocationType Internal = new LocationType(4, "Internal Location");
        public static LocationType Production = new LocationType(5, "Production Location");
        public static LocationType Transit = new LocationType(6, "Transit Location");

        public LocationType(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<LocationType> List() =>
           new[] { Vendor, Customer, Loss, Internal, Production, Transit };

        public static LocationType FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new InventoryException($"Possible values for MeasureType: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static LocationType From(int id)
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
