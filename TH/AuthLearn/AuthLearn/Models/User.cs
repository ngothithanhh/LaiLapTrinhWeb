

using System.ComponentModel.DataAnnotations;

namespace AuthLearn.Models;

public class User
{
    [Key]
    public string UserID { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    [EmailAddress(ErrorMessage ="Sai định dạng email")]
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty; // Sau hash
    public string? PhoneNumber { get; set; }
    public string? Gender { get; set; }
    public DateTime? Birthday { get; set; }

    public void HashPassword()
    {
        // Sử dụng BCrypt để hash mật khẩu
        Password = BCrypt.Net.BCrypt.HashPassword(Password);
    }

    public bool VerifyPassword(string password)
    {
        return BCrypt.Net.BCrypt.Verify(password, Password);
    }
}