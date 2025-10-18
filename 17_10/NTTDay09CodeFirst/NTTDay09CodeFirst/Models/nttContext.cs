using Microsoft.EntityFrameworkCore;

namespace NTTDay09CodeFirst.Models
{
    public class nttContext:DbContext
    {
        public nttContext(DbContextOptions<nttContext> options):base(options) 
        {

        }
        public DbSet<ntt_LoaiSanPham> ntt_LoaiSanPhams { get; set; }
        public DbSet<ntt_SanPham> ntt_SanPhams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ntt_LoaiSanPham>()
                .HasKey(l => l.nttId);

            modelBuilder.Entity<ntt_LoaiSanPham>()
                .HasAlternateKey(l => l.nttMaLoai);

            //mapping FK
            modelBuilder.Entity<ntt_SanPham>()
                .HasOne(sp => sp.nttLoai_SP)
                .WithMany(l => l.nttSanPhams)
                .HasForeignKey(sp => sp.nttLoaiSPId)
                .HasPrincipalKey(l => l.nttMaLoai);
        }
    }

}
