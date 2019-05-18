namespace JOS.Mapping.Benchmark.Domain
{
    public abstract class Order
    {
        protected Order(int id, BillingAddress billing, ShippingAddress shipping, Customer customer, OrderDetails orderDetails)
        {
            Id = id;
            Billing = billing;
            Shipping = shipping;
            Customer = customer;
            OrderDetails = orderDetails;
        }

        public int Id { get; }
        public abstract string Type { get; }
        public BillingAddress Billing { get; }
        public ShippingAddress Shipping { get; }
        public Customer Customer { get; }
        public OrderDetails OrderDetails { get; }
    }

    public class ConsumerOrder : Order
    {
        public ConsumerOrder(int id, ConsumerBillingAddress billing, ConsumerShippingAddress shipping, ConsumerCustomer customer, OrderDetails orderDetails) : base(id, billing, shipping, customer, orderDetails)
        {
            
        }

        public override string Type => "CONSUMER";
        public new ConsumerBillingAddress Billing => (ConsumerBillingAddress) base.Billing;
        public new ConsumerShippingAddress Shipping => (ConsumerShippingAddress) base.Shipping;
        public new ConsumerCustomer Customer => (ConsumerCustomer) base.Customer;
    }

    public class BusinessOrder : Order
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

        public new BusinessBillingAddress Billing => (BusinessBillingAddress)base.Billing;
        public new BusinessShippingAddress Shipping => (BusinessShippingAddress)base.Shipping;
        public new BusinessCustomer Customer => (BusinessCustomer)base.Customer;
    }
}
