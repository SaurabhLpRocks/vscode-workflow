using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CoreDataApi
{
    public class Program
    {

        static readonly HttpClient client = new HttpClient();
        public static async Task Main(string[] args)
        {

            try
            {
                // HttpResponseMessage response = await client.GetAsync("http://core-api-service:5000/api/values");
                // response.EnsureSuccessStatusCode();
                // string responseBody = await response.Content.ReadAsStringAsync();

                // Console.WriteLine(response.StatusCode);
                Console.WriteLine("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
                Console.WriteLine("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
                Console.WriteLine("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
                Console.WriteLine("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
                Console.WriteLine("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
                Console.WriteLine("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
                Console.WriteLine("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
                Console.WriteLine("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
                Console.WriteLine("XXXXXXXXXXXXXX-------Success--------XXXXXXXXXXXXXX");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
    }
}