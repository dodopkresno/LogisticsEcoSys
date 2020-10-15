using Inventory.Domain.Common;
using Inventory.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Domain.Enums
{
    public class MeasureType : Enumeration
    {
        public static MeasureType Unit = new MeasureType(1, "Default Units");
        public static MeasureType Weight = new MeasureType(2, "Default Weight");
        public static MeasureType WorkingTime = new MeasureType(3, "Working Time");
        public static MeasureType Length = new MeasureType(4, "Default Length / Distance");
        public static MeasureType Volume = new MeasureType(5, "Default Volume");
        public MeasureType(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<MeasureType> List() =>
           new[] { Unit, Weight, WorkingTime, Length, Volume };

        public static MeasureType FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            { 
                throw new MeasureTypeException($"Possible values for MeasureType: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static MeasureType From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new MeasureTypeException($"Possible values for MeasureType: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}
