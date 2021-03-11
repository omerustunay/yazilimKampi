using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Araba Kiralama Sistemi - Arac Listesi");


            //// renk islemi
            //ColorTest();

            //// Marka islemi
            //BrandTest();

            //// Araba işlemleri
            CarTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Brand newBrand = new Brand()
            {
                BrandName = "bmw"
            };

            brandManager.Add(newBrand);

            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine("brand is : " + item.BrandName);
            }


            foreach (var item in brandManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("two id brand is : " + item.BrandName);
            }

            brandManager.Delete(new Brand { Id = 3 });
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Color newColor = new Color()
            {
                ColorName = "kırmızı"
            };

            colorManager.Add(newColor);

            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine("color is : " + item.ColorName);
            }

            foreach (var item in colorManager.GetCarsByColorId(1))
            {
                Console.WriteLine("one id color is : " + item.ColorName);
            }
            colorManager.Delete(new Color { Id = 3 });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //Car newCar = new Car()
            //{
            //    BrandId = 2,
            //    ColorId = 1,
            //    DailyPrice = 300,
            //    Description = "c5",
            //    ModelYear = 2014
            //};
            //carManager.Add(newCar);


            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.BrandName + "-" + item.ColorName + "-" +
                    item.DailyPrice + "-" + item.ModelYear+"-"+ item.Description);
            }
        }
    }
}
