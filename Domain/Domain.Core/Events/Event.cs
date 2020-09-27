using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }
        public string InitialName { get; protected set; }

        protected Event(string initialName)
        {
            Timestamp = DateTime.Now;
            InitialName = initialName;
        }
    }
}
