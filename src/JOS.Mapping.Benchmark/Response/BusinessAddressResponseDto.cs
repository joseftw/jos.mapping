using JOS.Mapping.Benchmark.Domain;

namespace JOS.Mapping.Benchmark.Response
{
    public class BusinessAddressResponseDto
    {
        public BusinessAddressResponseDto(BusinessAddressBillingResponseDto billing, BusinessAddressShippingResponseDto shipping)
        {
            Billing = billing;
            Shipping = shipping;
        }

        public BusinessAddressBillingResponseDto Billing { get; }
        public BusinessAddressShippingResponseDto Shipping { get; }
    }

    public class BusinessAddressBillingResponseDto
    {
        public BusinessAddressBillingResponseDto(
            string companyName,
            string reference,
            string careOf,
            string city,
            string street,
            string zip,
            string country)
        {
            CompanyName = companyName;
            Reference = reference;
            CareOf = careOf;
            City = city;
            Street = street;
            Zip = zip;
            Country = country;
        }

        public string CompanyName { get; }
        public string Reference { get; }
        public string CareOf { get; }
        public string City { get; }
        public string Street { get; }
        public string Zip { get; }
        public string Country { get; }

        public static implicit operator BusinessAddressBillingResponseDto(BusinessBillingAddress billing)
        {
            return new BusinessAddressBillingResponseDto(
                billing.Receiver.CompanyName,
                billing.Receiver.Reference,
                billing.CareOf,
                billing.City,
                billing.Street,
                billing.Zip,
                billing.Country);
        }
    }

    public class BusinessAddressShippingResponseDto
    {
        public BusinessAddressShippingResponseDto(
            string companyName,
            string reference,
            string careOf,
            string city,
            string street,
            string zip,
            string country)
        {
            CompanyName = companyName;
            Reference = reference;
            CareOf = careOf;
            City = city;
            Street = street;
            Zip = zip;
            Country = country;
        }

        public string CompanyName { get; }
        public string Reference { get; }
        public string CareOf { get; }
        public string City { get; }
        public string Street { get; }
        public string Zip { get; }
        public string Country { get; }

        public static implicit operator BusinessAddressShippingResponseDto(BusinessShippingAddress shipping)
        {
            return new BusinessAddressShippingResponseDto(
                shipping.Receiver.CompanyName,
                shipping.Receiver.Reference,
                shipping.CareOf,
                shipping.City,
                shipping.Street,
                shipping.Zip,
                shipping.Country);
        }
    }
}
