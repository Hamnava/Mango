﻿using Mango.Web.Models;
using Mango.Web.Services.IServices;
using Mongo.Web.Models;
using System.Net.Http;

namespace Mango.Web.Services
{
    public class ProductServices : BaseService, IProductServices
    {
        private readonly IHttpClientFactory _clientFactory;
        public ProductServices(IHttpClientFactory clientFactory): base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateProductsAsync<T>(ProductDto productDto, string token)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.POST,
                Data = productDto,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken = token
            });
        }

        public async Task<T> DeleteProductsAsync<T>(int id, string token)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.ProductAPIBase + "/api/products/"+ id,
                AccessToken = token
            });
        }

        public async Task<T> GetAllProductsAsync<T>(string token)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken = token
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int id, string token)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/products/"+ id,
                AccessToken = token
            });
        }

        public async Task<T> UpdateProductsAsync<T>(ProductDto productDto, string token)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.PUT,
                Data = productDto,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken = token
            });
        }
    }
}
