
using EF006.DbContextPool.Data;
using EF006.DbContextPool.Entities;
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
        var services = new ServiceCollection();
        services.AddDbContextPool<AppDbContext>(options=>
        options.UseSqlServer(connectionString));
        IServiceProvider serviceProvider = services.BuildServiceProvider();

        using (var context=serviceProvider.GetService<AppDbContext>())
        {

            foreach(var wallet in context!.Wallets)
            {
                Console.WriteLine(wallet);
            }
        }
        Console.ReadKey();
    }
}