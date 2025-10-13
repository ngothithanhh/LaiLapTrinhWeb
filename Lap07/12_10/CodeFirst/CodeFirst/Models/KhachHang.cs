using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string MaKhachHang { get; set; }
        public string HoTenKhachHang { get; set; }
        public string Email { get; set; }

        public string MatKhau { get; set; }
       
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        [Column(TypeName = "date")]
        public DateTime NgayDangKy { get; set; }

        [Column(TypeName = "bit")]
        public bool TrangThai { get; set; }

        public virtual ICollection<HoaDon>? HoaDons { get; set; }
    }
}
