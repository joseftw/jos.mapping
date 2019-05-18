using JOS.Mapping.Benchmark;
using JOS.Mapping.Benchmark.Response;
using Xunit;

namespace JOS.Mapping.Tests
{
    public class ImplicitMappingTests
    {
        [Fact]
        public void GivenBusinessOrder_WhenImplicitCast_ThenReturnsCorrectlyMappedBusinessOrderResponseDto()
        {
            var businessOrder = OrderFactory.CreateBusinessOrder();

            BusinessOrderResponseDto result = businessOrder;

            MappingAssertHelper.Assert(businessOrder, result);
        }
    }
}
