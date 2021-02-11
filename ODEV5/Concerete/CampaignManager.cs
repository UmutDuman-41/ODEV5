using ODEV5.Abstract;
using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Concerete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya EKLENDİ : " + campaign.CampaignName + " " + campaign.DiscountRate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi : " + campaign.CampaignName + " " + campaign.DiscountRate);
        }
    }
}
