using Emos2.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Repositories
{
    public interface IRepositoryEmos1<TEntity, TId> :  IRepository<TEntity, TId> where TEntity : class, IEntity<TId> where TId : IComparable
    {

        IContextEmos1 GetContext();

    }

    /// <summary>
    /// Base Repository interface with generic TEntity with int Id property
    /// </summary>
    /// <typeparam name="TEntity">Entity Type</typeparam>
    public interface IRepositoryEmos1<TEntity> : IRepositoryEmos1<TEntity, int> where TEntity : class, IEntity<int>
    { }

}
