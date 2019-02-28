using System;
using System.Collections.Generic;
using System.Text;
using graphql_common;
using  graphql_data;

namespace graphql_schema
{
    public class Query
    {
        private EventRepository _eventRepository;

        public Query()
        {
                _eventRepository = new EventRepository();
        }
        public string Version() => "1.0";

        public IEnumerable<Article> News { get; set; }

        public IEnumerable<Event> Events => _eventRepository.Get();

    }
}
