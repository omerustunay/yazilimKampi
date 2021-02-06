using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Bussines
{
    public class OrderManager : IOrderService
    {
        public void Sales(Gamer gamer, GameProduct gameProduct)
        {
            Console.WriteLine(gamer.FistName + " adlı oyuncu "+
                gameProduct.GamePrice + " fiyatına " +
                gameProduct.GameName + " oyununu satın aldı.");
        }
    }
}
