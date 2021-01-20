using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Kalem";
            product1.UnitPrice = 150;
            product1.UnitsInStock = 10;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 23, ProductName = "Kol", UnitPrice = 450};

            //PascalCase   //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            //int, double, bool... değer tip
            //diziler, class, abstract class, interface... referans tip

            
        }
    }
}
