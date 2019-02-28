using System;
using System.Collections;
using System.Collections.Generic;

namespace graphql_data
{
    public interface IDataRepository<out T>
    {
        IEnumerable<T> Get();
    }
}
