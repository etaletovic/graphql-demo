using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using graphql_common;
using graphql_data;
using GraphiQl;
using graphql_schema;
using graphql_schema.Object_Types;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution;
using HotChocolate.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace graphql_web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDataRepository<Article>, NewsRepository>();
            services.AddSingleton<IDataRepository<Event>, EventRepository>();

            services.AddGraphQL(sp => Schema.Create(c =>
            {
                c.RegisterServiceProvider(sp);
                c.RegisterQueryType<QueryType>();
                c.RegisterMutationType<MutationType>();
            }));
        }
 

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            app.UseGraphQL();

            app.UseGraphiQl("/graphql", "/");




            
        }
    }
}
