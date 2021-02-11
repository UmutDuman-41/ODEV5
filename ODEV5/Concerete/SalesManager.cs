using ODEV5.Abstract;
using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Concerete
{
    class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + "Bey" +campaign.CampaignName + "ile" + game.GameName + "Oyununu Satın Aldı.");
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + game.GameName + "Oyununu Satın Aldı." );
        }
    }
}
