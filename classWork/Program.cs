
using System;

namespace classWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAdi = "Bilgisayar";
            product1.UrunAdet = 5;
            product1.UrunFiyati = 5000;

            Product product2 = new Product();
            product2.UrunAdi = "tv";
            product2.UrunAdet = 2;
            product2.UrunFiyati = 6000;

            Product product3 = new Product();
            product3.UrunAdi = "cep telefonu";
            product3.UrunAdet = 3;
            product3.UrunFiyati = 4000;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
           {
               Console.WriteLine(product.UrunAdi + " : " + product.UrunAdet + " : " + product.UrunFiyati);
                
           }

            for (int i = 0; i <products.Length; i++)
            {
                Console.WriteLine(products[i].UrunAdi);
            }

        }
    }


            class Product
        {
            public string UrunAdi { get; set; }
            public int UrunFiyati { get; set; }
            public int UrunAdet { get; set; }
        }
        }
    

