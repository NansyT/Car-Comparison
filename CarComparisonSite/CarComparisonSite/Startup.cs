using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarComparisonSite
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
            services.AddSession();
            services.AddControllersWithViews();
            services.AddScoped<IFetchCarFromDb, Ms_SqlConnector>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "ClearFilters", pattern: "{controller=Home}/{action=ClearFilters}");
                endpoints.MapControllerRoute(name: "GetAllBrands", pattern: "{controller=Home}/{action=GetAllBrands}");
                endpoints.MapControllerRoute(name: "SelectBrand", pattern: "{controller=Home}/{action=SelectBrand}/{brand}");
                endpoints.MapControllerRoute(name: "SelectModel", pattern: "{controller=Home}/{action=SelectModel}/{model}");
                endpoints.MapControllerRoute(name: "SelectVariant", pattern: "{controller=Home}/{action=SelectVariant}/{variant}");
                endpoints.MapControllerRoute(name: "SelectYear", pattern: "{controller=Home}/{action=SelectYear}/{year}");
                endpoints.MapControllerRoute(name: "SetKmPerYear", pattern: "{controller=Home}/{action=SetKmPerYear}/{kmYear}");
                endpoints.MapControllerRoute(name: "SetOwnership", pattern: "{controller=Home}/{action=SetOwnership}/{owner}");
            });
        }
    }
}
