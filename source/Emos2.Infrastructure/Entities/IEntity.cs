using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Entities
{
    /// <summary>
    /// Base Entity interface with generic Id property
    /// </summary>
    /// <typeparam name="TId">Type of the Entity's Id property</typeparam>
    public interface IEntity<TId> where TId : IComparable
    {
        TId ID { get; }
    }

    /// <summary>
    /// Base Entity interface with integer Id property
    /// </summary>
    public interface IEntity : IEntity<int>
    { }
}
