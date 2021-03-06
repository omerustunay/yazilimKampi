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


            //// renk ekleme islemi
            ///
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //Color newColor = new Color()
            //{
            //    ColorName = "kırmızı"
            //};

            //colorManager.Add(newColor);

            //// Marka ekleme islemi
            ///
            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //Brand newBrand = new Brand()
            //{
            //    BrandName = "bmw"
            //};

            //brandManager.Add(newBrand);

            CarManager carManager = new CarManager(new EfCarDal());

            Car newCar = new Car()
            {
                BrandId=2,
                ColorId=1,
                DailyPrice = 300,
                Description = "tucson",
                ModelYear = 2014
            };
            carManager.Add(newCar);


        }
    }
}
