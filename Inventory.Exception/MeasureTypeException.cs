using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Exception
{
    public class MeasureTypeException : ApplicationException //ApplicationException
    {
        public MeasureTypeException()
        { }
        public MeasureTypeException(string message) : base(message)
        {
        }
    }
}
