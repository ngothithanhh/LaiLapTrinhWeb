using BaiTap2_Struct.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTap2_Struct.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
