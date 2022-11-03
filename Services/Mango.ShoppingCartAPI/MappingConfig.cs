using AutoMapper;
using Mango.ShoppingCartAPI.Models;
using Mango.ShoppingCartAPI.Models.Dto;

namespace Mango.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
