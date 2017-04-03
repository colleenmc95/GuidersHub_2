using Abp.Authorization;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUJ.GuidersHub.Authorization;

namespace UUJ.GuidersHub.Events
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class EventService : GuidersHubAppServiceBase, IEventService
    {
        private IRepository<Event> _eventRepository;


        public EventService(IRepository<Event> eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public Event CreateEvent(Event newEvent)
        {
            Event testEvent = new Event()
            {
                Description = "Test"
            };
            _eventRepository.Insert(testEvent);

            return testEvent;
        }

        public Event DeleteEvent(EventDto eventDelete)
        {
            throw new NotImplementedException();
        }

        public List<Event> GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public Event GetEventByID(int Id)
        {
            throw new NotImplementedException();
        }

        public Event UpdateEvent(EventDto eventUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
