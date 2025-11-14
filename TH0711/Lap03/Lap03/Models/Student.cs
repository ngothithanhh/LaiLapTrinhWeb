using Lap03.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;

namespace Lap03.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ và tên là bắt buộc")]
        [Display(Name = "Họ và tên")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ và tên phải từ 4 đến 100 ký tự")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$",
            ErrorMessage = "Email phải có đuôi @gmail.com")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải từ 8 đến 100 ký tự")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
            ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn khoa")]
        [Display(Name = "Khoa")]
        public Branch? Branch { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        [Display(Name = "Giới tính")]
        public Gender? Gender { get; set; }

        [Display(Name = "Hệ đào tạo")]
        public bool IsRegular { get; set; } // true = Chính quy, false = Liên thông

        [Required(ErrorMessage = "Địa chỉ là bắt buộc")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Ngày sinh là bắt buộc")]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        [CustomValidation(typeof(Student), nameof(ValidateDateOfBirth))]
        public DateTime DateOfBirth { get; set; }

        // Thêm method này vào class Student
        public static ValidationResult? ValidateDateOfBirth(DateTime date, ValidationContext context)
        {
            var min = new DateTime(1963, 1, 1);
            var max = new DateTime(2005, 12, 31);

            if (date.Date < min || date.Date > max)
            {
                return new ValidationResult("Ngày sinh phải từ 01/01/1963 đến 31/12/2005");
            }
            return ValidationResult.Success;
        }

        [Required(ErrorMessage = "Điểm là bắt buộc")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải từ 0.0 đến 10.0")]
        [Display(Name = "Điểm trung bình")]
        public double Score { get; set; }

    }
}