using EF007.ConfigurationUsingGroupingConfiguration.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context=new AppDbContext())
        {
            Console.WriteLine("-------User----------");
            Console.WriteLine();
            foreach (var user in context.Users)
            {
                Console.WriteLine(user.Username);
            }
            Console.WriteLine();
            Console.WriteLine("-------Tweets---------");
            Console.WriteLine();
            foreach (var tweets in context.Tweets)
            {
                Console.WriteLine(tweets.TweetText);
            }
            Console.WriteLine();
            Console.WriteLine("--------Comments-------");
            Console.WriteLine();
            foreach (var comment in context.Comments)
            {
                Console.WriteLine(comment.CommentText);
            }
        }
    }
}