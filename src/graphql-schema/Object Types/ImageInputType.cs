using graphql_common;
using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    class ImageInputType : InputObjectType<Image>
    {

        protected override void Configure(IInputObjectTypeDescriptor<Image> descriptor)
        {
            descriptor.Name("ImageInput");

            descriptor.Field(f => f.Size).Type<NonNullType<IntType>>();
            descriptor.Field(f => f.Url).Type<NonNullType<StringType>>();
        }
    }
}
