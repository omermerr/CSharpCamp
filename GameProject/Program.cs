using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game
            {
                GameName = "Game 1 ",
                GameCategory = "Yarış",
                GamePrice = 100 
            };

            Game game2 = new Game
            {
                GameName = "Game 2",
                GameCategory = "Macera",
                GamePrice = 200
            };

            Game game3 = new Game
            {
                GameName = "Game 3 ",
                GameCategory = "Aksiyon",
                GamePrice = 300
            };

            
            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Yaz İndirimi";
            campaign1.CampaignDiscount = 50;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "Haftasonu İndirimi";
            campaign2.CampaignDiscount = 25;


        
            Gamer gamer1 = new Gamer
            {
                FirstName = "Ömer ",
                LastName = "Mermer",
                Id = 0101,
                IdentityNumber = 11231212
            };
            

            
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            
            gamerManager.Update(gamer1);

            Console.WriteLine("************************");

       
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Console.WriteLine("-------------------------");


            gameManager.Add(game2);

            Console.WriteLine("************************");

            
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Console.WriteLine("************************");

     
            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(gamer1, game1, campaign1);

            Console.WriteLine("************************");

            gameSaleManager.Sale(gamer1, game3, campaign2);






            Console.ReadLine();
        }
    }
}
