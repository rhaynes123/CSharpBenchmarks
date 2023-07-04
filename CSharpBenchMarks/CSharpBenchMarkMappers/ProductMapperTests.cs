using System;
using BenchmarkDotNet.Attributes;

namespace CSharpBenchMarkMappers
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
    [RankColumn]
    public class ProductMapperTests
	{
        private readonly List<ProductDto> productDtos = Enumerable.Range(0, 1000)
            .Select(_ => new ProductDto(Guid.NewGuid(), string.Empty))
            .ToList();
		public ProductMapperTests()
		{
		}

		[Benchmark]
		public void TestMappingAsingleProductDtoToDomainWithImplicitOperator()
		{
			ProductDto dto = new ProductDto(Guid.NewGuid(), "Pizza");
			ProductDomainModel model = (ProductDomainModel)dto;
		}
        [Benchmark]
        public void TestMappingAsingleProductDtoToDomainWithExtensions()
        {
            ProductDto dto = new ProductDto(Guid.NewGuid(), "Pizza");
            ProductDomainModel model = dto.ToDomain();
        }

        [Benchmark]
        public void TestMappingManyProductDtosToDomainWithImplicitOperator()
        {
            List<ProductDomainModel> domainModels = productDtos
                .Select(dto => (ProductDomainModel)dto)
                .ToList();
        }

        [Benchmark]
        public void TestMappingManyProductDtosToDomainWithExtension()
        {
            List<ProductDomainModel> domainModels = productDtos
                .Select(dto => dto.ToDomain())
                .ToList();
        }
    }
}

