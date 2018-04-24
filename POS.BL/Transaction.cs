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
        public int CustomerId { get; set; }
        public List<PurchaseLine> PurchaseLines { get; set; }
        public decimal Total { get; }

        private Transaction() { }

        public Transaction(int id, DateTime dateTime, int customerId, List<PurchaseLine> purchaseLines)
        {
            Id = id;
            DateTime = dateTime;
            CustomerId = customerId;
            PurchaseLines = purchaseLines;
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
