using Emos2.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Entities
{
    public interface IContextEmos1 
    {

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        void SetAsAdded<TEntity>(TEntity entity) where TEntity : class;
        void SetAsModified<TEntity>(TEntity entity) where TEntity : class;
        void SetAsDeleted<TEntity>(TEntity entity) where TEntity : class;
        void SetAsDetached<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
        
    }
}
