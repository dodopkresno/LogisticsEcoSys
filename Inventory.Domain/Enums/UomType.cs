using Inventory.Domain.Common;
using Inventory.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Domain.Enums
{
    public class UomType : Enumeration
    {
        //public static UomType Unit = new UomType(1, nameof("Default Units").ToLowerInvariant());
        public static UomType Reference = new UomType(1, "Reference Unit of Measure for this category");
        public static UomType Bigger = new UomType(2, "Bigger than the reference Unit of Measure");
        public static UomType Smaller = new UomType(3, "Smaller than the reference Unit of Measure");
        public static UomType Convert = new UomType(4, "Convert Weight from Weight to Units (vice versa)");
        
        public UomType(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<UomType> List() =>
            new[] { Reference, Bigger, Smaller, Convert };

        public static UomType FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new UoMTypeException($"Possible values for UoMType: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static UomType From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new UoMTypeException($"Possible values for UoMType: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}
