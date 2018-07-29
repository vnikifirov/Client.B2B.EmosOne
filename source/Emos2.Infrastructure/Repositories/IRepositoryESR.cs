using Emos2.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Repositories
{
    public interface IRepositoryESR<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class, IEntity<TId> where TId : IComparable
    {
        IContextESR GetContext();
        void SetContextConnectionString(string connectionString);
    }


    /// <summary>
    /// Base Repository interface with generic TEntity with int Id property
    /// </summary>
    /// <typeparam name="TEntity">Entity Type</typeparam>
    public interface IRepositoryESR<TEntity> : IRepositoryESR<TEntity, int> where TEntity : class, IEntity<int>
    { }

}
