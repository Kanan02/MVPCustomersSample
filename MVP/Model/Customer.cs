using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Model
{
    public class Customer
    {
        public Customer(string fullName, string address, string email,string citizenship)
        {
            FullName = fullName;
            Address = address;
            Email = email;
            Citizenship = citizenship;
        }
        public Customer()
        {

        }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Citizenship { get; set; }

    }
}
