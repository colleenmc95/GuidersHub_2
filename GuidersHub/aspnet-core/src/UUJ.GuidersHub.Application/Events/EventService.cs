using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUJ.GuidersHub.Events
{
    public class EventService : IEventService
    {
        private IRepository<Event> _eventRepository;


        public EventService(IRepository<Event> eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public Event CreateEvent(EventDto newEvent)
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
