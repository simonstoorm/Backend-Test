using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackendTest.Api.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    [HttpGet("public")]
    public IActionResult Public() => Ok("Public OK");

    [Authorize]
    [HttpGet("private")]
    public IActionResult Private() => Ok(new
    {
        message = "Private OK",
        user = User.Identity?.Name
    });
}