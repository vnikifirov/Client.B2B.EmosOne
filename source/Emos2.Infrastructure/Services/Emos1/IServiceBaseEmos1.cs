using Emos2.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Services
{
    public interface IServiceBaseEmos1<TEntity> : IServiceBase<TEntity> where TEntity : class, IEntity<int>
    { 

    }
}
