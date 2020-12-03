using Inventory.Data.Context;
using Inventory.Data.Interface;
using Inventory.Domain.Common;
using Inventory.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Data
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity, IAggregateRoot
    {
        protected InventoryContext InventoryContext;

        public RepositoryBase(InventoryContext inventoryContext)
        {
            InventoryContext = inventoryContext;
        }

        public void Create(T entity)
        {
            InventoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            InventoryContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return !trackChanges ? InventoryContext.Set<T>().AsNoTracking() : InventoryContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return !trackChanges ? InventoryContext.Set<T>().Where(expression).AsNoTracking() : InventoryContext.Set<T>().Where(expression);
        }

        public void Update(T entity)
        {
            InventoryContext.Set<T>().Update(entity);
        }
    }
}
