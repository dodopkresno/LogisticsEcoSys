using Inventory.Application.Responses.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Interface
{
    public interface IUomTypeMapper
    {
        IEnumerable<UomTypeResponse> mapList();
        UomTypeResponse mapSingle(int Id);
    }
}
