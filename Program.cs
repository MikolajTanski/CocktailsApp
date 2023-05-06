using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;
using Serilog.Formatting.Json;
using Serilog.Formatting.Compact.Reader;
using Serilog.Formatting.Display;
using Serilog.Sinks.Console;
using Serilog.Sinks.File;


namespace Drinks_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

       public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .ConfigureWebHostDefaults(webBuilder =>
               {
                   webBuilder.UseStartup<Startup>();
               })
               .ConfigureLogging(logging =>
               {
                   logging.ClearProviders();
                   logging.AddSerilog(new LoggerConfiguration()
                       .WriteTo.Console()
                       .CreateLogger());
               });
    }
}
