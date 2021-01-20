using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //array : dizi
            string[] kurslar = new string[] { "Java", "Python", "C#", "C++"};


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Kurslar sonu");

            //örnek
            string[] ilanlar = new string[] {"Araba", "Ev", "Arsa", "Hayat", "Motosiklet" };

            for (int i = 0; i <ilanlar.Length; i++)
            {
                Console.WriteLine(ilanlar[i]);
            }
            Console.WriteLine("İlanlar sonu");

            //farklı döngü -dizilere özel-
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Kursların sonu");
        }
    }
}
