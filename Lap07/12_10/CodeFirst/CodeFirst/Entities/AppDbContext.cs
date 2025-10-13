using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Entities
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<QuanTri> QuanTris { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<CodeFirst.Models.KhachHang> KhachHang { get; set; } = default!;
    }
}
