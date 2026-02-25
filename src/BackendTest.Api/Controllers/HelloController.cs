using Microsoft.AspNetCore.Mvc;

namespace BackendTest.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("rot");
    }
}

[ApiController]
[Route("api/[controller]")]
public class SimonController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("rot");
    }
}