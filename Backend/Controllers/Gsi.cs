using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class Gsi : ControllerBase
{

    private readonly ILogger<Gsi> _log;

    public Gsi(ILogger<Gsi> log)
    {
        _log = log;
    }

    [HttpPost(Name = "GsiInput")]
    public Task Post(object player)
    {
        _log.LogInformation((string?)player);
        return Task.CompletedTask;
    }
}
