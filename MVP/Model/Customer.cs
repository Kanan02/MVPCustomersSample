using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Model
{
    public class Customer
    {
        public Customer(string fullName, string address, string email)
        {
            FullName = fullName;
            Address = address;
            Email = email;
        }
        public Customer()
        {

        }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


    }
}
