using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NgoThiThanh_231230902_temp2.Models;

public partial class HangHoa
{
    public int MaHang { get; set; }

    public int MaLoai { get; set; }

    public string TenHang { get; set; } = null!;

    [Range(100,5000, ErrorMessage = "Gia phai trong khoang 100 den 5000")]
    public decimal? Gia { get; set; }

    [RegularExpression(@".*\.(jpg|jpeg|png|gift|webp)$", ErrorMessage = "Chỉ chấp nhận file ảnh: .jpg, .jpeg, .png, .gif")]
    public string? Anh { get; set; }

    public virtual LoaiHang? MaLoaiNavigation { get; set; } = null!;
}
