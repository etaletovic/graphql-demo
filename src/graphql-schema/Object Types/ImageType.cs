using graphql_common;
using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    class ImageType : ObjectType<Image>
    {
        protected override void Configure(IObjectTypeDescriptor<Image> descriptor)
        {
            descriptor.Name("image");

            descriptor.Field(f => f.Size).Type<IntType>();
            descriptor.Field(f => f.Url).Type<StringType>();
            
        }
    }
}
