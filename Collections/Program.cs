using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Berke", "Burxu", "Kuzmir" };
            //Console.WriteLine(isimler[0]);
            //isimler[4] = "x";
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string> { "Engin", "Berke", "Burxu", "Kuzmir" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Kerikuzi");
            Console.WriteLine(isimler2[4]);
            
        }
    }
}
