namespace JOS.Mapping.Benchmark.Domain
{
    public abstract class Customer
    {
        protected Customer(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }

    public class ConsumerCustomer : Customer
    {
        public ConsumerCustomer(string id, string personalNumber) : base(id)
        {
            PersonalNumber = personalNumber;
        }

        public string PersonalNumber { get; }
    }

    public class BusinessCustomer : Customer
    {
        public BusinessCustomer(string id, string companyName, string organizationalNumber) : base(id)
        {
            CompanyName = companyName;
            OrganizationalNumber = organizationalNumber;
        }
        public string CompanyName { get; }
        public string OrganizationalNumber { get; }
    }
}
