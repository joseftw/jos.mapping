using System.Linq;
using JOS.Mapping.Benchmark.Domain;
using JOS.Mapping.Benchmark.Response;

namespace JOS.Mapping.Benchmark
{
    public class OrderResponseDtoFactory
    {
        public BusinessOrderResponseDto Create(BusinessOrder order)
        {
            var billingAddress = new BusinessAddressBillingResponseDto(
                order.Billing.Receiver.CompanyName,
                order.Billing.Receiver.Reference,
                order.Billing.CareOf,
                order.Billing.City,
                order.Billing.Street,
                order.Billing.Zip,
                order.Billing.Country);

            var shippingAddress = order.Shipping != null
                ? new BusinessAddressShippingResponseDto(
                    order.Shipping.Receiver.CompanyName,
                    order.Shipping.Receiver.Reference,
                    order.Shipping.CareOf,
                    order.Shipping.City,
                    order.Shipping.Street,
                    order.Shipping.Zip,
                    order.Shipping.Country)
                : null;

            var orderDetailsResponseDto = new OrderDetailsResponseDto(
                order.OrderDetails.TotalPrice,
                order.OrderDetails.OrderRows.Select(x => new OrderRowResponseDto(
                    x.Name,
                    x.ProductId,
                    x.Quantity,
                    x.Price,
                    x.Vat,
                    x.VatPercentage
                ))
            );

            return new BusinessOrderResponseDto(
                order.Id,
                new BusinessAddressResponseDto(
                    billingAddress,
                    shippingAddress
                ),
                new BusinessCustomerResponseDto(order.Customer.Id, order.Customer.CompanyName, order.Customer.OrganizationalNumber), 
                orderDetailsResponseDto);
        }
    }
}
