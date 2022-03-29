using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace CRUDProject5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);
            var servicios = serviceCollection.BuildServiceProvider();
            var httpClientFactory = servicios.GetRequiredService<IHttpClientFactory>();

            var httpClient = httpClientFactory.CreateClient();
            

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        
        private static void Configure(ServiceCollection services)
        {
            services.AddHttpClient();
        }

        
    }
}
