using GameProject;
using GameProject;

internal class Program
{
    private static void Main(string[] args)
    {
        GamerManager gamerManager = new GamerManager(new UserValidationManager());
        gamerManager.Add(new Gamer 
            { Id = 1,
            BirthYear = 1985,
            FirstName = "Abdullah",
            LastName = "Fındık",
            IdentityNumber = 153135 });
        OrderManager orderManager = new OrderManager(new BirthdayCampaignManager());
        orderManager.Buy(new Game { GameId = 1, GameName = "Valorant", GamePrice = 100 }, new Gamer
        {
            Id = 1,
            BirthYear = 1985,
            FirstName = "Abdullah",
            LastName = "Fındık",
            IdentityNumber = 153135
        });
    }
}