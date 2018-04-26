namespace POS.BL
{
    public class PurchaseLine : POSEntity
    {
        public int? Id { get; private set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal LineValue { get; set; }

        public PurchaseLine()
        {

        }

        public PurchaseLine(int id, Product product, int quantity)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
            LineValue = Quantity * product.Price;
        }

        public override bool Validate()
        {
            //Validate object
            return IsValid;
        }
    }
}