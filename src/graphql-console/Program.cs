using System;
using graphql_schema;
using HotChocolate;
using HotChocolate.Execution;

namespace graphql_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = Schema.Create(c => c.RegisterQueryType<Query>());
            var executor = schema.MakeExecutable();
            var result = executor.Execute("{ hello }");
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }



}
