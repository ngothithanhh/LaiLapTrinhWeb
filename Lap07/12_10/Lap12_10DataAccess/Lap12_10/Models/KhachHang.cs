using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lap12_10.Models;

public partial class KhachHang
{
    public int Id { get; set; }

    public int MaKhachHang { get; set; }

    [Required(ErrorMessage = "Họ tên khách hàng không được để trống")]
    public string HoTenKhachHang { get; set; } = null!;
    [Required(ErrorMessage = "Email không được để trống")]
    [EmailAddress(ErrorMessage ="Email không hợp lệ")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
    public string MatKhau { get; set; } = null!;
    [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
    public string DienThoai { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public DateOnly NgayDangKy { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
