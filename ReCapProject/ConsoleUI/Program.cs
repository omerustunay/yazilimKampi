using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Araba Kiralama Sistemi - Arac Listesi");

            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car newCar = new Car()
            {
                Id = 6,
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 230,
                Description = "Audi A6",
                ModelYear = 2014
            };
            carManager.Add(newCar);

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("{0} araba modeli {1} markası {2} günlük fiyatı {3} rengi ", item.Description, item.BrandId, item.DailyPrice, item.ColorId);
            }

            var result = carManager.GetById(2);

            foreach (var item in carManager.GetById(2))
            {

                Console.WriteLine("İstenilen arac : " + item.Description);
            }

            Car newCar2 = new Car()
            {
                Id = 7,
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 230,
                Description = "Audi A8",
                ModelYear = 2019
            };
            carManager.Delete(newCar);

            carManager.Update(
                new Car { Id = 4, BrandId = 2, ColorId = 6, DailyPrice = 265, Description = "Audi a2", ModelYear = 2017 }
            );

            Console.WriteLine("Guncel arac listesi");

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("{0} araba modeli {1} markası {2} günlük fiyatı {3} rengi ", item.Description, item.BrandId, item.DailyPrice, item.ColorId);
            }
        }
    }
}
