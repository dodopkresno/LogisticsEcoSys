using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Requests
{
    public class EditPermission
    {
        public Guid Id { get; set; }
        public string RoleId { get; set; }
        public string MenuId { get; set; }
        public bool canCreate { get; set; }
        public bool canUpdate { get; set; }
        public bool canDelete { get; set; }
    }
}
