using System;
using System.Collections.Generic;

namespace Lap12_10.Models;

public partial class HoaDon
{
    public int Id { get; set; }

    public string MaHoaDon { get; set; } = null!;

    public int MaKhachHang { get; set; }

    public DateOnly NgayHoaDon { get; set; }

    public DateOnly? NgayNhan { get; set; }

    public string HoTenKhachHang { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string DienThoai { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public decimal TongTienGia { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;
}
