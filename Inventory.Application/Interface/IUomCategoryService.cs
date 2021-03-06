﻿using Inventory.Application.Requests.UomCategory;
using Inventory.Application.Responses.UomCategory;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Interface
{
    public interface IUomCategoryService
    {
        Task<IEnumerable<DataResponse>> GetAllAsync();
        Task<DataResponse> GetDataAsync(GetDataRequest request);
        Task<IEnumerable<DataResponse>> GetDataListByTypeAsync(GetDataByType request);
        Task<DataResponse> SetObjStatusAsync(UpdateStatusUomCategory request);
        Task<DataResponse> AddUomCategoryAsync(AddUoMCategory request);
        Task<DataResponse> EditUomCategoryAsync(EditUomCategory request);
        IEnumerable<MeasureType> GetMeasureType();
        Task DeleteUomCategoryAsync(DeleteUomCategory request);
    }
}
