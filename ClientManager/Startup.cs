using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClientManager.BLL.Interfaces;
using ClientManager.BLL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ClientManager.Data;
using ClientManager.Domain;
using ClientManager.Models;
using ClientManager.Services;
using ClientManager.DAL.EF;
using ClientManager.DAL.Interfaces;
using ClientManager.DAL.Repositories;
using LearningPortal.DAL.Interfaces;

namespace ClientManager
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
            services.AddDbContext<ClientManagerContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ClientManagerContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddScoped<DbContext,ClientManagerContext>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<IClientServices, ClientServices>();
            services.AddScoped<IClientRepository,ClientRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddAutoMapper();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
