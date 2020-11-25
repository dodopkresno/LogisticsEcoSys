using Inventory.Data.Context;
using Inventory.Domain.Interface;
using Inventory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Data
{
    public class UoMRepository : RepositoryBase<UoM>, IUoMRepository
    {
        public UoMRepository(InventoryContext inventoryContext)
            : base(inventoryContext)
        {
        }
        public async Task<IEnumerable<UoM>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(umc => umc.name)
                .ToListAsync();
        }
        public async Task<UoM> GetDataAsync(Guid uid, bool trackChanges)
        {
            return await FindByCondition(u => u.UoMId.Equals(uid), trackChanges).SingleOrDefaultAsync();
        }
        public async Task<UoM> GetDataByType(Guid uomCategoryId, bool trackChanges)
        {
            var data = await FindByCondition(u => u.UoMCategoryId.Equals(uomCategoryId) && u.Id.Equals(1), trackChanges)
                .Include(uc => uc.UomCategory)
                .FirstOrDefaultAsync();
            return data;
        }
       
        public void AddUom(UoM uom) => Create(uom);
        public void UpdateUom(UoM uom) => Update(uom);
    }
}
