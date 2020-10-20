using Inventory.Data.Context;
using Inventory.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Data
{
    public class RepositoryManager : IRepositoryManager
    {
        private InventoryContext _inventoryContext;
        private IUoMCategoryRepo _uomCategoryRepo;
        private IUoMRepository _uomRepo;
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

        public async Task SaveAsync()
        {
            await _inventoryContext.SaveChangesAsync();
        }
    }
}
