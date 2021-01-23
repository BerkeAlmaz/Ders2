using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitCreditManager : ICreditManager
    {
        public void Calculate()
        {
            //hesapla
            Console.WriteLine("Taşıt Kredisi ödeme planı hesaplandı.");
        }

        public void DoNothing()
        {
            throw new NotImplementedException();
        }
    }
}
