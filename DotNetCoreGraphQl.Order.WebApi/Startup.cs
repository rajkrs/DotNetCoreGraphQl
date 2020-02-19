using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplexFaker;
using DotNetCoreGraphQl.Order.Providers;
using DotNetCoreGraphQl.Order.Ql;
using DotNetCoreGraphQl.Order.Ql.Types;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DotNetCoreGraphQl.Order.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IFakeDataService, FakeDataService> ();
            services.AddSingleton<IOrderProvider, OrderProvider>();


            services.AddSingleton<OrdersQuery>();
            services.AddSingleton<OrdersMutation>();

            services.AddSingleton<OrderDetailsType>();
            services.AddSingleton<ProductType>();
            services.AddSingleton<PriceType>();

            services.AddSingleton<CartInputType>();


            services.AddSingleton<ISchema, OrdersSchema>();

            services.AddHttpContextAccessor();
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddGraphQL(_ =>
            {
                _.EnableMetrics = false; //Expose extensions data in response.
                _.ExposeExceptions = true;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // add http for Schema at default url /graphql
            app.UseGraphQL<ISchema>();

            // use graphql-playground at default url /ui/playground
            app.UseGraphQLPlayground(null);
                
            app.UseMvc();
        }
    }
}
