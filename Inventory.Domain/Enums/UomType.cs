using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Inventory.Domain.Enums
{
    public enum UomType
    {
        [Description("Bigger than the reference Unit of Measure")]
        Bigger,
        [Description("Reference Unit of Measure for this category")]
        Reference,
        [Description("Smaller than the reference Unit of Measure")]
        Smaller,
        [Description("Convert over Unit of Measure Category")]
        Convert
    }
}
