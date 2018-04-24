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
        public decimal? Total { get; }

        private Transaction() { }

        public Transaction(int id, DateTime dateTime, int customerId)
        {
            Id = id;
            DateTime = dateTime;
            CustomerId = customerId;
            //Set total
        }

        public override bool Validate()
        {
            //Validate object
            return IsValid;
        }
    }
}
