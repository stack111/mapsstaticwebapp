using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Azure.Maps
{
    public static class MapsFunc
    {
        [FunctionName("MapsFunc")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            dynamic response = new 
            {
                sasToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiJlYWM4Njg0OS1lYzUyLWVlYmItNzc5MC0xNWQwOTM5ZDY5ODkiLCJyZWdpb25zIjoiW10iLCJtYXhSYXRlUGVyU2Vjb25kIjoiNTAwIiwib2lkIjoiMGY4NmE3ODEtYzdjMi00MjVmLWIyZGQtYmYyYTY2N2RlNmQ5IiwibmJmIjoxNjM1MTM2NTkxLCJleHAiOjE2NjY2NzI1OTEsImlhdCI6MTYzNTEzNjY0MSwiaXNzIjoiZTYzMzE2ZjMtYjQ1MC00MWNjLWFlZTQtYmM2NmU3OTU3ZTM0IiwiYXVkIjoiL3N1YnNjcmlwdGlvbnMvZDllZWY2NTAtYTg3Yy00MzNiLWEyMzYtMGVhZjMxNDBkOTIxL3Jlc291cmNlR3JvdXBzL21hcHMtZHN0YWNrLXRlbXBzYW1wbGUvcHJvdmlkZXJzL01pY3Jvc29mdC5NYXBzL2FjY291bnRzL21hcHMzbnVhYWpzaXpldnUifQ.t0ujrmoHNhrZxukCPR3tPuiuJQxv2VmI2uzxJoUzorE"
            };
            return new JsonResult(response);
        }
    }
}
