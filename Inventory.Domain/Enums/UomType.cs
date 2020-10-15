using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Enums
{
    public class UomType : Enumeration
    {
        //public static UomType Unit = new UomType(1, nameof("Default Units").ToLowerInvariant());
        public static UomType Unit = new UomType(1, "Default Units");
        public static UomType Weight = new UomType(2, "Default Weight");
        public static UomType WorkingTime = new UomType(3, "Working Time");
        public static UomType Length = new UomType(1, "Default Length / Distance");
        public static UomType Volume = new UomType(1, "Default Volume");

        public UomType(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<UomType> List() =>
            new[] { Unit, Weight, WorkingTime, Length, Volume };
    }
}
