using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Manager
{
    public class GameProductManager : IGameProductService
    {
        public void Add(GameProduct gamerProduct)
        {
            Console.WriteLine(gamerProduct.GameName+" Adlı oyun eklendi.");
        }

        public void Delete(GameProduct gamerProduct)
        {
            Console.WriteLine(gamerProduct.GameName + " Adlı oyun silindi.");
        }

        public void Update(GameProduct gamerProduct)
        {
            Console.WriteLine(gamerProduct.GameName + " Adlı oyun güncellendi.");
        }
    }
}
