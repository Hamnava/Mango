using Mongo.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductServices: IBaseService
    {
        Task<T> GetAllProductsAsync<T>(string token);
        Task<T> GetProductByIdAsync<T>(int id, string token);
        Task<T> CreateProductsAsync<T>(ProductDto productDto, string token);
        Task<T> UpdateProductsAsync<T>(ProductDto productDto, string token);
        Task<T> DeleteProductsAsync<T>(int id, string token);
    }
}
