using ODEV5.Concerete;
using ODEV5.Entities;
using System;

namespace ODEV5
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer() { FirstName = "Umut", LastName = "Duman", TcNo = "12345", BirthDay = 1999 };


            Game game1 = new Game() { GameId = 2, GameName = "PUBG", GamePrice = 650 };
            Game game2 = new Game() { GameId = 3, GameName = "FORTNİTE", GamePrice = 450 };
            Game game3 = new Game() { GameId = 4, GameName = "GTA 5", GamePrice = 550 };


            Campaign campaign1 = new Campaign() { CampaignName = "YENİ ÜYE KAMPANYASI", DiscountRate = 30, CampaignId = 1 };
            Campaign campaign2 = new Campaign() { CampaignName = "COVİD-19 KAMPANYASI", DiscountRate = 35, CampaignId = 2 };


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game3,gamer1);
            salesManager.CampaignSales(game2, gamer1, campaign2);

        }
    }

}
