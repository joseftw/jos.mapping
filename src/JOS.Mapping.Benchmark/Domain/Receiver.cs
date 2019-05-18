namespace JOS.Mapping.Benchmark.Domain
{
    public class Receiver
    {
    }

    public class ConsumerReceiver : Receiver
    {
        public ConsumerReceiver(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }

    public class BusinessReceiver : Receiver
    {
        public BusinessReceiver(string companyName, string reference)
        {
            CompanyName = companyName;
            Reference = reference;
        }

        public string CompanyName { get; }
        public string Reference { get; }
    }
}
