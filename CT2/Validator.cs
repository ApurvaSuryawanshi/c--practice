using System;
using System.Collections.Generic;
using System.Text;

namespace CT2
{
    public class Validator
    {
        public string Name { get; set; }
        private string Password { get; set; }
        public string CustomerType { get; set; }


        public void setPassword(string Password)
        {
           
            if (Password.Length >= 6)
            {
                this.Password = Password;
            }
            else
            {
                Console.WriteLine("Password should contain atleast 6 characters ");
            }
        }

        public void getPassword()
        {
            Console.WriteLine("The Password is :" + this.Password);
        }
        

    }
}
