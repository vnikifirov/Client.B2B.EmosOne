using Emos2.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Repositories
{
    /// <summary>
    /// Base Repository interface with generic TEntity with generic Id property
    /// </summary>
    /// <typeparam name="TEntity">Entity Type</typeparam>
    /// <typeparam name="TId">Type of the Entity's Id property</typeparam>
    public interface IRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
        where TId : IComparable
    {
        TEntity Create();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(TId id);
        bool Exists(TEntity entity);
        bool Exists(TId id);
        TEntity Select(TId id);
        IQueryable<TEntity> SelectAll();
        IQueryable<TEntity> SelectBy(Expression<Func<TEntity, bool>> predicate);
        PaginationList<TEntity> SelectAllPaginated<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector);
        PaginationList<TEntity> SelectAllPaginatedDescending<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector);
        PaginationList<TEntity> SelectByPaginated<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, bool>> predicate);
        PaginationList<TEntity> SelectByPaginatedDescending<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
       // IEntitiesContext GetContext();
    }

    /// <summary>
    /// Base Repository interface with generic TEntity with int Id property
    /// </summary>
    /// <typeparam name="TEntity">Entity Type</typeparam>
    //public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    //{ }
}
