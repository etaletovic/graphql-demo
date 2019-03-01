using graphql_common;
using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    class ArticleInputType : InputObjectType<Article>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Article> descriptor)
        {
            descriptor.Name("ArticleInput");

            descriptor.Field(f => f.Id).Type <NonNullType<IntType>>().DefaultValue(0);
            descriptor.Field(f => f.Images).Type<NonNullType<ListType<ImageInputType>>>();
        }
    }
}
