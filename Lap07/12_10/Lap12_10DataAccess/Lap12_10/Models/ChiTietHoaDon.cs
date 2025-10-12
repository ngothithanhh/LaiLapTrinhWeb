using System;
using System.Collections.Generic;

namespace Lap12_10.Models;

public partial class ChiTietHoaDon
{
    public int Id { get; set; }

    public int IdhoaDon { get; set; }

    public int SanPhamId { get; set; }

    public int SoLuongMua { get; set; }

    public decimal DonGiaMua { get; set; }

    public decimal? ThanhTien { get; set; }

    public bool TrangThai { get; set; }

    public virtual HoaDon IdhoaDonNavigation { get; set; } = null!;

    public virtual SanPham SanPham { get; set; } = null!;
}
