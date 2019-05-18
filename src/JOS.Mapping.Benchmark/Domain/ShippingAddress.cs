namespace JOS.Mapping.Benchmark.Domain
{
    public abstract class ShippingAddress
    {
        protected ShippingAddress(Receiver receiver, string careOf, string street, string zip, string city, string country)
        {
            Receiver = receiver;
            CareOf = careOf;
            Street = street;
            Zip = zip;
            City = city;
            Country = country;
        }
        public Receiver Receiver { get; }
        public string CareOf { get; }
        public string Street { get; }
        public string Zip { get; }
        public string City { get; }
        public string Country { get; }
    }

    public class BusinessShippingAddress : ShippingAddress
    {
        public BusinessShippingAddress(BusinessReceiver receiver, string careOf, string street, string zip, string city, string country) : base(receiver, careOf, street, zip, city, country)
        {
        }

        public new BusinessReceiver Receiver => (BusinessReceiver) base.Receiver;
    }

    public class ConsumerShippingAddress : ShippingAddress
    {
        public ConsumerShippingAddress(ConsumerReceiver receiver, string careOf, string street, string zip, string city, string country) : base(receiver, careOf, street, zip, city, country)
        {
        }

        public new ConsumerReceiver Receiver => (ConsumerReceiver)base.Receiver;
    }
}
