using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

public static class GetTimezoneTime
{
    [FunctionName("GetTimezoneTime")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "time/est")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Returning time for specified timezone (EST).");
        
        var estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        var estTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, estTimeZone);
        
        return new OkObjectResult(estTime);
    }
}
