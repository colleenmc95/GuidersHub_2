using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUJ.GuidersHub.Events
{
    interface IEventService : IApplicationService 
    {
        Event CreateEvent(EventDto newEvent);
        Event DeleteEvent (EventDto eventDelete);
        Event UpdateEvent (EventDto eventUpdate); 
        Event GetEventByID (int Id);
        List<Event> GetAllEvents();  
    }
}
