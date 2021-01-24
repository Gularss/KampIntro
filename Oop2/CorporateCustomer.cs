using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Tüzel Müşteri : Miras(Inheritance)
    class CorporateCustomer: Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
