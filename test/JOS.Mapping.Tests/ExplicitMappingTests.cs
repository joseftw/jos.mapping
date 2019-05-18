using JOS.Mapping.Benchmark;
using JOS.Mapping.Benchmark.Response;
using Xunit;

namespace JOS.Mapping.Tests
{
    public class ExplicitMappingTests
    {
        [Fact]
        public void GivenBusinessOrder_WhenExplicitCast_ThenReturnsCorrectlyMappedBusinessOrderResponseDto()
        {
            var businessOrder = OrderFactory.CreateBusinessOrder();

            var result = (BusinessOrderResponseDto) businessOrder;

            MappingAssertHelper.Assert(businessOrder, result);
        }
    }
}
