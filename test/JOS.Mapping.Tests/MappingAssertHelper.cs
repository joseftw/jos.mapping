using System.Linq;
using JOS.Mapping.Benchmark.Domain;
using JOS.Mapping.Benchmark.Response;
using Shouldly;

namespace JOS.Mapping.Tests
{
    public static class MappingAssertHelper
    {
        public static void Assert(BusinessOrder businessOrder, BusinessOrderResponseDto result)
        {
            result.OrderId.ShouldBe(businessOrder.Id);
            result.Type.ShouldBe(businessOrder.Type);
            result.Address.Billing.Reference.ShouldBe(businessOrder.Billing.Receiver.Reference);
            result.Address.Billing.CompanyName.ShouldBe(businessOrder.Billing.Receiver.CompanyName);
            result.Address.Billing.CareOf.ShouldBe(businessOrder.Billing.CareOf);
            result.Address.Billing.City.ShouldBe(businessOrder.Billing.City);
            result.Address.Billing.Country.ShouldBe(businessOrder.Billing.Country);
            result.Address.Billing.Street.ShouldBe(businessOrder.Billing.Street);
            result.Address.Billing.Zip.ShouldBe(businessOrder.Billing.Zip);
            result.Address.Shipping.Reference.ShouldBe(businessOrder.Shipping.Receiver.Reference);
            result.Address.Shipping.CompanyName.ShouldBe(businessOrder.Shipping.Receiver.CompanyName);
            result.Address.Shipping.CareOf.ShouldBe(businessOrder.Shipping.CareOf);
            result.Address.Shipping.City.ShouldBe(businessOrder.Shipping.City);
            result.Address.Shipping.Country.ShouldBe(businessOrder.Shipping.Country);
            result.Address.Shipping.Street.ShouldBe(businessOrder.Shipping.Street);
            result.Address.Shipping.Zip.ShouldBe(businessOrder.Shipping.Zip);
            result.OrderDetails.TotalPrice.ShouldBe(businessOrder.OrderDetails.TotalPrice);
            result.OrderDetails.OrderRows.Count().ShouldBe(businessOrder.OrderDetails.OrderRows.Count);
            foreach (var row in businessOrder.OrderDetails.OrderRows)
            {
                result.OrderDetails.OrderRows.ShouldContain(
                    x => x.Name == row.Name &&
                         x.ProductId == row.ProductId &&
                         x.Price == row.Price &&
                         x.VatPercentage == row.VatPercentage &&
                         x.Vat == row.Vat &&
                         x.Quantity == row.Quantity);
            }
            result.OrderDetails.OrderRows.First().Name.ShouldBe(businessOrder.OrderDetails.OrderRows.First().Name);
            result.OrderDetails.OrderRows.First().ProductId.ShouldBe(businessOrder.OrderDetails.OrderRows.First().ProductId);
            result.OrderDetails.OrderRows.First().Price.ShouldBe(businessOrder.OrderDetails.OrderRows.First().Price);
            result.OrderDetails.OrderRows.First().Vat.ShouldBe(businessOrder.OrderDetails.OrderRows.First().Vat);
            result.OrderDetails.OrderRows.First().VatPercentage.ShouldBe(businessOrder.OrderDetails.OrderRows.First().VatPercentage);
            result.Customer.Id.ShouldBe(businessOrder.Customer.Id);
            result.Customer.Name.ShouldBe(businessOrder.Customer.CompanyName);
            result.Customer.OrganizationalNumber.ShouldBe(businessOrder.Customer.OrganizationalNumber);
        }
    }
}
