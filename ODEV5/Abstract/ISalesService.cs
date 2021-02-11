using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Abstract
{
    interface ISalesService
    {
        void Sales(Game game,Gamer gamer);
        void CampaignSales(Game game, Gamer gamer,Campaign campaign);
    }
}
