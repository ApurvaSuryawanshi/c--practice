using System;
using System.Collections.Generic;
using System.Text;

namespace CT2
{
    public class Cust
    {
        public string name;
        public string city;
        public string country;
        public string password;

        public Cust(string name,string city,string country,string password)
        {
            this.name = name;
            this.city = city;
            this.country = country;
            this.password = password;
        }

        public string Display()
        {
            return name +" " + city + " " +country +" " + password;
        }
    }
}
