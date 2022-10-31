using static Mango.Web.SD;

namespace Mango.Web.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = SD.ApiType.GET;
        public object Data { get; set; }
        public string Url { get; set; }
        public string AccessToken { get; set; }
    }
}
