using Figgle;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;
using Serilog.Events;
using System;

namespace HUAPICore
{
    /// <summary>
    /// This is the main program entry
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main function called when the program is executed
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static int Main(string[] args)
        {
            Console.WriteLine(FiggleFonts.Ogre.Render("HUAPI (Alpha)"));

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.Console()
                //https://github.com/serilog/serilog-sinks-rollingfile
            .WriteTo.RollingFile("logs/log-{Date}.txt", retainedFileCountLimit: null)    //buffered: true, shared: true
            .CreateLogger();

            try
            {
                Log.Information("Starting web host");
                BuildWebHost(args).Run();
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }

        }

        /// <summary>
        /// Creates the self hosted object with setup from the startup class
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseApplicationInsights()
                .UseStartup<Startup>()
                .UseSerilog()
                .CaptureStartupErrors(true)
                .Build();
    }
}
