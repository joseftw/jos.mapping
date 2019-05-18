using JOS.Mapping.Benchmark.Domain;

namespace JOS.Mapping.Benchmark.Response
{
    public abstract class OrderResponseDto
    {
        public int OrderId { get; }
        public abstract string Type { get; }
        public OrderDetailsResponseDto OrderDetails { get; }

        protected OrderResponseDto(int orderId, OrderDetailsResponseDto orderDetails)
        {
            OrderId = orderId;
            OrderDetails = orderDetails;
        }
    }

    public class BusinessOrderResponseDto : OrderResponseDto
    {
        public BusinessOrderResponseDto(
            int orderId,
            BusinessAddressResponseDto address,
            BusinessCustomerResponseDto customer,
            OrderDetailsResponseDto orderDetails) : base(orderId,
            orderDetails)
        {
            Address = address;
            Customer = customer;
        }
        public override string Type => "BUSINESS";

        public BusinessAddressResponseDto Address { get; }

        public BusinessCustomerResponseDto Customer { get; }

        public static implicit operator BusinessOrderResponseDto(BusinessOrder order)
        {
            var billing = (BusinessAddressBillingResponseDto) order.Billing;
            var shipping = order.Shipping == null
                ? null
                : (BusinessAddressShippingResponseDto) order.Shipping;
            var customer = (BusinessCustomerResponseDto) order.Customer;
            var orderDetails = (OrderDetailsResponseDto) order.OrderDetails;
            

            return new BusinessOrderResponseDto(
                order.Id,
                new BusinessAddressResponseDto(billing, shipping),
                customer, 
                orderDetails);
        }
    }
}
