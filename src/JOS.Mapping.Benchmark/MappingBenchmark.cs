using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BenchmarkDotNet.Attributes;
using JOS.Mapping.Benchmark.Domain;
using JOS.Mapping.Benchmark.Response;

namespace JOS.Mapping.Benchmark
{
    [CoreJob]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class MappingBenchmark
    {
        private readonly BusinessOrder _businessOrder;
        private readonly OrderResponseDtoFactory _orderResponseDtoFactory;
        private readonly IMapper _mapper;

        public MappingBenchmark()
        {
            _businessOrder = OrderFactory.CreateBusinessOrder();
            _orderResponseDtoFactory = new OrderResponseDtoFactory();
            _mapper = AutoMapperFactory.Create();
        }

        [Benchmark(Baseline = true)]
        public BusinessOrderResponseDto Factory()
        {
            return _orderResponseDtoFactory.Create(_businessOrder);
        }

        [Benchmark]
        public BusinessOrderResponseDto Explicit()
        {
            return (BusinessOrderResponseDto)_businessOrder;
        }

        [Benchmark]
        public BusinessOrderResponseDto Implicit()
        {
            BusinessOrderResponseDto response = _businessOrder;
            return response;
        }

        [Benchmark]
        public BusinessOrderResponseDto AutoMapper()
        {
            return _mapper.Map<BusinessOrderResponseDto>(_businessOrder);
        }
    }
}
