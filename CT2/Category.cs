using System;
using System.Collections.Generic;
using System.Text;

namespace CT2
{
    public class Category : Order
    {
        public string customerCategory;
        public string buyerType;
        public string pricing;
        public string location;
        public string accountStatus;

        public Category(string customerCategory, string buyerType, string pricing, string location, string accountStatus)
        {
         this.customerCategory = customerCategory;
         this.buyerType = buyerType;
         this.pricing = pricing;
         this.location = location;
         this.accountStatus = accountStatus;
        }

        public override void BuyerType()
        {
            Console.WriteLine("Buyer type is : " + buyerType);
        }
    }
}
