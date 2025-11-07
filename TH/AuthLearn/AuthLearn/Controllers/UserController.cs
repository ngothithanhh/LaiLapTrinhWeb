using AuthLearn.Data;
using AuthLearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;
    

    public UserController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<User>> Get()
    {
        return await _context.Users.ToListAsync();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] User user)
    {
        if (await _context.Users.AnyAsync(u => u.Email == user.Email))
            return Conflict("Email exists");

        user.HashPassword();

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = user.UserID }, user);
    }
    //Xóa user theo ID
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
            return NotFound($"Không tìm thấy người dùng có ID{id}");
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    //Lấy user theo ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
            return NotFound($"Không tìm thấy người dùng có ID{id}");
        return Ok(user);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] User login)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == login.Email);
        if (user == null || !user.VerifyPassword(login.Password))
            return Unauthorized("Invalid credentials");
        return Ok("Login successful");
    }
}