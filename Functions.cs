using AzureFunctions.Extensions.Swashbuckle.Attribute;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FunctionAppSwagger
{
    public static class Functions
    {
        [FunctionName("TestSwagger")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("This is an Http trigger function to test Swagger.");

            string responseMessage = "This is an Http trigger function to test Swagger.";

            return new OkObjectResult(responseMessage);
        }
    }
}

