using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Azure.Maps
{
    public static class MapsFunc
    {
        [FunctionName("MapsFunc")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log,  ExecutionContext context)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var config = new ConfigurationBuilder()
                    .SetBasePath(context.FunctionAppDirectory)
                    
                            // This gives you access to your application settings
                            // in your local development environment:
                    .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)

                            // This is what actually gets you the application settings in Azure
                    .AddEnvironmentVariables() 
                    .Build();

            dynamic response = new 
            {
                sasToken = config["sasToken"]
            };
            return new JsonResult(response);
        }
    }
}
