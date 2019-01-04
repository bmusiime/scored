using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scored.Models;

namespace Scored
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        public static string APPBASEURL = null;
        public static string APPURL = null;
        public static string APIURL = null;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //var URL = configuration.GetSection("APP_URL").Value;
            var URL = configuration.GetSection("TEST_URL").Value;
            APPBASEURL = URL;
            APPURL = APPBASEURL+"/";
            APIURL = APPURL + "api/";
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddDbContext<ScoredDBContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("ScoredDBContext")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSingleton<IConfiguration>(Configuration); 
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();

            var config = builder.Build();
            //var connstr = config.GetConnectionString("ScoredDBContext");
            //var confev = config.GetSection("ASPNETCORE_URLS").Value;
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                //var TESTBASEURL = config.GetSection("TEST_URL").Value;
                //APPBASEURL = TESTBASEURL;
                //APPURL = APPBASEURL + "/";
                //APIURL = APPURL + "api/";
            }
            else
            {
                //connstr = config.GetConnectionString("ScoredDBConnection");
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
