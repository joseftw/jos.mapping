using System;
using System.Collections.Generic;
using System.Linq;
using JOS.Mapping.Benchmark.Domain;

namespace JOS.Mapping.Benchmark.Response
{
    public class OrderDetailsResponseDto
    {
        public OrderDetailsResponseDto(decimal totalPrice, IEnumerable<OrderRowResponseDto> orderRows)
        {
            TotalPrice = totalPrice;
            OrderRows = orderRows ?? Array.Empty<OrderRowResponseDto>();
        }

        public decimal TotalPrice { get; }
        public IEnumerable<OrderRowResponseDto> OrderRows { get; }

        public static implicit operator OrderDetailsResponseDto(OrderDetails orderDetails)
        {
            return new OrderDetailsResponseDto(
                orderDetails.TotalPrice,
                orderDetails.OrderRows.Select(x => (OrderRowResponseDto)x));
        }
    }

    public class OrderRowResponseDto
    {
        public OrderRowResponseDto(string name, string productId, int quantity, decimal price, decimal vat, decimal vatPercentage)
        {
            Name = name;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            Vat = vat;
            VatPercentage = vatPercentage;
        }

        public string Name { get; }
        public string ProductId { get; }
        public decimal Price { get; }
        public decimal Vat { get; }
        public decimal VatPercentage { get; }
        public int Quantity { get; }

        public static implicit operator OrderRowResponseDto(OrderRow orderRow)
        {
            return new OrderRowResponseDto(
                orderRow.Name,
                orderRow.ProductId,
                orderRow.Quantity,
                orderRow.Price,
                orderRow.Vat,
                orderRow.VatPercentage);
        }
    }
}
