using Inventory.Data.Context;
using Inventory.Data.Interface;
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

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
