using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    public class Customer : POSEntity
    {
        public int Id { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Address Address { get; set; }
        public string EmailAddress { get; set; }
        public string FullName { get; }

        public Customer(int id, string lastName, string firstName, Address address, string emailAddress)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Address = address;
            EmailAddress = emailAddress;
            FullName = firstName + " " + lastName;
        }

        public override bool Validate()
        {
            //Validate object
            return IsValid;
        }
    }
}
