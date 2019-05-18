namespace JOS.Mapping.Benchmark.Domain
{
    public abstract class Order<TBillingAddress, TShippingAddress, TCustomer>
    {
        protected Order(
            int id,
            TBillingAddress billing,
            TShippingAddress shipping,
            TCustomer customer,
            OrderDetails orderDetails)
        {
            Id = id;
            Billing = billing;
            Shipping = shipping;
            Customer = customer;
            OrderDetails = orderDetails;
        }

        public int Id { get; }
        public abstract string Type { get; }
        public TBillingAddress Billing { get; }
        public TShippingAddress Shipping { get; }
        public TCustomer Customer { get; }
        public OrderDetails OrderDetails { get; }
    }

    public class BusinessOrder : Order<BusinessBillingAddress, BusinessShippingAddress, BusinessCustomer>
    {
        public BusinessOrder(
            int id,
            BusinessBillingAddress billing,
            BusinessShippingAddress shipping,
            BusinessCustomer customer,
            OrderDetails orderDetails) : base(
            id,
            billing,
            shipping,
            customer,
            orderDetails)
        {

        }

        public override string Type => "BUSINESS";
    }
}
