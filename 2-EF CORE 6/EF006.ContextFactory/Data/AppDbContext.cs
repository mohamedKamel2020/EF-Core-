using EF006.ContextFactory.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF006.ContextFactory.Data
{
    public class AppDbContext:DbContext
    {
      
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Wallet> Wallets { get; set; }
    }
}
