using System.Collections.Generic;

namespace graphql_common
{
    public abstract class MediaItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Image> Images { get; set; }
    }
    public class Article : MediaItem
    {

    }

    public class Event : MediaItem
    {

    }

    public class Image
    {
        public int Size { get; set; }
        public string Url { get; set; }
    }
}
