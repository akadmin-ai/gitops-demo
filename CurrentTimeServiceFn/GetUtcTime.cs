using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

public static class GetUtcTime
{
    [FunctionName("GetUtcTime")]
    public static IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "time/utc")] HttpRequest req,
        ILogger log)
    {
        return new OkObjectResult(DateTime.UtcNow);
    }
}
