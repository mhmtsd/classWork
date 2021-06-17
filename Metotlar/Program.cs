using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Adi = "elma";
            product1.Fiyati = 5;
            product1.Aciklama = "deneme";

            Product product2 = new Product();
            product2.Adi = "karpuz";
            product2.Fiyati = 5;
            product2.Aciklama = "deneme";
            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("----------metotlar---------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            

        }
    }
}
