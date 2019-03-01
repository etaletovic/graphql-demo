using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(f => f.Version()).Type<NonNullType<StringType>>();

            descriptor.Field(f => f.GetEvents(default(string))).Type<NonNullType<ListType<EventType>>>().Argument("titleContains",a=>a.Type<StringType>());

            descriptor.Field(f => f.News).Type<NonNullType<ListType<ArticleType>>>();

            descriptor.Field(f => f.Images).Type<NonNullType<ListType<ImageType>>>();

        }
    }
}
