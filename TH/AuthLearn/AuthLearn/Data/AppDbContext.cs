using AuthLearn.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthLearn.Data
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=auth.db"); // File DB local
        }
        public DbSet<User> Users { get; set; }
    }
}
