using CT2;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using static CT2.Cust;


namespace ProgMain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cust c = new Cust("Apurva","Pune","India","Maggi@123");
            Console.WriteLine("My name is {0} ",c.name);
            Console.WriteLine("My city is {0} ",c.city);
            Console.WriteLine("My country is {0} ",c.country);
            Console.WriteLine("My password is {0} " , c.password);

            Console.WriteLine(c.Display());

            Console.WriteLine("===============================================");

            Category cs = new Category("Registered","RepeatBuyer","Regular","Pune","Active");
            Console.WriteLine("CustomerCategory : {0}" ,cs.customerCategory);
            Console.WriteLine("BuyerType : {0}", cs.buyerType);
            Console.WriteLine("Pricing : {0}", cs.pricing);
            Console.WriteLine("Location : {0}", cs.location);
            Console.WriteLine("Account Staus : {0}", cs.accountStatus);

            Console.WriteLine("==================================================");

            CustomerDetails customerDetails = new CustomerDetails("Apurva","Morewadi",8806250349,"xyz@gmail.com","Returning Customer","Female","Cust@123","20/3/2000");
            CustomerDetails customerDetails1 = new CustomerDetails("Nick", "New York", 8716250129, "abc@gmail.com", "Customer", "Male", "Nick@123", "10/5/2000");
            Console.WriteLine("Customer ID : {0}", customerDetails.CustomerId);
            Console.WriteLine("Customer Name : {0}", customerDetails.customerName);
            Console.WriteLine("Address : {0}", customerDetails.address);
            Console.WriteLine("Phone Number : {0}", customerDetails.phoneNumber);
            Console.WriteLine("Email ID : {0}", customerDetails.emailid);
            Console.WriteLine("Customer Type : {0}", customerDetails.customerType);
            Console.WriteLine("Gender : {0}",customerDetails.gender);
            Console.WriteLine("Password : {0}",customerDetails.password);
            Console.WriteLine("Date Of Birth : {0}",customerDetails.dateOfBirth);
            Console.WriteLine();
            Console.WriteLine("Customer ID : {0}", customerDetails1.CustomerId);
            Console.WriteLine("Customer Name : {0}", customerDetails1.customerName);
            Console.WriteLine("Address : {0}", customerDetails1.address);
            Console.WriteLine("Phone Number : {0}", customerDetails1.phoneNumber);
            Console.WriteLine("Email ID : {0}", customerDetails1.emailid);
            Console.WriteLine("Customer Type : {0}", customerDetails1.customerType);
            Console.WriteLine("Gender : {0}", customerDetails1.gender);
            Console.WriteLine("Password : {0}", customerDetails1.password);
            Console.WriteLine("Date Of Birth : {0}", customerDetails1.dateOfBirth);

            Console.WriteLine("====================================================");

            CustomerOrder order = new CustomerOrder(1247,"Cleanser","Visa Card","Hinjewadi",8329938702,"UPI");
            Console.WriteLine("OrderId : {0}",order.orderId);
            Console.WriteLine("Product Name : {0}",order.productName);
            Console.WriteLine("Payment Mode : {0}",order.paymentMethod);
            Console.WriteLine("Shipping Address : {0}", order.shippingAddress);
            Console.WriteLine("Mobile Number : {0}",order.mobileNumber);
            Console.WriteLine("Refund Mode : {0}",order.refundMode);
            

            Console.WriteLine("=====================================================");

            CustomerPayment payment = new CustomerPayment("TXN987654321","2025-22-12","Razorpay","50","No");
            Console.WriteLine("Transaction Id : {0}",payment.transactionId);
            Console.WriteLine("Payment Date And Time : {0}",payment.paymentDateAndTime);
            Console.WriteLine("Payment Gateway : {0}",payment.paymentGateway);
            Console.WriteLine("Shipping Charges : {0}",payment.shippingCharges);
            Console.WriteLine("Cash On Delivery : {0}",payment.cashOnDelivery);

            Console.WriteLine("=======================================================");

            Payment myObj = new Payment();
            myObj.PaymentMode();
            myObj.PaymentMode("Gpay");

            Payment pay = new CustomerPayment("TXN987651234", "2025-31-12", "PhonePe", "100", "Yes");
            pay.PaymentMode();

            Console.WriteLine("=======================================================");

            IOrder iOrder = new CustomerOrder(1248, "Watch", "Credit Card", "Morewadi", 8739931242, "Wallet");
            iOrder.RefundMode();
            iOrder.CancelOrder();

            Console.WriteLine("=======================================================");

            List<Order> myCategory = new List<Order>();
            myCategory.Add(new Category("Not Registered", "Buyer", "Regular", "Mumbai", "Active"));

            foreach (Order orders in myCategory)
            {
                orders.BuyerType();
            }
        }
    }
}
