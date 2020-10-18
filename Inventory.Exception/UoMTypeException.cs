using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Exception
{
    public class UoMTypeException : ApplicationException
    {
        public UoMTypeException()
        { }
        public UoMTypeException(string message) : base(message)
        {
        }
    }
}
