using System;
using System.Collections.Generic;
using System.Text;

namespace CT2
{
    public class CustomerPayment : Payment
    {
        public string transactionId;
        public string paymentDateAndTime;
        public string paymentGateway;
        public string shippingCharges;
        public string cashOnDelivery;

        public CustomerPayment(string transactionId, string paymentDateAndTime, string paymentGateway, string shippingCharges, string cashOnDelivery)
        {
            this.transactionId = transactionId;
            this.paymentDateAndTime = paymentDateAndTime;
            this.paymentGateway = paymentGateway;
            this.shippingCharges = shippingCharges;
            this.cashOnDelivery = cashOnDelivery;
        }

        public override void PaymentMode()
        {
            Console.WriteLine("The Payment Mode : " + paymentGateway);
        }

    }
}
