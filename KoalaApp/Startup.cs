using KoalaApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using Blazored.LocalStorage;
using Havit;
using Havit.Blazor;
using Havit.Blazor.Components.Web;
using Havit.Blazor.Components.Web.Bootstrap;
using System.Threading;
using System.Globalization;

namespace KoalaApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddScoped<UsersHandler>();
            services.AddScoped<ProjectsHandler>();
            services.AddScoped<TwigsHandler>();

            services.AddScoped<AccountHandler>();
            services.AddScoped<TwigsTempStorage>();
            services.AddScoped<EditedTwig>();
            services.AddScoped<ShareHandler>();

            services.AddScoped<OptimizationManager>();
            services.AddScoped<DragAndDropContainer>();
            services.AddScoped<ShareProject>();

            services.AddSingleton<CookieSecurityHandler>();
            services.AddScoped<WindowDimensions>();

            AddExternalServices(services);
            SetDefaults();
        }

        private void AddExternalServices(IServiceCollection services)
        {
            services.AddBlazoredLocalStorage();
            services.AddBlazoredLocalStorage(config => config.JsonSerializerOptions.WriteIndented = true);

            services.AddHxServices();
        }

        private void SetDefaults()
        {
            HxButton.Defaults.Color = ThemeColor.Primary;
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
