using Microsoft.AspNetCore.Mvc;

namespace BaiTap1_TaoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        [HttpGet("ping")]   
        public IActionResult Ping()
        {
            return Ok(new {message= "OK" });
        }

        [HttpGet("time")]
        public IActionResult GetTime()
        {
            return Ok(new { time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
        }


        
    }
}
