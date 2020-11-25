using Inventory.Application.Requests.Uom;
using Inventory.Application.Responses.Uom;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Interface
{
    public interface IUomMapper
    {
        UoM Map(AddUom request);
        UoM Map(EditUom request, UoM existing);
        UomResponse Map(UoM request);
    }
}
