using BenchmarkDotNet.Running;

namespace JOS.Mapping.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MappingBenchmark>();
        }
    }
}
