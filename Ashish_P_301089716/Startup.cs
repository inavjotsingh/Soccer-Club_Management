using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ashish_P_301089716.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ashish_P_301089716
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration) => Configuration = configuration;
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:ClubManagementSystem:ConnectionString"]));
            services.AddTransient<IClubRepository, EFClubRepository>();
            services.AddTransient<IPlayerRepository, EFPlayerRepository>();
            //services.AddSingleton<IClubRepository, ClubRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => 
            {
                routes.MapRoute(
                      name: null,
                      template: "Clubs/ManageClubs/{clubID:int}",
                      defaults: new { controller = "Clubs", action = "ManageClubs" }
                      );
                routes.MapRoute(
                      name: null,
                      template: "CRUD/Update/{clubID:int}",
                      defaults: new { controller = "CRUD", action = "UpdateClub" }
                      );
                routes.MapRoute(
                    name: null,
                    template: "CRUD/ManageClubs",
                    defaults: new { Controller = "Clubs", action = "Clubs" }
                    );
                routes.MapRoute(
                    name: null,
                    template: "CRUD/Clubs",
                    defaults: new { Controller = "Clubs", action = "Clubs" }
                    );
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}"); 
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
