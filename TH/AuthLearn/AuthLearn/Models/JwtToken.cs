namespace AuthLearn.Models
{
    public class JwtToken
    {
        public string Token { get; set; } = string.Empty;
        public User User { get; set; } = new User();
    }
}
