using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTTDay09CodeFirst.Models
{
    [Table("ntt_SanPham")]
    public class ntt_SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long nttId { get; set; }
        [Display(Name = "Mã sản phẩm")]
        [StringLength(10)]
        public string nttMaSP { get; set; }
        [Display(Name = "Tên sản phẩm")]
        [StringLength(100)]
        public string nttTenSP { get; set; }
        [Display(Name = "Hình ảnh")]
        [StringLength(200)]
        public string nttHinhAnh { get; set; }
        [Display(Name = "Số lượng")]
        public int nttSoLuong { get; set; }
        [Display(Name = "Đơn giá")]

        public decimal nttDonGia { get; set; }
        public long nttLoaiSPId { get; set; }

        public ntt_LoaiSanPham nttLoai_SP { get; set; }

    }
}
