using System;
using System.Collections;
using System.Collections.Generic;

namespace graphql_data
{
    public interface IDataRepository<T>
    {
        IEnumerable<T> Get();
        T Add(T arg);
    }
}
