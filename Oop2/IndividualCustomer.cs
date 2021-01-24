
using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Gerçek Müşteri : Miras(Inheritance)
    class IndividualCustomer :Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNumber { get; set; }
    }
}
