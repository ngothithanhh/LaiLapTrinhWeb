using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        public int MaSanPham { get; set; }
        [Required(ErrorMessage ="Nhap ten san pham")]
        public string TenSanPham { get; set; }
        public string? HinhAnh { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        [ForeignKey("LoaiSanPham")]
        public int MaLoai { get; set; }
        public virtual LoaiSanPham? LoaiSanPham { get; set; }
    }
}
