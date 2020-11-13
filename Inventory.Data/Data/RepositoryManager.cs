using Inventory.Data.Context;
using Inventory.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Data
{
    public class RepositoryManager : IRepositoryManager
    {
        private InventoryContext _inventoryContext;
        private IUoMCategoryRepo _uomCategoryRepo;
        private IUoMRepository _uomRepo;
        private IPermissionRepository _permissionRepo;
        public RepositoryManager(InventoryContext inventoryContext)
        {
            _inventoryContext = inventoryContext;
        }
        public IUoMCategoryRepo UoMCategory
        {
            get
            {
                if (_uomCategoryRepo == null)
                    _uomCategoryRepo = new UoMCategoryRepo(_inventoryContext);

                return _uomCategoryRepo;
            }
        }

        public IUoMRepository Uom
        {
            get
            {
                if (_uomRepo == null)
                    _uomRepo = new UoMRepository(_inventoryContext);

                return _uomRepo;
            }
        }

        public IPermissionRepository Permission
        {
            get 
            {
                if (_permissionRepo == null)
                    _permissionRepo = new PermissionRepository(_inventoryContext);

                return _permissionRepo;
            }
        }

        public async Task SaveAsync()
        {
            await _inventoryContext.SaveChangesAsync();
        }
    }
}
