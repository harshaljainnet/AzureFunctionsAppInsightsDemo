using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsAppInsightsDemo;

public class Function1
{
    private readonly ILogger<Function1> _logger;

    public Function1(ILogger<Function1> logger)
    {
        _logger = logger;
    }

    
    [Function("Function1")]
    public async Task<IActionResult> Run1([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        await Task.Delay(TimeSpan.FromSeconds(10));
        return new OkObjectResult("Function-1");
    }

    [Function("Function2")]
    public async Task<IActionResult> Run2([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        var noAsString = "This is not a number";
        int no = Convert.ToInt32(noAsString);
        return new OkObjectResult("Function-2");
    }
}