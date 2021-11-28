using System;
using System.Data;
using Hangfire;
using Hangfire.Console;
using Hangfire.Dashboard;
using Hangfire.SqlServer;
using LogDashboard;
using LogDashboard.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Logging;

namespace Shopping
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<ShoppingHttpApiHostModule>();
            //2services.AddTransient<IIds4Service, Ids4Service>();
            services.AddDistributedMemoryCache().AddSession();
           
            //services.AddTransient<IShowBrand, ShowBrand>();



			services.AddLogDashboard();
           

        }

		
	
		

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {

            app.InitializeApplication();
            app.UseLogDashboard();
            app.UseConfiguredEndpoints();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Shopping.HttpApi.Host");
            });

			
           
           

        }


    }
}
