using Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Commands
{
    public abstract class Command : Message
    {
        //hanya inherit class ini yang bisa melakukan set
        public DateTime Timestamp { get; protected set; }
        
        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
