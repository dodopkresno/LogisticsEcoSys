using Inventory.Application.Requests;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Mapping
{
    public interface IPermissionMapper
    {
        Permission Map(AddPermission request);
        Permission Map(EditPermission request);
    }
}
