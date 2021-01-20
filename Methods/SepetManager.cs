using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi: " + product.Adi + "  " + product.Fiyati + "TL");


        }
        public void Ekle2(string urunAdi, double fiyat, string aciklama)
        {
            Console.WriteLine("Sepete eklendi: " + urunAdi + "  " + fiyat + "TL");
        }
        
    }
}
