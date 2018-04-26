using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    public class Transaction : POSEntity
    {
        public int Id { get; private set; }
        public DateTime DateTime { get; set; }
        public Customer Customer { get; set; }
        public List<PurchaseLine> PurchaseLines { get; set; }
        public decimal? Total { get; }
        public Payment Payment { get; set; }

        public Transaction() { }

        public Transaction(int id, DateTime dateTime, Customer customer, Payment payment, List<PurchaseLine> purchaseLines)
        {
            Id = id;
            DateTime = dateTime;
            Customer = customer;
            PurchaseLines = purchaseLines;
            Payment = payment;
            foreach (var line in PurchaseLines)
            {
                Total += line.LineValue;
            }
        }

        public override bool Validate()
        {
            //Validate object
            return IsValid;
        }
    }
}
