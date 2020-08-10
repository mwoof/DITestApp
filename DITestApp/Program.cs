using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DITestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //System.Diagnostics.Debug.WriteLine(System.Configuration["Shopify"]);
            string connString = Startup.StaticConfig.GetConnectionString("DefaultConnection");
            //.GetSection("Shopify")["Shopify_API_Key"];
            System.Diagnostics.Debug.WriteLine("WITHIN PROGRAM------------");
            System.Diagnostics.Debug.WriteLine(connString);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
