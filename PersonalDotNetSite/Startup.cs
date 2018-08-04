using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PersonalDotNetSite.Models;

namespace PersonalDotNetSite
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddTransient<ISkillsRepository, MockDB.SkillsRepo>();
            services.AddTransient<IProjectsRepositiory, MockDB.ProjectsRepo>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //displays text status codes during errors between codes 400-600
            app.UseStatusCodePages();

            //enable site to serve static files
            app.UseStaticFiles();

            //defualt routing schema for MVC
            app.UseMvcWithDefaultRoute();
        }
    }
}
