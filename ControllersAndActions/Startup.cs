using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllersWithViews();
            services.AddMvc(); // (options => options.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(null, "{name}/{city}", new { controller = "Home", action = "Data" });
                endpoints.MapControllerRoute(null, "{controller=Home}/{action=Data}/RedirectResult/{name}/{city}");
                endpoints.MapControllerRoute("MyRoute", "{controller=Home}/{action=Index}/{id?}/{*catchall}");
            });
        }
    }
}
