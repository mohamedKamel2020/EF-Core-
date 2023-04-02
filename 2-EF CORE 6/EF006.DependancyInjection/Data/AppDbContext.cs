using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF006.DependancyInjection.Entities;
    using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF006.DependancyInjection.Data
{
    public class AppDbContext:DbContext
    {
      
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Wallet> Wallets { get; set; }
    }
}
