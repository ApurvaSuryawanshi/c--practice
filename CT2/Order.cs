using System;
using System.Collections.Generic;
using System.Text;

namespace CT2
{
    public abstract class Order
    {
        public abstract void BuyerType();

        public void ProductName()
        {
            Console.WriteLine("The product name is Watches");
        }
    }
}
