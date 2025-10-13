using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("LoaiSanPham")]
    public class LoaiSanPham
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public virtual ICollection<SanPham>? SanPhams { get; set; }
    }
}
