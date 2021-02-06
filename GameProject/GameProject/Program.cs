using System;
using GameProject.Abstract;
using GameProject.Bussines;
using GameProject.Entities;
using GameProject.Manager;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {


            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FistName = "Omer",
                LastName = "Ustunay",
                MyBirthDayYear = 1990,
                IdentityNumber = "23653"
            };
            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                FistName = "ahmet",
                LastName = "komur",
                MyBirthDayYear = 1980,
                IdentityNumber = "23654"
            };
            GamerManager gamerManager = new GamerManager(new UserValidationManager());

            gamerManager.Add(gamer1);


            GameProduct gameProduct = new GameProduct(){ 
                Id = 1,
                GameName = "lol",
                GamePrice = 94.32,
                AnyDiscount = true
            };
            GameProduct gameProduct2 = new GameProduct()
            {
                Id = 2,
                GameName = "cs",
                GamePrice = 94.32,
                AnyDiscount = false
            };
            GameProduct gameProduct3 = new GameProduct()
            {
                Id = 3,
                GameName = "pes2013",
                GamePrice = 94.32,
                AnyDiscount = true
            };


            IGameProductService gameProductService = new GameProductManager();

            gameProductService.Add(gameProduct);
            gameProductService.Add(gameProduct2);
            gameProductService.Add(gameProduct3);


            IOrderService order = new OrderManager();
            order.Sales(gamer1, gameProduct3);


            Campaign camp1 = new Campaign()
            {
                Id=1,
                CampaignName ="Subat Ayı Indirimleri",
                DiscountRate = 8
            };

            ICampaignService campaignService = new CampaignManager();
            campaignService.DiscountSales(camp1, gameProduct, gamer1);
            campaignService.DiscountSales(camp1, gameProduct2, gamer2);



                
        }
    }
}
