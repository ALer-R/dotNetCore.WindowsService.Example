using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyService
{
   public class Startup
    {

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            NLog.LogManager.LoadConfiguration("nlog.config");
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            #region NLog
            //services.AddSingleton<ILoggerFactory, LoggerFactory>();
            //services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
            ////services.AddLogging((builder) => builder.SetMinimumLevel(LogLevel.Trace));
            ////services.AddLogging((builder) => builder.SetMinimumLevel(Configuration.GetSection("Logging").GetValue<LogLevel>("LogLevel")));
            //var serviceProvider = services.BuildServiceProvider();
            //var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

            ////configure NLog
            //loggerFactory.AddNLog(new NLogProviderOptions { CaptureMessageTemplates = true, CaptureMessageProperties = true });
            #endregion
        }        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddNLog();           
        }
    }
}
