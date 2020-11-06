using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Interface
{
    public interface IRepositoryManager
    {
        IUoMCategoryRepo UoMCategory { get; }
        IUoMRepository Uom { get;  }
        IPermissionRepository Permission { get; }
        Task SaveAsync();
    }
}
