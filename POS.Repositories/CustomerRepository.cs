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
                var customers = from c in context.Customers
                                select c;
                if (parameters["FirstName"] != null)
                {
                    customers = customers.Where(c => c.FirstName.Contains(parameters["FirstName"]));
                }

                if (parameters["LastName"] != null)
                {
                    customers = customers.Where(c => c.LastName.Contains(parameters["LastName"]));
                }

                if (parameters["City"] != null)
                {
                    customers = customers.Where(c => c.Address.City.Contains(parameters["City"]));
                }

                if (parameters["Email"] != null)
                {
                    customers = customers.Where(c => c.EmailAddress.Contains(parameters["Email"]));
                }

                return customers;
            }

            
        }
    }
}
