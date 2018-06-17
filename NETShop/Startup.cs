using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NETShop.Models.Repositories;
using NETShop.Models.Repositories.Interfaces;

namespace NETShop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Repositories:
            services.AddTransient<IProductRepository, ProductRepositoryFake>(); // Create object each time interface is needed.

            // Frameworks:
            services.AddMvc(); // Set up shared objects for MVC.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages(); // Add HTML to HTTP responses normally without body (e.g. 404 - Not Found).
            app.UseStaticFiles(); // Enable support for serving files from wwwroot folder.

            // Routing:
            app.UseMvc(routes =>
            {

            });
        }
    }
}
