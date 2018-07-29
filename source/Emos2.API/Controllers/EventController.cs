using AutoMapper.QueryableExtensions;
using Emos2.API.Models.Events;
using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Emos2.API.Controllers
{
    public class EventController : BaseController
    {

        private readonly IEventService eventService;


        public EventController(IEventService eventService)
        {
            this.eventService = eventService;
            eventService.SetClientConnectionString(getConnectionString());
        }


        [HttpGet]
        [Route("events/")]
        public IHttpActionResult GetEvents()
        {
            IEnumerable<EventModel> users = this.eventService.SelectAll()
                                   .ProjectTo<EventModel>(this.Mapper.ConfigurationProvider) 
                                   .OrderBy(u => u.EventStart);
            return Ok(users);
        }

        [HttpGet]
        [Route("events/{id}")]
        public IHttpActionResult GetEventr(int id)
        {
            Event eventData = this.eventService.Select(id);
            EventModel eventModel = this.Mapper.Map<EventModel>(eventData);

            return  Ok(eventModel);
        }

    }
}
