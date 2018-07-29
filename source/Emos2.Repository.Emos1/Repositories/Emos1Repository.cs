using Emos2.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Repository.Repositories
{
    public class Emos1Repository<TEntity> : EntitiesRepositoryBase<TEntity> where TEntity : class, IEntity<int>
    {

        public Emos1Repository(IContextEmos1 dbContext) : base(dbContext)
        { }

    }
}
