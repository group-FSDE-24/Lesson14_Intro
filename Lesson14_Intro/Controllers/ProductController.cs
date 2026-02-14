using Microsoft.AspNetCore.Mvc;

namespace Lesson14_Intro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet()]
    public IActionResult Test()
    {
        return Ok();
    }
}
