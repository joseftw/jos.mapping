using System.Linq;
using AutoMapper;
using JOS.Mapping.Benchmark.Domain;
using JOS.Mapping.Benchmark.Response;

namespace JOS.Mapping.Benchmark
{
    public class AutoMapperFactory
    {
        public static IMapper Create()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BusinessOrder, BusinessOrderResponseDto>()
                    .ConstructUsing(x => new BusinessOrderResponseDto(
                        x.Id,
                        new BusinessAddressResponseDto(
                            new BusinessAddressBillingResponseDto(
                                x.Billing.Receiver.CompanyName,
                                x.Billing.Receiver.Reference,
                                x.Billing.CareOf,
                                x.Billing.City,
                                x.Billing.Street,
                                x.Billing.Zip,
                                x.Billing.Country),
                            new BusinessAddressShippingResponseDto(
                                x.Shipping.Receiver.CompanyName,
                                x.Shipping.Receiver.Reference,
                                x.Shipping.CareOf,
                                x.Shipping.City,
                                x.Shipping.Street,
                                x.Shipping.Zip,
                                x.Shipping.Country)),
                        new BusinessCustomerResponseDto(x.Customer.Id, x.Customer.CompanyName, x.Customer.OrganizationalNumber),
                        new OrderDetailsResponseDto(
                            x.OrderDetails.TotalPrice,
                            x.OrderDetails.OrderRows.Select(r => new OrderRowResponseDto(r.Name,
                                r.ProductId,
                                r.Quantity,
                                r.Price,
                                r.Vat,
                                r.VatPercentage)))));
            });

            return config.CreateMapper();
        }
    }
}
