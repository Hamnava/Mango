using Mango.Web.Models;
using Mongo.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        public ResponseDto responseModel { get; set; }

        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
