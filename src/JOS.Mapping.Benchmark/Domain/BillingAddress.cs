namespace JOS.Mapping.Benchmark.Domain
{
    public abstract class BillingAddress
    {
        protected BillingAddress(Receiver receiver, string careOf, string street, string zip, string city, string country)
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

    public class ConsumerBillingAddress : BillingAddress
    {
        public ConsumerBillingAddress(ConsumerReceiver receiver, string careOf, string street, string zip, string city, string country) : base(receiver, careOf, street, zip, city, country)
        {
            Receiver = receiver;
        }

        public new ConsumerReceiver Receiver { get; }
    }

    public class BusinessBillingAddress : BillingAddress
    {
        public BusinessBillingAddress(BusinessReceiver receiver, string careOf, string street, string zip, string city, string country) : base(receiver, careOf, street, zip, city, country)
        {
            Receiver = receiver;
        }

        public new BusinessReceiver Receiver { get; }
    }
}
