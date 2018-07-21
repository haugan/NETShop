using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NETShop.Models.Repositories;
using NETShop.Models.Repositories.Interfaces;

namespace NETShop
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            AddRepositories(services);
            AddFrameworks(services);
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepositoryFake>(); // Create object each time interface is needed.
        }

        private static void AddFrameworks(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Product}/{action=List}/{id?}");
            });
        }
    }
}
