using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

[ApiController]
[Route("api/[controller]")]
public class EntryController : ControllerBase
{

    [HttpGet]
    [EnableRateLimiting("StrictPolicy")]
    public IActionResult GetEntry()
    {
        return Ok(new { Message = "Access granted to /api/entry!" });
    }

    [HttpGet("bar")]
    [EnableRateLimiting("SoftPolicy")]
    public IActionResult GetBar()
    {
        return Ok(new { Message = "Access granted to /api/bar with a softer limit!" });
    }
}