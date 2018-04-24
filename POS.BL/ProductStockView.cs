using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    public class ProductStockView
    {
        public string ProductCode { get; set; }
        public string ProductVendor { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
