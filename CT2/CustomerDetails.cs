using System;
using System.Collections.Generic;
using System.Text;

namespace CT2
{
    public class CustomerDetails : Validator
    {

        private static int customerIdCounter = 1201;
        public int CustomerId { get; private set; }
        public string customerName;
        public string address;
        public long phoneNumber;
        public string emailid;
        public string customerType;
        public string gender;
        public string password;
        public string dateOfBirth;

        public CustomerDetails(string customerName,string address,long phoneNumber,string emailid,string customerType,string gender,string password,string dateOfBirth)
        {
            CustomerId = ++customerIdCounter;
            this.customerName = customerName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.emailid = emailid;
            this.customerType = customerType;
            this.gender = gender;
            this.password = password;
            this.dateOfBirth = dateOfBirth;


        }
    }
}
