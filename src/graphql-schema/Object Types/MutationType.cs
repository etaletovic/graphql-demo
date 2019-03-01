using graphql_common;
using graphql_data;
using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Field(f => f.CreateArticle(default(Article))).Type<NonNullType<ArticleType>>()
                .Argument("article", a=>a.Type<NonNullType<ArticleInputType>>());

        }
    }
}
