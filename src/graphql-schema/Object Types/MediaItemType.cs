using graphql_common;
using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    class MediaItemType : ObjectType<MediaItem>
    {
        protected override void Configure(IObjectTypeDescriptor<MediaItem> descriptor)
        {
            base.Configure(descriptor);
        }
    }
}
