using System;
using BenchmarkDotNet.Attributes;

namespace CSharpBenchMarksForLoops
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    [RankColumn]
    public class ListForLoopTests
    {
        private List<int> TestSample = Enumerable.Range(0, 1000).ToList();
        [Benchmark]
        public void ForEachLoop()
        {
            int count = 0;
            foreach (var item in TestSample)
            {
                count++;
            }
        }
        [Benchmark]
        public void ForEachLoopMethod()
        {
            int count = 0;
            TestSample.ForEach(sample => count++);
        }
        [Benchmark]
        public void ForEachSelectMethod()
        {
            int count = 0;
            TestSample.Select(sample => count++);
        }
    }
}

