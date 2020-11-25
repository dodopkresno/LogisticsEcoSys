using Inventory.Application.Requests.Uom;
using Inventory.Application.Responses.Uom;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Interface
{
    public interface IUomService
    {
        Task<UomResponse> AddUomAsync(AddUom request);
        Task<UomResponse> EditUomAsync(EditUom request);
        Task<IEnumerable<UomResponse>> GetAllAsync();
        Task<UomResponse> GetDataAsync(UomGetData request);
        Task<UomResponse> DeleteAsync(UpdateStatusUom request);
        IEnumerable<UomType> GetUomType();
    }
}
