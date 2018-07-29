using Emos2.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Services
{
    public interface IServiceBase<TEntity> where TEntity : class, IEntity<int>
    {
        void Save(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entity);
        bool Exists(int id);
        TEntity Select(int id);
        IQueryable<TEntity> SelectAll();
        IQueryable<TEntity> SelectAllBy(Expression<Func<TEntity, bool>> predicate);
        PaginationList<TEntity> SelectAllPagination<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector);
        PaginationList<TEntity> SelectAllByPagination<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, bool>> predicate);
               
    }
}
