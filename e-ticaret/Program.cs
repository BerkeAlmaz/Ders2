using System;
using System.Collections.Generic;

namespace e_ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { Id = 1, Name = "Araba", Price = 300000, Stock = 41 };
            Product product2 = new Product { Id = 2, Name = "Masa", Price = 500, Stock = 100 };
            Product product3 = new Product { Id = 3, Name = "Gitar", Price = 7500, Stock = 12 };

            ProductManager productManager = new ProductManager();
            productManager.AddToCart(product1);
            productManager.AddToCart(product3);
            productManager.ShowCart();
            productManager.AddToCart(product2);
            productManager.DeleteFromCart(product1);
            productManager.ShowCart();
            productManager.ClearCart();
            productManager.ShowCart();
        }
    }
}
