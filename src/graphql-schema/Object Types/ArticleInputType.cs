using graphql_common;
using HotChocolate.Language;
using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    class ArticleInputType : InputObjectType<Article>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Article> descriptor)
        {
            //base.Configure(descriptor);

            descriptor.Name("Article");

            descriptor.Field(f => f.Id)
                .Type<IntType>()
                .DefaultValue(0);
        }
    }
}
