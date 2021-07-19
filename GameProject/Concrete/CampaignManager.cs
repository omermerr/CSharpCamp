using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası eklendi!");
            Console.WriteLine("Kampanya indirimi: % " + campaign.CampaignDiscount);
        }

        public void Delete(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya silindi!");
        }

        public void Update(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası güncellendi!");
            Console.WriteLine("Güncel kampanya indirimi: % " + campaign.CampaignDiscount);
        }
    }
}
