using System.Collections.Generic;
using System.Linq;

namespace JOS.Mapping.Benchmark.Domain
{
    public class OrderDetails
    {
        public OrderDetails(IReadOnlyCollection<OrderRow> orderRows)
        {
            OrderRows = orderRows ?? new List<OrderRow>();
        }

        public IReadOnlyCollection<OrderRow> OrderRows { get; }
        public decimal TotalPrice => OrderRows.Sum(x => x.Price);

    }

    public class OrderRow
    {
        public OrderRow(string name, string productId, int quantity, decimal price, decimal vatPercentage)
        {
            Name = name;
            ProductId = productId;
            Quantity = quantity;
            Price = price * quantity;
            VatPercentage = vatPercentage;
        }

        public string Name { get; }
        public string ProductId { get; }
        public decimal Price { get; }
        public decimal Vat => Price * (VatPercentage / 100);
        public decimal VatPercentage { get; }
        public int Quantity { get; }
    }
}
