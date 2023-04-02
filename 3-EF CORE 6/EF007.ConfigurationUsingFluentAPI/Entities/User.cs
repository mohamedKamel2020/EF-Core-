namespace EF007.ConfigurationUsingFluentAPI.Entities
{
    public class User
    {
        // Primary key convention [Id, id , ID] , [{Class}Id]
        public int UserId { get; set; }
        public string Username { get; set; }
    }
}
