using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface ICampaignService
    {
        void DiscountSales(Campaign campaign, GameProduct gameProduct, Gamer gamer);
    }
}
