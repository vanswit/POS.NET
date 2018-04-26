namespace POS.BL
{
    public class PurchaseLine : POSEntity
    {
        public int? Id { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal LineValue { get; set; }

        public PurchaseLine(int id, int productId, int quantity)
        {
            Id = id;
            ProductId = productId;
            Quantity = quantity;
           //Calculate LineValue
        }

        public override bool Validate()
        {
            //Validate object
            return IsValid;
        }
    }
}