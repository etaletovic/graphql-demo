using graphql_common;
using System;
using System.Collections.Generic;
using System.Text;

namespace graphql_data
{
    public class EventRepository : IDataRepository<Event>
    {
        private readonly List<Event> events;

        public EventRepository()
        {
            events = new List<Event>()
            {
                new Event(){Description = "Event 1 Description which is not really long.", Id = 1, Title = "Event 1 Title", Images = new List<Image>(){new Image(){Size = 300, Url = "http://google.com/"}}},
                new Event(){Description = "Event 2 Description which is not really long.", Id = 2, Title = "Event 2 Title"},
                new Event(){Description = "Event 3 Description which is not really long.", Id = 3, Title = "Event 3 Title"},
                new Event(){Description = "Event 4 Description which is not really long.", Id = 4, Title = "Event 4 Title"},
                new Event(){Description = "Event 5 Description which is not really long.", Id = 5, Title = "Event 5 Title"},
                new Event(){Description = "Event 6 Description which is not really long.", Id = 6, Title = "Event 6 Title"},
                new Event(){Description = "Event 7 Description which is not really long.", Id = 7, Title = "Event 7 Title"},
                new Event(){Description = "Event 8 Description which is not really long.", Id = 8, Title = "Event 8 Title"},
                new Event(){Description = "Event 9 Description which is not really long.", Id = 9, Title = "Event 9 Title"},
                new Event(){Description = "Event 10 Description which is not really long.", Id = 10, Title = "Event 10 Title"},

            };
        }

        public Event Add(Event arg)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Event> Get()
        {
            return events;
        }
    }
}
