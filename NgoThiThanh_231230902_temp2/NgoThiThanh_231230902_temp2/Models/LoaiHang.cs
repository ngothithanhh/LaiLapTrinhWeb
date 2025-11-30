using System;
using System.Collections.Generic;

namespace NgoThiThanh_231230902_temp2.Models;

public partial class LoaiHang
{
    public int MaLoai { get; set; }

    public string TenLoai { get; set; } = null!;

    public virtual ICollection<HangHoa>? HangHoas { get; set; } = new List<HangHoa>();
}
