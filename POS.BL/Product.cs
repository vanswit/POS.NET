using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    public class Product : POSEntity
    {
        public int? Id { get; private set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Vendor { get; set; }
        public string ProductCode { get; set;}
        public string FullProductName { get; }

        public Product()
        {

        }

        public Product(int id, decimal price, string name, string vendor, string productCode)
        {
            Id = id;
            Price = price;
            Name = name;
            Vendor = vendor;
            ProductCode = productCode;
            FullProductName = vendor + " " + name;
        }

        public override bool Validate()
        {
            //Validate the object
            return IsValid;
        }

        public override string ToString()
        {
            return FullProductName;
        }
    }
}
