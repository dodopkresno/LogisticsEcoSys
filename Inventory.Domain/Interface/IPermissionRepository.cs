using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Interface
{
    public interface IPermissionRepository
    {
        void AddPermission(Permission permission);
        void EditPermission(Permission permission);
    }
}
