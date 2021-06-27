using MVP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MVP.Repository
{
    class CustomerRepository : ICustomerRepository
    {

        public string xmlPath { get; set; }
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;
        
        public CustomerRepository(string path)
        {
            xmlPath = path + "\\customer.xml";
            if (!File.Exists(xmlPath))
            {
                XmlFakeRepo();
            }
            customers = new List<Customer>();


            using (var ser=new StreamReader(xmlPath))
                {
                    customers=(List<Customer>) xmlSerializer.Deserialize(ser);
                }
            
            

        }
        void XmlFakeRepo()
        {
            List<Customer> customerList = new List<Customer> { 
                new Customer("John Doe","Some 111/a","doe@gmail.com"),
                new Customer("Terminator Swartz","Berlin 0/a","term@gmail.com")
            };
            SaveCustomers(customerList);
        }




        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            return customers[id];
        }
        public void SaveCustomers(List<Customer> _customers)
        {
            using (var ser = new StreamWriter(xmlPath))
            {
                xmlSerializer.Serialize(ser, _customers);
            }

        }
        public void SaveCustomer(int id, Customer customer)
        {
            customers[id] = customer;
            SaveCustomers(customers);

        }
    }
}
