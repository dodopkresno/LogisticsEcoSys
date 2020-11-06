using Inventory.Data.Context;
using Inventory.Domain.Interface;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Data
{
    public class PermissionRepository : RepositoryBase<Permission>, IPermissionRepository
    {
        public PermissionRepository(InventoryContext inventoryContext)
            : base(inventoryContext)
        {
        }
        public void AddPermission(Permission permission) => Create(permission);
        public void EditPermission(Permission permission) => Update(permission);
    }
}
