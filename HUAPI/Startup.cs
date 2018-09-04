using HUAPIClassLibrary;
using HUAPICore.Data;
using HUAPICore.Interfaces;
using HUAPICore.Services;
using HUAPICore.Services.Interfaces;
using HUAPICore.Services.Jaffa;
using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Profile7ClassLibrary;
using Serilog;
using Swashbuckle.AspNetCore.Swagger;
using Syncfusion.Licensing;
using System;
using System.Collections.Generic;
using System.IO;

namespace HUAPICore
{
    /// <summary>
    /// This object is created from the Main function
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            if (File.Exists(System.IO.Directory.GetCurrentDirectory() + "/SyncfusionLicense.txt"))
            {
                string licenseKey = System.IO.File.ReadAllText(System.IO.Directory.GetCurrentDirectory() + "/SyncfusionLicense.txt");
                SyncfusionLicenseProvider.RegisterLicense(licenseKey);
            }

        }

        /// main configuration object
        public IConfiguration Configuration { get; }


        /// <summary>
        /// Used in compression
        /// </summary>
        public static readonly IEnumerable<string> MimeTypes = new[]
        {
            // General
            "text/plain",
            // Static files
            "text/css",
            "application/javascript",
            // MVC
            "text/html",
            "application/xml",
            "text/xml",
            "application/json",
            "text/json",
        };

        //        private string _exchangepwd;

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //_exchangepwd = Configuration["exchange:pwd"];

            services.AddHangfire(x => x.UseSqlServerStorage(Configuration.GetConnectionString("HUAPIDB")));            //JobStorage.Current = new SqlServerStorage("HUAPIDB");


            services.Configure<GzipCompressionProviderOptions>(options => options.Level = System.IO.Compression.CompressionLevel.Optimal);
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
            });
            //services.AddResponseCompression(options =>
            //{
            //    options.EnableForHttps = true;
            //    options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
            //    {
            //        "image/svg+xml",
            //        "application/atom+xml"
            //    });
            //    options.Providers.Add<GzipCompressionProvider>();
            //});


            services.AddSession();

            services.AddDbContext<HUAPIDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HUAPIDB")));
            services.AddDbContext<ProfileDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ProfileDB")));
            services.AddDbContext<ProfileStageDBDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ProfileStageDB")));
            services.AddScoped<IProfileDAL, SQLProfileDAL>(); //InMemoryARSQueueData
            services.AddScoped<IFWLinkService, FWLinkService>();
            switch (Configuration["SystemConfig:SMSService"])
            {
                case "Exchange":
                    services.AddScoped<ISMSService, SMSExchangeService>();
                    break;
                case "Wire2Air":
                    services.AddScoped<ISMSService, SMSWire2AirService>();
                    break;
                case "Twilio":
                    services.AddScoped<ISMSService, SMSTwilioService>();
                    break;
            }

            services.AddTransient<IJaffaService, JaffaService>();
            services.AddSingleton<ISettings>(sp => new SettingsService(Configuration));

            // Required to use the Options<T> pattern
            services.AddOptions();
            services.Configure<CustomConfig>(Configuration);


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            //services.AddMvc(options =>
            //    {
            //        //options.Filters.Add(new NeedCodeFilterAttribute());
            //    }
            //);

            services.AddHsts(options =>
            {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(60);
                //options.ExcludedHosts.Add("example.com");
                //options.ExcludedHosts.Add("www.example.com");
            });

            services.AddHttpsRedirection(options =>
            {
                options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                options.HttpsPort = 5001;
            });

            //adds a special mustbelive filter
            //services.AddScoped<Filters.MustBeLiveFilterAttribute>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "HUAPI",
                    Description = "Health Unit API",
                    TermsOfService = "None",
                });
                //TODO    fix PlatformServices reference  c.IncludeXmlComments(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "doc.xml"));
                c.DescribeAllEnumsAsStrings();
            });

            services.AddMemoryCache();


            using (var settingContext = services.BuildServiceProvider().GetService<ISettings>())
            {
                settingContext.ReadSettings();
                if (Convert.ToBoolean(settingContext.Settings["IsLive"]))
                {
                    Log.Information("System is: LIVE");
                }
                else
                {
                    Log.Warning("System is: NOT LIVE");
                }
            }

            services.Configure<IISOptions>(options =>
            {
                options.AutomaticAuthentication = true;
            });


            //var sp = services.BuildServiceProvider();
            //var adminBO = sp.GetService<IAdminBO>();
            //using (var ctx = services.BuildServiceProvider().GetService<IProfileDAL>())
            //{
            //    RecurringJob.AddOrUpdate("ProfileFormScraper", () => ctx.GetConcurrentUsersLatest(), "15 0 * * 2-5");      // every tuesday to saturday at 15 after midnight
            //}

            /*
            *****command to be executed
            - - - - -
            | | | | |
            | | | | +-----day of week(0 - 6) (Sunday = 0)
            | | | +-------month(1 - 12)
            | | +---------day of month(1 - 31)
            | +-----------hour(0 - 23)
            +-------------min(0 - 59)
            */
        }

        /// <summary>
        /// When the program is terminated lets do some cleanup
        /// </summary>
        protected void DisposeResources()
        {
            Log.CloseAndFlush();
            //TODO check if scraping job is running and don't shutdown if possible.
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="applicationLifetime"></param>
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env, Microsoft.AspNetCore.Hosting.IApplicationLifetime applicationLifetime)
        {
            //var result = string.IsNullOrEmpty(_exchangepwd) ? "Null" : "Not Null";
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync($"Secret is {result}");
            //});

            app.UseHangfireServer(new BackgroundJobServerOptions() { WorkerCount = 5 });
            app.UseHangfireDashboard("/jobs", new DashboardOptions() { StatsPollingInterval = 10000 });

            app.UseResponseCompression();
            applicationLifetime.ApplicationStopping.Register(DisposeResources);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
                //app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseStatusCodePages();

            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                //c.DocumentTitle("Enterprise API UI");
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Enterprise API V1");
            });
        }

    }
}
