using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string MaHoaDon { get; set; }

        public int MaKhachHang { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayHoaDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhan { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string HoTenKhachHang { get; set; }
        public string ?email { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }

        public float TongTriGia { get; set; }
        [Column(TypeName = "bit")]
        public bool TrangThai { get; set; }

        public virtual KhachHang?KhachHang { get; set; }
        public virtual ICollection<ChiTietHoaDon>? ChiTietHoaDons { get; set; }
    }
}
