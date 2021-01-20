using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriListesi = new List<Musteri>();
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi: "+ musteri.Adi);
           
            

            musteriListesi.Add(musteri);
            
        }
        public void Listele()
        {
            Console.WriteLine("musteri listesi : ");
            foreach(Musteri m in musteriListesi)
            {
                Console.WriteLine("musteri adi: "+ m.Adi 
                    +" musteri soyadi : "+ m.Soyadi 
                    +" musteri meslegi : "+m.Meslek);
            }
        }

        public void Sil(int Id)
        {
            musteriListesi.RemoveAt(Id);
        }
    }
}
