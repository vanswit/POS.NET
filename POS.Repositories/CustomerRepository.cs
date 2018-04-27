using POS.BL;
using POS.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repositories
{
    public static class CustomerRepository
    {
        public static IEnumerable<Customer> GetCustomers(Dictionary<string,string> parameters)
        {
            using (POSContext context = new POSContext())
            {
                var customerList = new List<Customer>();

                var customers = from c in context.Customers          
                                select c;

                if (parameters["FirstName"] != null)
                {
                    string firstName = parameters["FirstName"];
                    customers = customers.Where(c => c.FirstName.Contains(firstName));
                }

                if (parameters["LastName"] != null)
                {
                    string lastName = parameters["LastName"];
                    customers = customers.Where(c => c.LastName.Contains(lastName));
                }

                if (parameters["City"] != null)
                {
                    string city = parameters["City"];
                    customers = customers.Where(c => c.Address.City.Contains(city));
                }

                if (parameters["Email"] != null)
                {
                    string emailAddress = parameters["Email"];
                    customers = customers.Where(c => c.EmailAddress.Contains(emailAddress));
                }

                foreach (var c in customers)
                {
                    customerList.Add(c);
                }

                return customerList;
            }

            
        }
    }
}
