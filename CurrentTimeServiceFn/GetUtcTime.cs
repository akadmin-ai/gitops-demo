using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

public static class GetUtcTime
{
    [FunctionName("GetUtcTime")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "time/utc")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Returning UTC time.");
        return new OkObjectResult(DateTime.UtcNow);
    }
}
