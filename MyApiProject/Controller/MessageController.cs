using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
    [HttpGet]
    public ActionResult<object> Get()
    {
        return new { message = "Hello from .NET 8 Web API on Azure Container Apps!" };
    }
}