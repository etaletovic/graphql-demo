using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(f => f.Version()).Type<NonNullType<StringType>>();

            descriptor.Field(f => f.Events).Type<NonNullType<ListType<EventType>>>();

            descriptor.Field(f => f.News).Type<NonNullType<ListType<ArticleType>>>();

            descriptor.Field(f => f.Images).Type<NonNullType<ListType<ImageType>>>();

        }
    }
}
