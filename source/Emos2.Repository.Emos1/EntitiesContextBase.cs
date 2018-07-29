using Emos2.Infrastructure.Entities;
using Emos2.Infrastructure.Entities.Database;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Repository
{
    public abstract class EntitiesContextBase : DbContext,  IContextEmos1
    {

        public EntitiesContextBase(string dbNameOrConnectionString) : base(dbNameOrConnectionString)
        { }

        #region Private, protected methods

        private DbEntityEntry GetDbEntityEntrySafely<TEntity>(TEntity entity) where TEntity : class
        {
            DbEntityEntry dbEntityEntry = base.Entry<TEntity>(entity);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                this.Set<TEntity>().Attach(entity);
            }

            return dbEntityEntry;
        }

        #endregion

        #region IEntityContext implementations
               

        public void SetAsAdded<TEntity>(TEntity entity) where TEntity : class
        {
            DbEntityEntry dbEntityEntry = this.GetDbEntityEntrySafely<TEntity>(entity);
            dbEntityEntry.State = EntityState.Added;
        }

        public void SetAsDeleted<TEntity>(TEntity entity) where TEntity : class
        {
            DbEntityEntry dbEntityEntry = this.GetDbEntityEntrySafely<TEntity>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public void SetAsModified<TEntity>(TEntity entity) where TEntity : class
        {
            DbEntityEntry dbEntityEntry = this.GetDbEntityEntrySafely<TEntity>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }

        public void SetAsDetached<TEntity>(TEntity entity) where TEntity : class
        {
            DbEntityEntry dbEntityEntry = this.GetDbEntityEntrySafely<TEntity>(entity);
            dbEntityEntry.State = EntityState.Detached;
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        #endregion

    }
}
