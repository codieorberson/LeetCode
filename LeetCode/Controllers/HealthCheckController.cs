using Microsoft.AspNetCore.Mvc;

namespace LeetCode.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HealthCheckController : Controller
    {
        [HttpGet("HealthCheck")]
        public IActionResult HealthCheck()
        {
            return Ok();
        }
    }
}