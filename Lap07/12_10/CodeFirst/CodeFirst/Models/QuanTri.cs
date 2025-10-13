using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("QuanTri")]
    public class QuanTri
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Tai khoan khong duoc de trong")]
        public string TaiKhoan { get; set; }
        [Required(ErrorMessage ="Mat khau khong duoc de trong")]
        [MinLength(3,ErrorMessage ="Mat khau toi thieu 3 ky tu")]
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
    }
}
