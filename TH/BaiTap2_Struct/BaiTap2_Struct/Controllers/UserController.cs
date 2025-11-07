using BaiTap2_Struct.Data;
using BaiTap2_Struct.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap2_Struct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest(new {message="Invalid user data"});
            }

            //Check trung username
            var existingUser = _context.Users.FirstOrDefault(u => u.Username == user.Username);
            if (existingUser != null)
            {
                return Conflict(new { message = "Username already exists" });
            }

            //set time tao
            user.CreatedAt = DateTime.Now;

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(new { message = "User registered successfully", userId = user.Id } );
        }
    }
}
