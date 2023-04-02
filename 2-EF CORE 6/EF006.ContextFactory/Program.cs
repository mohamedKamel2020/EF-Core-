
using EF006.ContextFactory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var connectionString = config.GetSection("constr").Value;
        var services = new ServiceCollection();
        
        services.AddDbContextFactory<AppDbContext>(options =>options.UseSqlServer(connectionString));
        IServiceProvider serviceProvider = services.BuildServiceProvider();
        
        var contextFactory=serviceProvider
            .GetService<IDbContextFactory<AppDbContext>>();
        
        using (var context=contextFactory!.CreateDbContext())
        {
            foreach (var wallet in context!.Wallets)
            {
                Console.WriteLine(wallet);
            }
        }   
    }
}