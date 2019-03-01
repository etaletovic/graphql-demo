using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using graphql_common;
using graphql_data;
namespace graphql_schema
{
    public class Query
    {
        private EventRepository eventRepository;
        private IDataRepository<Article> newsRepository;

        public Query(IDataRepository<Event> eventRepository, IDataRepository<Article> newsRepository)
        {
            this.eventRepository = eventRepository as EventRepository ?? throw new ArgumentNullException(nameof(eventRepository));
            this.newsRepository = newsRepository ?? throw new ArgumentNullException(nameof(newsRepository));
        }
        public string Version() => ConfigurationManager.AppSettings["version"];

        public IEnumerable<Event> GetEvents(string titleContains = default(string))
        {
            if (titleContains == default(string)) return eventRepository.Get();

            return eventRepository.Get(titleContains);
        }

        public IEnumerable<Article> News => newsRepository.Get();

        public IEnumerable<Image> Images
        {
            get
            {
                var eventRepoImages = eventRepository.Get().Where(e=>e.Images != null).SelectMany(e => e.Images).ToList();
                var newsRepoImages = newsRepository.Get().Where(e=>e.Images != null).SelectMany(e => e.Images).ToList();
                var returnList = new List<Image>(eventRepoImages);
                returnList.AddRange(newsRepoImages);
                return returnList;
            }
        }

    }
}
