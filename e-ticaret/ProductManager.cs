using System;
using System.Collections.Generic;
using System.Text;

namespace e_ticaret
{
    class ProductManager
    {
        List<Product> cart = new List<Product>(); 
        public void AddToCart(Product product)
        {
            cart.Add(product);
            Console.WriteLine(product.Name + " sepete eklendi");
        }

        public void DeleteFromCart(Product product)
        {
            cart.Remove(product);
            Console.WriteLine(product.Name + "  sepetten kaldırıldı");
        }

        public void ShowCart()
        {
            int toplam = 0;
            Console.WriteLine("Sepet:");
            foreach (var i in cart)
            {
                Console.WriteLine(i.Name);
                toplam = toplam + i.Price;
            }
            Console.WriteLine("Sepet tutarı:  " + toplam + "TL");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
        }

        public void ClearCart()
        {
            cart.Clear();
        }
    }
}
