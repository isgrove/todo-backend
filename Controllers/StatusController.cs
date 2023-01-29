using Microsoft.AspNetCore.Mvc;

namespace TodoBackend.Controllers
{
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get()
        {
            return Ok(new { status = "ok" });
        }    
    }
}