using Emos2.Infrastructure;
using Emos2.Infrastructure.Entities;
using Emos2.Infrastructure.Enums;
using Emos2.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Repository
{
    public abstract class EntitiesRepositoryBase<TEntity, TId> : IRepositoryESR<TEntity, TId>
        where TEntity : class, IEntity<TId>
        where TId : IComparable
    {
        protected readonly IContextESR dbContext;

        public IContextESR GetContext()
        {
            return dbContext;
        }

        public EntitiesRepositoryBase(IContextESR dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException("dbContext");
            }

            this.dbContext = dbContext;
        }

        public void SetContextConnectionString(string dbConnectionString)
        {
            dbContext.SetConnectionString(dbConnectionString);
        }


            #region Private, protected methods

            private IQueryable<TEntity> Filter<TProperty>(IQueryable<TEntity> dbSet, Expression<Func<TEntity, TProperty>> property, TProperty value) where TProperty : IComparable
        {
            MemberExpression memberExpression = property.Body as MemberExpression;
            if (memberExpression == null || !(memberExpression.Member is PropertyInfo))
            {
                throw new ArgumentException("Property expected", "property");
            }

            Expression left = property.Body;
            Expression right = Expression.Constant(value, typeof(TProperty));
            Expression searchExpression = Expression.Equal(left, right);
            Expression<Func<TEntity, bool>> lambda = Expression.Lambda<Func<TEntity, bool>>(searchExpression, new ParameterExpression[] { property.Parameters.Single() });

            return dbSet.Where(lambda);
        }

        private PaginationList<TEntity> Paginate<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, bool>> predicate, OrderByType orderByType)
        {
            IQueryable<TEntity> entities = orderByType == OrderByType.Ascending ? this.SelectAll().OrderBy(keySelector) : this.SelectAll().OrderByDescending(keySelector);
            entities = predicate != null ? entities.Where(predicate) : entities;

            return entities.ToPaginatedList(pageIndex, pageSize);
        }

        #endregion

        #region IRepository<TEntity, TId> implementations

        public TEntity Create()
        {
            return this.dbContext.Set<TEntity>().Create();
        }

        public void Delete(TEntity entity)
        {
            this.dbContext.SetAsDeleted(entity);
        }

        public void Delete(TId id)
        {
            IQueryable<TEntity> entities = this.SelectAll();
            TEntity entity = this.Filter<TId>(entities, e => e.ID, id).Single();

            this.dbContext.SetAsDeleted(entity);
        }

        public void Insert(TEntity entity)
        {
            this.dbContext.SetAsAdded(entity);
        }

        public int SaveChanges()
        {
            return this.dbContext.SaveChanges();
        }

        public TEntity Select(TId id)
        {
            IQueryable<TEntity> entities = this.SelectAll();

            return this.Filter<TId>(entities, e => e.ID, id).FirstOrDefault();
        }

        public IQueryable<TEntity> SelectAll()
        {
            return this.dbContext.Set<TEntity>();
        }

        public PaginationList<TEntity> SelectAllPaginated<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector)
        {
            return this.Paginate<TKey>(pageIndex, pageSize, keySelector, null, OrderByType.Ascending);
        }

        public PaginationList<TEntity> SelectAllPaginatedDescending<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector)
        {
            return this.Paginate<TKey>(pageIndex, pageSize, keySelector, null, OrderByType.Descending);
        }

        public IQueryable<TEntity> SelectBy(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> entitiesBy = this.SelectAll().Where(predicate);

            return entitiesBy;
        }

        public PaginationList<TEntity> SelectByPaginated<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, bool>> predicate)
        {
            return this.Paginate<TKey>(pageIndex, pageSize, keySelector, predicate, OrderByType.Ascending);
        }

        public PaginationList<TEntity> SelectByPaginatedDescending<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, bool>> predicate)
        {
            return this.Paginate<TKey>(pageIndex, pageSize, keySelector, predicate, OrderByType.Ascending);
        }

        public void Update(TEntity entity)
        {
            TEntity oldEntity = this.Select(entity.ID);
            this.dbContext.SetAsDetached(oldEntity);

            this.dbContext.SetAsModified(entity);
        }

        public bool Exists(TEntity entity)
        {
            TEntity tEntity = this.Select(entity.ID);

            return tEntity != null;
        }

        public bool Exists(TId id)
        {
            TEntity tEntity = this.Select(id);

            return tEntity != null;
        }

        #endregion
    }

    public abstract class EntitiesRepositoryBase<TEntity> : EntitiesRepositoryBase<TEntity, int>, IRepositoryESR<TEntity>
        where TEntity : class, IEntity<int>
    {
        
        public EntitiesRepositoryBase(IContextESR dbContext) : base(dbContext)
        { }

    }
}
