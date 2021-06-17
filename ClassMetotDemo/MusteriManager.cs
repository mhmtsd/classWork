using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) {
        Console.WriteLine("Müşteri eklendi : " + musteri.Ad+"  "+musteri.Soyad+"  "+musteri.Adres);
            }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi: "+ musteri.Id+" "+musteri.Ad+" "+musteri.Soyad+" "+musteri.Adres);
        }
        public void silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: "+musteri.Ad+" "+musteri.Soyad+" "+musteri.Adres);
        }
    }
}
