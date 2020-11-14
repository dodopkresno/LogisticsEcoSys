using Inventory.Application.Requests.UomCategory;
using Inventory.Application.Responses.UomCategory;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Interface
{
    public interface IUomCategoryMapper
    {
        UomCategory Map(AddUoMCategory request);
        UomCategory Map(EditUomCategory request, UomCategory existing);
        DataResponse Map(UomCategory request);
    }
}
