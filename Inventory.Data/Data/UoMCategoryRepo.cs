using Inventory.Data.Context;
using Inventory.Domain.Interface;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Data
{
    public class UoMCategoryRepo : RepositoryBase<UomCategory>, IUoMCategoryRepo
    {
        public UoMCategoryRepo(InventoryContext inventoryContext)
            : base(inventoryContext)
        {
        }
    }
}
