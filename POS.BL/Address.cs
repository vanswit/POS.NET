namespace POS.BL
{
    public class Address : POSEntity
    {
        public int Id { get; private set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address()
        {

        }

        public Address(int id, string addressLine1, string addressLine2, string postalCode, string city, string country)
        {
            Id = id;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            PostalCode = postalCode;
            City = city;
            Country = country;
        }

        public override bool Validate()
        {
            return IsValid;
        }
    }
}