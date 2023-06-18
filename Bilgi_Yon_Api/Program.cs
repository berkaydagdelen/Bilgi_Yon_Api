using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Serilog.Filters;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Configuration;
using System.IO;

namespace Bilgi_Yon_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string evn = Environment.GetEnvironmentVariable("aspnetcore_Environment");
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", false, true)
            //    .AddEnvironmentVariables()
            //    .Build();

            //string connectionString = config.GetSection("connectionString:OGRENCI").Value;

            //Log.Logger = new LoggerConfiguration()
            //    .MinimumLevel.Information()
            //     .WriteTo.File("Log/Log.json").CreateLogger();

            //    //.Enrich.FromLogContext()
            //    //.WriteTo.MSSqlServer("server=DESKTOP-83R1MUR;database=OGRENCI;user id=sa;password=1234;persist security info=True;", sinkOptions: new MSSqlServerSinkOptions { TableName = "Logs", AutoCreateSqlDatabase = true })
            //    //.Enrich.WithProperty("Environment", evn)
            //    //.ReadFrom.Configuration(config)
            //    //.CreateLogger();


            //CreateHostBuilder(args).Build().Run();

            Log.Logger = new LoggerConfiguration()
          
            .Enrich.FromLogContext()
            .WriteTo.Logger(lc => lc
            .Filter.ByIncludingOnly(

           Matching.FromSource("Microsoft.AspNetCore.Hosting"))
          .WriteTo.File("Log/request.json", rollingInterval: RollingInterval.Day))
          .WriteTo.Logger(lc => lc
          .Filter.ByExcluding(

           Matching.FromSource("Microsoft.AspNetCore.Hosting"))
           .WriteTo.File("Log/response.json", rollingInterval: RollingInterval.Day))
           .CreateLogger();
            CreateHostBuilder(args).Build().Run();



        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
            .ConfigureLogging(p => { p.ClearProviders(); })
            .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                 {
                     webBuilder.UseStartup<Startup>();
                 });
    }
}
