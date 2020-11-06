using Inventory.Application.Requests;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Interface
{
    public interface IPermissionService
    {
        Task Add(AddPermission request);
        Task Update(EditPermission request);
    }
}
