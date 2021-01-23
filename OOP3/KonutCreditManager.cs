using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutCreditManager : ICreditManager
    {
        public void Calculate()
        {
            //hesapla
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı.");
        }

        public void DoNothing()
        {
            throw new NotImplementedException();
        }
    }
}
