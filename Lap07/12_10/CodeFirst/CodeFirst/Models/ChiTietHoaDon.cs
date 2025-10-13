using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("ChiTietHoaDon")]
    public class ChiTietHoaDon
    {
       
        public int Id { get; set; }
        public int HoaDonId { get; set; }
        public int MaSanPhamId { get; set; }
        public int SoLuongMua { get; set; }
        public float DonGiaMua { get; set; }
        public float ThanhTien { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
        public virtual SanPham? SanPham { get; set; }
    }
}
