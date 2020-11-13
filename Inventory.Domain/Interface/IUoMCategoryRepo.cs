using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Interface
{
    public interface IUoMCategoryRepo
    {
        Task<IEnumerable<UomCategory>> GetAllAsync(bool trackChanges);
        Task<UomCategory> GetDataAsync(Guid id, bool trackChanges);
        Task<UomCategory> GetDataByType(int id, bool trackChanges);
        Task<IEnumerable<UomCategory>> GetDataListByType(int id, bool trackChanges);
        void AddUomCategory(UomCategory uomCategory);
        void UpdateUomCategory(UomCategory uomCategory);
        void DeleteUomCategory(UomCategory uomCategory);
    }
}
