using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTTDay09CodeFirst.Models
{
    [Table("ntt_LoaiSanPham")]
    //[index(nameof(nttMaLoai))]
    public class ntt_LoaiSanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long nttId { get; set; }
        [Display(Name = "Mã loại")]
        [StringLength(10)]
        public string nttMaLoai { get; set; }
        [Display(Name = "Tên loại sản phẩm")]
        [StringLength(100)]
        public string nttTenLoai { get; set; }
        [Display(Name = "Trạng thái")]
        public bool nttTrangThai { get; set; }

        public ICollection<ntt_SanPham> nttSanPhams { get; set; }
    }
}
