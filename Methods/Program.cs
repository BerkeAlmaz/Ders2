using System;

namespace Methods
{
    //do not repeat yourself =  DRY - Clean Code
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Araba";
            product1.Fiyati = 150000;
            product1.Aciklama = "Sahibinden satılık";
            product1.Adet = 54;
            

            Product product2 = new Product();
            product2.Adi = "Gitar";
            product2.Fiyati = 7000;
            product2.Aciklama = "Sahibinden temiz gitar";
            product2.Adet = 14;

            Product product3 = new Product();
            product3.Adi = "Pc";
            product3.Fiyati = 9000;
            product3.Aciklama = "Sahibinden 16gb ramli PC";
            product3.Adet = 141;

            Product product4 = new Product();

            Product[] products = new Product[] { product1, product2, product3 };

            //type-safe : tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------------------------");
            }

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);
            //boş product -deneme amaçlı-
            sepetManager.Ekle(product4);
            sepetManager.Ekle2("Ev", 15 , "Sahibinden ev");


        }
    }
}