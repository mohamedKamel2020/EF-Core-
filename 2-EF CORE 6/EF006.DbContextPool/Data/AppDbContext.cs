using EF006.DbContextPool.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF006.DbContextPool.Data
{
    public class AppDbContext:DbContext
    {
      
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Wallet> Wallets { get; set; }
    }
}
