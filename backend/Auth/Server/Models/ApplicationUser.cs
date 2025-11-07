using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public string? PhoneNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage ="Name must be provided")]
        [StringLength(255)]
        public string FullName { get; set; }

        public string? ImageUrl { get; set; }
    }
}
