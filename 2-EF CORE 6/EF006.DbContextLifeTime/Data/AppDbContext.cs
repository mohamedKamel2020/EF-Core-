using EF006.DbContextLifeTime.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF006.DbContextLifeTime.Data
{
    public class AppDbContext:DbContext
    {
      
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Wallet> Wallets { get; set; }
    }
}
