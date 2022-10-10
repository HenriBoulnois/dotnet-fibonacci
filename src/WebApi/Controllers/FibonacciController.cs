using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FibonacciController : ControllerBase   
{
    [HttpPost]
    public async Task<IList<long>> Run([FromServices] ILogger<FibonacciController> logger,
        [FromServices] Fibonacci fibonacci,
        string[] args)
    {
        logger.LogInformation("youhou");
        return await fibonacci.RunAsync(args);
    }
}
