using graphql_common;
using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    public class ArticleType : ObjectType<Article>
    {
        protected override void Configure(IObjectTypeDescriptor<Article> descriptor)
        {
            base.Configure(descriptor);
        }
    }
}
