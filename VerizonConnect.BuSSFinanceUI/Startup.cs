// ***********************************************************************
// Assembly : VerizonConnect.BusinessSystemSolutionFinanceUI
// Author : Tyler Kraupp
// Created : 06-20-2019
//
// Last Modified By : Tyler Kraupp
// Last Modified On : 07-17-2019
// ***********************************************************************
// <copyright file="Startup.cs" company="Verizon Connect">
// Verizon Connect
//// </copyright>

namespace VerizonConnect.BuSSFinanceUI
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Context.BuSSIOT;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Context.BuSSSCM;
    using VerizonConnect.BusinessSystemSolutionFinanceUI.Context.NWC00;

    /// <summary>
    /// This is the startup class that runs when the application is started
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup" /> class.
        /// </summary>
        /// <param name="env">Gets or sets an environment variable</param>
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            this.Configuration = builder.Build();
        }

        /// <summary>
        /// Gets the configuration Variable
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">Services you want to add to your .NET Core application</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<BuSSSCMContext>(options => options.UseSqlServer(this.Configuration.GetConnectionString("BuSSSCMDatabase")));
            services.AddDbContext<BuSSIOTContext>(options => options.UseSqlServer(this.Configuration.GetConnectionString("BuSSIOTDatabase")));
            services.AddDbContext<NWC00Context>(options => options.UseSqlServer(this.Configuration.GetConnectionString("NWC00Database")));
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">Application variable</param>
        /// <param name="env">Environment variable</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=BusinessSystemSolutionBillableItems}/{action=Search}/{id?}");
            });
        }
    }
}
