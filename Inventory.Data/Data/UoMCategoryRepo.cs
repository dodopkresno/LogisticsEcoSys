using Inventory.Data.Context;
using Inventory.Domain.Enums;
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
    public class UoMCategoryRepo : RepositoryBase<UomCategory>, IUoMCategoryRepo
    {
        public UoMCategoryRepo(InventoryContext inventoryContext)
            : base(inventoryContext)
        {
        }
        public async Task<IEnumerable<UomCategory>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(umc => umc.name).ToListAsync();
        }
        public async Task<UomCategory> GetDataAsync(Guid ucid, bool trackChanges)
        {
            return await FindByCondition(uc => uc.UoMCategoryId.Equals(ucid), trackChanges).SingleOrDefaultAsync();
        }
        public async Task<IEnumerable<UomCategory>> GetDataByType(int id, bool trackChanges)
        {
            var data = await FindByCondition(uc => uc.MeasureType.Id.Equals(id), trackChanges).ToListAsync();
            var item = data.Take(1);

            return item;
        }
        public void AddUomCategory(UomCategory uomCategory) => Create(uomCategory);
        public void UpdateUomCategory(UomCategory uomCategory) => Update(uomCategory);
    }
}
