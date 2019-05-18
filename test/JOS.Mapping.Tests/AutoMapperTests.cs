using AutoMapper;
using JOS.Mapping.Benchmark;
using JOS.Mapping.Benchmark.Response;
using Xunit;

namespace JOS.Mapping.Tests
{
    public class AutoMapperTests
    {
        private readonly IMapper _sut;

        public AutoMapperTests()
        {
            _sut = AutoMapperFactory.Create();
        }

        [Fact]
        public void GivenBusinessOrder_WhenAutoMapperMap_ThenMapsAndReturnsCorrectBusinessOrderResponseDto()
        {
            var businessOrder = OrderFactory.CreateBusinessOrder();

            var result = _sut.Map<BusinessOrderResponseDto>(businessOrder);

            MappingAssertHelper.Assert(businessOrder, result);
        }
    }
}
