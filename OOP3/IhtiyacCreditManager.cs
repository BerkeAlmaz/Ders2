using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacCreditManager : ICreditManager
    {
        public void Calculate()
        {
            //hesapla
            Console.WriteLine("İhtiyaç Kredisi ödeme planı hesaplandı.");
        }

        public void DoNothing()
        {
            throw new NotImplementedException();
        }
    }
}
