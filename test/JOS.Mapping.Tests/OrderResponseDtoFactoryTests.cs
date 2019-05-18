using JOS.Mapping.Benchmark;
using Xunit;

namespace JOS.Mapping.Tests
{
    public class OrderResponseDtoFactoryTests
    {
        private readonly OrderResponseDtoFactory _sut;

        public OrderResponseDtoFactoryTests()
        {
            _sut = new OrderResponseDtoFactory();
        }

        [Fact]
        public void GivenBusinessOrder_WhenCreate_ThenMapsAndCreatesCorrectBusinessOrderResponseDto()
        {
            var businessOrder = OrderFactory.CreateBusinessOrder();

            var result = _sut.Create(businessOrder);

            MappingAssertHelper.Assert(businessOrder, result);
        }
    }
}
