using Mongo.Services.ProductAPI.Models.Dto;

namespace Mongo.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CraeteUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
