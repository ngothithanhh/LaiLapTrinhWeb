using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lap12_10.Models;

public partial class SanPham
{
    public int Id { get; set; }

    public string MaSanPham { get; set; } = null!;

    [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
    public string TenSanPham { get; set; } = null!;

    public string? HinhAnh { get; set; }

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public string MaLoai { get; set; } = null!;

    public bool TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual LoaiSanPham MaLoaiNavigation { get; set; } = null!;
}
