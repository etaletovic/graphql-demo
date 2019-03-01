using graphql_common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graphql_data
{
    public class NewsRepository : IDataRepository<Article>
    {
        private List<Article> news;

        public NewsRepository()
        {
            news = new List<Article>()
            {
                new Article(){Description = "Article 1 Description which is not really long.", Id = 1, Title = "Article 1 Title", Images = new List<Image>(){new Image(){Size = 300, Url = "http://google.com/"}}},
                new Article(){Description = "Article 2 Description which is not really long.", Id = 2, Title = "Article 2 Title"},
                new Article(){Description = "Article 3 Description which is not really long.", Id = 3, Title = "Article 3 Title"},
                new Article(){Description = "Article 4 Description which is not really long.", Id = 4, Title = "Article 4 Title"},
                new Article(){Description = "Article 5 Description which is not really long.", Id = 5, Title = "Article 5 Title"},
                new Article(){Description = "Article 6 Description which is not really long.", Id = 6, Title = "Article 6 Title"},
                new Article(){Description = "Article 7 Description which is not really long.", Id = 7, Title = "Article 7 Title"},
                new Article(){Description = "Article 8 Description which is not really long.", Id = 8, Title = "Article 8 Title"},
                new Article(){Description = "Article 9 Description which is not really long.", Id = 9, Title = "Article 9 Title"},
                new Article(){Description = "Article 10 Description which is not really long.", Id = 10, Title = "Article 10 Title"},

            };
        }

        public Article Add(Article arg)
        {
            arg.Id = news.Last().Id + 1;
            news.Add(arg);
            return arg;
        }

        public IEnumerable<Article> Get()
        {
            return news;
        }
    }
}
