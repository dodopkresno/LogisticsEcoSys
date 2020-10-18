using Inventory.Data.Context;
using Inventory.Domain.Interface;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Data
{
    public class UoMRepository : RepositoryBase<UoM>, IUoMRepository
    {
        public UoMRepository(InventoryContext inventoryContext)
            : base(inventoryContext)
        {
        }
    }
}
