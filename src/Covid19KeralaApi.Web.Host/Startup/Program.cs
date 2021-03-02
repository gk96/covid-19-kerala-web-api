using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Covid19KeralaApi.Web.Host.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {

            if (System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != null )
            {
                return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
            }

            else
            {
                return WebHost.CreateDefaultBuilder(args)
                    .UseStartup<Startup>()
                    .UseKestrel(options =>
                    {
                        options.ListenAnyIP(Int32.Parse(System.Environment.GetEnvironmentVariable("PORT")));
                    })
                    .Build();
            }
        }
    }
}
