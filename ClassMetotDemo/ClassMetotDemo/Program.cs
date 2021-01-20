using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("baslayalim");

            Musteri m1 = new Musteri();
            m1.Adi = "john";
            m1.Soyadi = "wick";
            m1.Meslek = "muhendis";


            Musteri m2 = new Musteri();
            m2.Adi = "clara";
            m2.Soyadi = "cena";
            m2.Meslek = "mimar";
            
            Musteri m3 = new Musteri();
            m3.Adi = "edison";
            m3.Soyadi = "karl";
            m3.Meslek = "doktor";


            MusteriManager manager = new MusteriManager();
            manager.Ekle(m1);
            manager.Ekle(m2);
            manager.Ekle(m3);

            manager.Listele();

            manager.Sil(1);

            manager.Listele();
        }
    }
}
