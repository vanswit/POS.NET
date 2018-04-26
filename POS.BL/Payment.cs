using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    public class Payment : POSEntity
    {
        public int Id { get; private set; }
        public decimal Amount { get; set; }
        public PaymentType Type { get; set; }

        public Payment()
        {

        }

        public Payment(decimal amount, PaymentType paymentType)
        {
            Amount = amount;
            Type = paymentType;
        }

        public override string ToString()
        {
            return Type.ToString() + " : " + Amount;
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        public enum PaymentType
        {
            Cash,
            Card
        }
    } 
}
