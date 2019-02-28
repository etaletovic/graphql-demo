using System;
using System.Collections.Generic;
using System.Text;
using graphql_common;
using HotChocolate.Types;

namespace graphql_schema.Object_Types
{
    class EventType : ObjectType<Event>
    {
        protected override void Configure(IObjectTypeDescriptor<Event> descriptor)
        {
            base.Configure(descriptor);
        }
    }
}
