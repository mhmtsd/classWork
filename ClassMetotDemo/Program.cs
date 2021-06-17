using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "ahmet";
            musteri1.Soyad = "çakır";
            musteri1.Adres = "kocaeli";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "mehmet";
            musteri2.Soyad = "kaçar";
            musteri2.Adres = "bursa";

            Musteri[] musteris = new Musteri[] { musteri1, musteri2 };

            foreach (var musteriler in musteris)
            {
                Console.WriteLine(musteriler.Ad);

            }
            Console.WriteLine("------müşteri eklendi----------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("----------müşteri listeleme-------------");
            musteriManager.Listeleme(musteri1);
            musteriManager.Listeleme(musteri2);
            Console.WriteLine("----------Müşteri silindi------------");
            musteriManager.silme(musteri1);
            musteriManager.silme(musteri2);
            
            
        }
    }
}
