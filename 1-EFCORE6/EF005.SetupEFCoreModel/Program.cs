using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        var configuration= new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var constr = configuration.GetSection("constr").Value;
        Console.WriteLine(constr);
        Console.ReadLine(); 
    }
}