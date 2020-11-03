using Inventory.Application.Requests;
using Inventory.Domain.Enums;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Interface
{
    public interface IUomCategoryService
    {
        Task<IEnumerable<UomCategory>> GetAllAsync();
        Task<UomCategory> SetObjStatus(UpdateStatusUomCategory request);
        Task<UomCategory> AddUomCategory(AddUoMCategory request);
        IEnumerable<MeasureType> GetMeasureType();
    }
}
