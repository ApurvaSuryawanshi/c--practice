using System;
using System.Collections.Generic;
using System.Text;

namespace CT2
{
    

    public class Payment
    {
        public virtual void PaymentMode()
        {
            Console.WriteLine("The Payment Gateway is Generic ");
        }

        public void PaymentMode(string payment)
        {
            Console.WriteLine("The payment gateway is : " + payment);
        }
    }
}
