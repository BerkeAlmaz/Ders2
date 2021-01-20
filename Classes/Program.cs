using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Berke";
            int yas = 16;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin Abim";
            kurs1.IzlenmeOrani = 45;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Kemir Abim";
            kurs2.IzlenmeOrani = 47;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.KursEgitmeni = "birke Abim";
            kurs3.IzlenmeOrani = 95;

            //tekli yazım
            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmeni + "  %" + kurs.IzlenmeOrani);
            }


        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
} 
 
