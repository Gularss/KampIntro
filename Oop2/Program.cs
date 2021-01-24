using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer() { Id = 1, CustomerId = "1234", Name = "Gülden", Surname = "Sönmez", TcNumber = "12345678900" };
            CorporateCustomer customer2 = new CorporateCustomer() { Id = 2, CustomerId = "2345", TaxNumber = "111111", CompanyName = "Casper" };

            CustomerManager customerManager = new CustomerManager();
        }
    }
}
