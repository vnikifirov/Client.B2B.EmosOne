using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Repositories;
using Emos2.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Services
{
    public class EventService : ServiceBaseESR<Event>, IEventService
    {
        private IRepositoryESR<Event> myRepository;

        public EventService(IRepositoryESR<Event> userRepository) : base(userRepository)
        {
            this.myRepository = userRepository;
        }

         
    }
}
