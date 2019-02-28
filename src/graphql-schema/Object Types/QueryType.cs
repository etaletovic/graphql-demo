using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(f => f.Version()).Type<NonNullType<StringType>>();
            descriptor.Field(f => f.News).Type<NonNullType<ListType>>();

        }
    }
}
