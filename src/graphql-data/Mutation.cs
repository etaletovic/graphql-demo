using System;
using System.Threading.Tasks;
using graphql_common;

namespace graphql_data
{
    public class Mutation
    {
        private readonly IDataRepository<Article> _newsRepository;
        private readonly IDataRepository<Event> _eventsRepository;
        public Mutation(IDataRepository<Article> newsRepository, IDataRepository<Event> eventsRepository)
        {
            this._newsRepository = newsRepository ?? throw new ArgumentNullException(nameof(newsRepository));
            this._eventsRepository = eventsRepository ?? throw new ArgumentNullException(nameof(eventsRepository));
        }
        public async Task<Article> CreateArticle(Article article)
        {
            return _newsRepository.Add(article);
        }
    }
}
