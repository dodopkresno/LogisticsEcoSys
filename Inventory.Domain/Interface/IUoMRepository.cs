using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Interface
{
    public interface IUoMRepository
    {
        Task<IEnumerable<UoM>> GetAllAsync(bool trackChanges);
        Task<UoM> GetDataAsync(Guid uid, bool trackChanges);
        Task<UoM> GetDataByType(Guid UomCategoryId, bool trackChanges);
        void AddUom(UoM uom);
        void UpdateUom(UoM uom);

    }
}
