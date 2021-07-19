using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameSaleManager : Abstract.IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaigns campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName + " " + gamer.LastName + " kişisine satıldı!" );
            Console.WriteLine("Oyunun indirimli fiyatı : " + newPrice + " TL ");
            Console.WriteLine("Uygulanan indirim fiyatı : " + game.GamePrice * (campaign.CampaignDiscount/100) + " TL");
        }
    }
}
