using JOS.Mapping.Benchmark.Domain;

namespace JOS.Mapping.Benchmark.Response
{
    public class BusinessCustomerResponseDto
    {
        public BusinessCustomerResponseDto(string id, string name, string organizationalNumber)
        {
            Id = id;
            Name = name;
            OrganizationalNumber = organizationalNumber;
        }

        public string Id { get; }
        public string Name { get; }
        public string OrganizationalNumber { get; }

        public static implicit operator BusinessCustomerResponseDto(BusinessCustomer customer)
        {
            return new BusinessCustomerResponseDto(customer.Id, customer.CompanyName, customer.OrganizationalNumber);
        }
    }
}
