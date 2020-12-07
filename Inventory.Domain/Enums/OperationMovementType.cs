using Inventory.Domain.Common;
using Inventory.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Domain.Enums
{
    public class OperationMovementType : Enumeration
    {
        public static OperationMovementType Putaway = new OperationMovementType(1, "Putaway");
        public static OperationMovementType Picking = new OperationMovementType(2, "Picking");
        public static OperationMovementType ReplenishPF = new OperationMovementType(3, "Pick Face Replenishment");

        public OperationMovementType(int id, string name) : base(id, name)
        {
        }
        public static IEnumerable<OperationMovementType> List() =>
           new[] { Putaway, Picking, ReplenishPF };

        public static OperationMovementType FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new InventoryException($"Possible values for MeasureType: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static OperationMovementType From(int id)
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
