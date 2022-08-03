using Microsoft.AspNetCore.Mvc;

namespace tokenServer.Controllers;

[ApiController]
[Route("main")]
public class MainController : ControllerBase
{
    [HttpGet("key")]
    public string GetKey([FromServices]CryptoService crypto)
    {
        return crypto.GetInternalKey();
    }
}
