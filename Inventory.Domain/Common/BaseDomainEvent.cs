﻿using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Inventory.Domain.Common
{
    public abstract class BaseDomainEvent : INotification
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}
