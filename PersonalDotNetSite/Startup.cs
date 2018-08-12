using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalDotNetSite.Models;

namespace PersonalDotNetSite
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            Configuration = new ConfigurationBuilder()
                           .SetBasePath(hostingEnvironment.ContentRootPath)
                           .AddJsonFile("appsettings.json")
                           .Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddTransient<ISkillsRepository, SkillsRepository>();
            services.AddTransient<IProjectsRepositiory, ProjectsRepository>();
            services.AddTransient<IParagraphRepository, ParaRepository>();
            services.AddTransient<IFaqRepository, FaqRepository>();

            //users will have a cookie on their machine to authenticate
            services.AddAuthentication(sharedOptions =>
            {
                sharedOptions.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                sharedOptions.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            }).AddAzureAd(options => Configuration.Bind("AzureAd", options))
            .AddCookie();

            services.AddDbContext<AppDbContext>(options =>
                             options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
            }

            //AzureAD will use cookies to authenticate as described above
            app.UseAuthentication();

            //displays text status codes during errors between codes 400-600
            app.UseStatusCodePages();

            //enable site to serve static files
            app.UseStaticFiles();

            //routing pattern for site
            app.UseMvc(routes =>
            {

                //Projects using the arg to show a single project in greater detail
                routes.MapRoute(name: "showProject",
                                template: "Projects/{action}/{id}",
                                defaults: new { controller = "Projects", action = "Show" });

                //Skills using the arg to filter
                routes.MapRoute(name: "skillFilter",
                                template: "Skills/{action}/{id?}",
                                defaults: new { controller = "Skills", action = "List" });

                routes.MapRoute(name: "default",
                                template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
