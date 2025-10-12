using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lap12_10.Models;

public partial class QuanTri
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập tài khoản")]
    public string TaiKhoan { get; set; } = null!;
    [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
    public string MatKhau { get; set; } = null!;

    public bool TrangThai { get; set; }
}
