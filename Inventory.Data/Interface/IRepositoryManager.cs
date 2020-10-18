using Inventory.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Interface
{
    public interface IRepositoryManager
    {
        IUoMCategoryRepo UoMCategory { get; }
        Task SaveAsync();
    }
}
