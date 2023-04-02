using EF005.SetupEFCoreModel;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        var wallet = new Wallet 
        { 
            Holder="Amin",
            Balance=14000m
        };
        using (var context=new AppDbContext())
        {
            context.Wallets.Add(wallet);
            context.SaveChanges();
        }

    }
}