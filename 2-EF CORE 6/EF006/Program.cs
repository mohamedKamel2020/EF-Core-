using EF006.InternalConfiguration.Data;

internal class Program
{
    private static void Main(string[] args)
    {
     using(var context=new AppDbContext())
        {
            foreach (var wallet in context.Wallets)
            {
                Console.WriteLine(wallet);
            }
        }   
    }
}