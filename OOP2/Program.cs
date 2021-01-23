using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Individual Customer Berke
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNo = "123456";
            customer1.Id = 1;
            customer1.FirstName = "Berke";
            customer1.LastName = "Almaz";
            customer1.TcNo = "11111111111";


            //CoorporateCustomer kodlama.io
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "123";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1010102101";



            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
