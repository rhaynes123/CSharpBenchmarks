using System;
using BenchmarkDotNet.Attributes;

namespace CSharpBenchMarksFirstvsSingle
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    [RankColumn]
    public class FirstVsSingleTests
	{
		public readonly List<Product> products = Enumerable.Range(0, 1000)
			.Select(id => new Product(id)).ToList();

		[Benchmark]
		public void FirstTest()
		{
			products.First(prd => prd.id == 100);
		}
        [Benchmark]
        public void SingleTest()
        {
            products.Single(prd => prd.id == 100);
        }
    }

	public record Product(int id);
}

