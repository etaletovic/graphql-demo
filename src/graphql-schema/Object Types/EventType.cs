﻿using graphql_common;
using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    public class EventType : ObjectType<Event>
    {
        protected override void Configure(IObjectTypeDescriptor<Event> descriptor)
        {
            descriptor.Name("Event");

            descriptor.Field(f => f.Id).Type <NonNullType<IdType>>();
            descriptor.Field(f => f.Title).Type<StringType>();
            descriptor.Field(f => f.Description).Type<StringType>();
            descriptor.Field(f => f.Images).Type<ListType<ImageType>>();
        }
    }
}
