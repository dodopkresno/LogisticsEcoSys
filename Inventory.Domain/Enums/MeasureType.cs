using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Inventory.Domain.Enums
{
    public enum MeasureType
    {
        [Description("Default Units")]
        Unit,
        [Description("Default Weight")]
        Weight,
        [Description("Default Working Time")]
        WorkingTime,
        [Description("Default Length")]
        Length,
        [Description("Default Volume")]
        Volume
    }
}
