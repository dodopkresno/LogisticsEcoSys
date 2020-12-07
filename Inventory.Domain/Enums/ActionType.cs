using Inventory.Domain.Common;
using Inventory.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Domain.Enums
{
    public class ActionType : Enumeration
    {
        public static ActionType Pull = new ActionType(1, "Pull");
        public static ActionType Push = new ActionType(2, "Push");

        public ActionType(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<ActionType> List() =>
           new[] { Pull, Push };

        public static ActionType FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new InventoryException($"Possible values for MeasureType: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static ActionType From(int id)
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
