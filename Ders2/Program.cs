using System;

namespace Ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //do not repeat yourself
            //değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 40000;
            bool girisYapmisMi = true;
            double dolarDun = 7.40;
            double dolarBugun = 7.50;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("artış");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else
            {
                Console.WriteLine("düz");
            }



            if (girisYapmisMi == true)
            {
                Console.WriteLine("Hesabım butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            




        }
    }
}
