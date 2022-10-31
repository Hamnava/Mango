using Mongo.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductServices: IBaseService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> CreateProductsAsync<T>(ProductDto productDto);
        Task<T> UpdateProductsAsync<T>(ProductDto productDto);
        Task<T> DeleteProductsAsync<T>(int id);
    }
}
