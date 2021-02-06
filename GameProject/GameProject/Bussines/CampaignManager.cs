using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Bussines
{
    public class CampaignManager : ICampaignService
    {
    
        public void DiscountSales(Campaign campaign, GameProduct gameProduct, Gamer gamer)
        {
            if (gameProduct.AnyDiscount)
                Console.WriteLine("{0} adlı oyuncu {1} oyununu yuzde {2} indirimle {3} fiyata aldı." , gamer.FistName, gameProduct.GameName, campaign.DiscountRate , (gameProduct.GamePrice * (100 - campaign.DiscountRate) / 100));
            else
                Console.WriteLine("İndirimsiz ürün satın alındı.");
        }
    }
}
