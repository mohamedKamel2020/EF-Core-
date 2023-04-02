
using EF006.DbContextLifeTime.Data;
using EF006.DbContextLifeTime.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

internal class Program
{
    private static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var connectionString = config.GetSection("constr").Value;
        var optionsBuilder = new DbContextOptionsBuilder();
        optionsBuilder.UseSqlServer(connectionString)
            .LogTo(Console.WriteLine, LogLevel.Information);
       var options=optionsBuilder.Options;
        
        using (var context=new AppDbContext(options))
        {

            var w1 = new Wallet { Holder = "Eman", Balance = 1000m };
            context.Wallets.Add(w1);
            var w2 = new Wallet { Holder = "Khalifa", Balance = 2000m };
            context.Wallets.Add(w2);

            context.SaveChanges();
        }
        Console.ReadKey();
    }
}