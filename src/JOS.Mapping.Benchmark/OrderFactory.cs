using System.Collections.Generic;
using JOS.Mapping.Benchmark.Domain;

namespace JOS.Mapping.Benchmark
{
    public static class OrderFactory
    {
        public static BusinessOrder CreateBusinessOrder()
        {
            var billingAddress = new BusinessBillingAddress(
                new BusinessReceiver("JEHO Consulting AB", "Josef Ottosson"),
                "Josef Ottosson",
                "Vägen 123",
                "12345",
                "Stockholm",
                "Sverige");
            var shippingAddress = new BusinessShippingAddress(
                new BusinessReceiver("JEHO Consulting AB", "Josef Ottosson"),
                "Company B",
                "Sveavägen 123",
                "12345",
                "Stockholm",
                "Sverige");

            var businessOrder = new BusinessOrder(
                2000,
                billingAddress,
                shippingAddress,
                new BusinessCustomer("1", "JEHO Consulting AB","559164-7150"),
                new OrderDetails(new List<OrderRow>
                {
                    new OrderRow("Apple iPad Pro 11", "APLIPPRO11", 1, 10000m, 25)
                }));

            return businessOrder;
        }
    }
}
