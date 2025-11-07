using Microsoft.EntityFrameworkCore;
using NetCoreLAB6_EF.Models;

namespace NetCoreLAB6_EF.Entities
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        { 
        
        }
        //Khai báo các DbSet tương ứng với các bảng trong CSDL
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<NetCoreLAB6_EF.Models.Banner> Banner { get; set; } = default!;
    }
}
