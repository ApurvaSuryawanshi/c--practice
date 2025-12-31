using System;
using System.Collections.Generic;
using System.Text;

namespace CT2
{
    public class CustomerOrder : IOrder
    {
        public int orderId;
        public string productName;
        public string paymentMethod;
        public string shippingAddress;
        public long mobileNumber;
        public string refundMode;

        public CustomerOrder(int orderId, string productName,string paymentMethod,string shippingAddress,long mobileNumber,string refundMode)
        {
            this.orderId = orderId;
            this.productName = productName;
            this.paymentMethod = paymentMethod;
            this.shippingAddress = shippingAddress;
            this.mobileNumber = mobileNumber;
            this.refundMode = refundMode;
        }

        public void RefundMode()
        {
            Console.WriteLine("The RefundMode is : BankTransfer");
        }

        public void CancelOrder()
        {
            Console.WriteLine("The order is cancelled");
        }
    }
}
