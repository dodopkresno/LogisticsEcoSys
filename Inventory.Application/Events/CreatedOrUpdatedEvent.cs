using Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Events
{
    public class CreatedOrUpdatedEvent : Event
    {
        public Guid id { get; private set; }
        public string roleid { get; private set; }
        public string menuid { get; private set; }
        public bool isnew { get; private set; }
        public bool cancreate { get; private set; }
        public bool canupdate { get; private set; }
        public bool candelete { get; private set; }

        public CreatedOrUpdatedEvent(string id, string roleId, string menuId, bool isNew, bool canCreate, bool canUpdate, bool canDelete)
        {
            this.id = id;
            roleid = roleId;
            menuid = menuId;
            isnew = isNew;
            cancreate = canCreate;
            canupdate = canUpdate;
            candelete = canDelete;
        }
    }
}
