using Inventory.Application.Requests;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Interface
{
    public interface IPermissionMapper
    {
        Permission Map(AddPermission request);
        Permission Map(EditPermission request);
    }
}
