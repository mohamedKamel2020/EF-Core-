using EF005.SetupEFCoreModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("All Data");
        using (var context = new AppDbContext())
        {
            var wallet = context.Wallets.Single(x => x.Id == 1010);
            wallet.Id = 16;
            var wallets = context.Wallets.Single(x => x.Id == 1011);
            wallets.Id = 17;
            context.SaveChanges();
        }
        //////////////////////////
        Console.WriteLine("Single item");
        Console.WriteLine("Enter Id");
       
        var itemId=Convert.ToInt32(Console.ReadLine());
        using (var appContext=new AppDbContext() )
        {
            var item = appContext
                .Wallets
                .FirstOrDefault(x => x.Id == itemId);
            Console.WriteLine(item);

        }
        Console.ReadKey();
    }
}