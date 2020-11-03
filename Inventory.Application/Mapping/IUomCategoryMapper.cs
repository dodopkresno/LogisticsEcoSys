using Inventory.Application.Requests;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Mapping
{
    public interface IUomCategoryMapper
    {
        UomCategory Map(AddUoMCategory request);
        UomCategory Map(EditUomCategory request);
    }
}
