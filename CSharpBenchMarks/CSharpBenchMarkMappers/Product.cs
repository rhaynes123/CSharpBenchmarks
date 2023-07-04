using System;
namespace CSharpBenchMarkMappers
{
	public class Product
	{
		public Product()
		{
		}
	}

    public sealed record ProductDto(Guid id, string Name)
    {
        public static implicit operator ProductDomainModel(ProductDto dto)
        {
            return new ProductDomainModel { Id = new ProductId(dto.id), Name = dto.Name };
        }
    }

    public sealed record ProductDomainModel
    {
        public required ProductId Id { get; set; }
        public required string Name { get; set; }
    }

    public readonly record struct ProductId(Guid id);

    public static class ProductDomainModelExtensions
    {
        public static ProductDomainModel ToDomain(this ProductDto dto)
        {
            return new ProductDomainModel { Id= new ProductId(dto.id), Name = dto.Name };
        }
    }

}

