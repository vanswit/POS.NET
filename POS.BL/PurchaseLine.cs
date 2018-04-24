namespace POS.BL
{
    public class PurchaseLine : POSEntity
    {
        public int? Id { get; private set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal LineValue { get; set; }

        public PurchaseLine(int id, int transactionId, int productId, int quantity, decimal lineValue)
        {
            Id = id;
            TransactionId = transactionId;
            ProductId = productId;
            Quantity = quantity;
            LineValue = lineValue;
        }

        public override bool Validate()
        {
            //Validate object
            return IsValid;
        }
    }
}