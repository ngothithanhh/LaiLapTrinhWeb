using System.ComponentModel.DataAnnotations;

namespace day06Annotation.Models
{
    public class User
    {
        [Required(ErrorMessage = "Ban chua nhap Id")]
        public long Id { get; set; }

        //[RegularExpression]

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Tai khoan toi thieu 5 ki tu, toi da 50 ki tu")]
        [Required(ErrorMessage = "Ban chua nhap Name")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Chua nhap Pass")]
        public string Password { get; set; }
        
        public string ConfirmPassword { get; set; }

        public int Age { get; set; }
        public string Email { get; set; }
    }
}
