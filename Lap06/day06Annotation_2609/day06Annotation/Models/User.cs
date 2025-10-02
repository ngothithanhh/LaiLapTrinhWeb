using System.ComponentModel;
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
        [DisplayName("UserName")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Chua nhap Pass")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Mat khau toi thieu 8 ki tu, toi da 16 ki tu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Chua nhap Pass")]
        [Compare("Password", ErrorMessage = "Sai mat khau")]
        [DisplayName("Re-enter Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Ban chua nhap Tuoi")]
        [Range(18, 60, ErrorMessage = "Tuoi tu 18 den 60.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Ban chua nhap Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage = "Email dinh dang sai.")]
        [DisplayName("Email-ID")]
        public string Email { get; set; }
    }
}
